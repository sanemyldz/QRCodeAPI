using Microsoft.Extensions.Configuration;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using Common.Security.Abstract;
using Common.DTO;
using System.Security.Claims;

namespace Common.Security.Concrete
{
    public class TokenHandler : ITokenHandler
    {
        readonly IConfiguration _configuration;
        public TokenHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string CreateRefreshToken()
        {
            byte[] numbers = new byte[32];
            using RandomNumberGenerator random = RandomNumberGenerator.Create();
            random.GetBytes(numbers);
            return Convert.ToBase64String(numbers);
        }

        public TokenDto CreateToken(int sicilId)
        {

            //Security Key'in simetriği alınır.
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Token:SecurityKey"]));

            //Şifrelenmiş kimlik oluşturulur.
            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var ExpirationDate = DateTime.Now.AddMinutes(Convert.ToInt16(_configuration["Token:Expiration"]));

            //Oluşturulacak olan token ayarları yapılır.
            JwtSecurityToken jwtSecurityToken = new(
                issuer: _configuration["Token:Issuer"],
                audience: _configuration["Token:Audience"],
                expires: ExpirationDate,
                notBefore: DateTime.Now,
                signingCredentials: credentials
                );

            //Token oluşturucu sınıf
            JwtSecurityTokenHandler jwtSecurityTokenHandler = new();

            var AccessToken = jwtSecurityTokenHandler.WriteToken(jwtSecurityToken);

            var RefreshToken = CreateRefreshToken();

            var refreshTokenExpTime = _configuration["Token:RefreshTokenTimeFrame"]!;
            TimeSpan tsRefreshTokenExpTime = TimeSpan.Parse(refreshTokenExpTime);
            DateTime refreshTokenExpDate = DateTime.Now.Add(tsRefreshTokenExpTime);


            return new TokenDto { IsSuccess = true, AccessToken = AccessToken, RefreshToken = RefreshToken, ExpirationDate = ExpirationDate, RefreshTokenExpirationDate = refreshTokenExpDate };

        }


    }
}
