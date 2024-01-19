using Microsoft.Extensions.Configuration;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using Common.Security.Abstract;
using Common.DTO;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;
using DAL.Models;

namespace Common.Security.Concrete
{
    public class TokenHandler : ITokenHandler
    {
        readonly IConfiguration _configuration;
        readonly DEVELOP_MEYERContext _context;
        public TokenHandler(DEVELOP_MEYERContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;

        }
        //Refresh token değeri oluşturulur.!!Bizim oluşturduğumuz random bir değer olduğu için veri tabanına kayıt ediyoruz.
        public string CreateRefreshToken()
        {
            byte[] numbers = new byte[32];
            using RandomNumberGenerator random = RandomNumberGenerator.Create();
            random.GetBytes(numbers);
            return Convert.ToBase64String(numbers);
        }

        public TokenDto CreateAccessToken(string sicilNo)
        {

            //Security Key'in simetriği alınır.
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Token:SecurityKey"]));
            //Şifrelenmiş kimlik oluşturulur.
            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var ExpirationDate = DateTime.Now.AddMinutes(Convert.ToInt16(_configuration["Token:Expiration"]));

            //Oluşturulacak token'ın ayarları yapılır.
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                   {
                    new Claim("Id", sicilNo),                 
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),//JWT ID
                }),
                Expires = ExpirationDate,
                SigningCredentials = credentials,
                NotBefore = DateTime.Now,
                Issuer = _configuration["Token:Issuer"],
                Audience = _configuration["Token:Audience"]
            };

            //Token oluşturucu sınıf
            JwtSecurityTokenHandler jwtSecurityTokenHandler = new();
            var jwtSecurityToken = jwtSecurityTokenHandler.CreateToken(tokenDescriptor);
            
            var AccessToken = jwtSecurityTokenHandler.WriteToken(jwtSecurityToken);
            var RefreshToken = CreateRefreshToken();

            //REsfresh token ayarlamaları yapılır.
            var refreshTokenExpTime = _configuration["Token:RefreshTokenTimeFrame"]!;
            TimeSpan tsRefreshTokenExpTime = TimeSpan.Parse(refreshTokenExpTime);
            DateTime refreshTokenExpDate = DateTime.Now.Add(tsRefreshTokenExpTime);

            return new TokenDto { IsSuccess = true, AccessToken = AccessToken, RefreshToken = RefreshToken, ExpirationDate = ExpirationDate, RefreshTokenExpirationDate = refreshTokenExpDate };

        }

        //Veri tabanında refresh token ve expire date değerinin güncellemesi yapılır.
        public async Task UpdateRefreshTokenAsync(MobileAppUser user, string? refreshToken, DateTime? refreshTokenExpirationDate)
        {
            user.RefreshToken = refreshToken;
            user.RefreshTokenExpirationDate = refreshTokenExpirationDate;
            _context.MobileAppUsers.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
