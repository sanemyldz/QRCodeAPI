using BLL.Abstract;
using Common.DTO;
using Common.Security.Abstract;
using DAL.Abstract;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL.Concrete
{
    public class AccountService : IAccountService
    {
        private readonly IGenericRepository<MobileAppUser> _context;
        private readonly ITokenHandler _tokenHandler;
        public AccountService(IGenericRepository<MobileAppUser> context, ITokenHandler tokenHandler)
        {
            _context = context;
            _tokenHandler = tokenHandler;
        }
        public async Task<TokenDto> Authenticate(LoginDto loginParameters)
        {
            try
            {

                var user = await _context.GetFirstOrDefaultAsync(x => x.SicilNo == loginParameters.Username && x.Password == loginParameters.Password);

                if (user != null)
                {
                    //Kullanıcı girişinde yeni token ve refresh token oluşturulur. 
                    TokenDto token = _tokenHandler.CreateAccessToken(user.SicilNo ?? string.Empty);
                    //Refresh token değeri ve geçerlilik süresi veritabanına kaydedilir.
                    await _tokenHandler.UpdateRefreshTokenAsync(user, token.RefreshToken, token.RefreshTokenExpirationDate);

                    return token;
                }
                else
                    return new TokenDto { IsSuccess = false, ErrorMessage = "User not found!" };

            }
            catch (Exception ex)
            {
                return new TokenDto { IsSuccess = false, ErrorMessage = ex.Message };
            }
        }

        public async Task<TokenDto> RefreshTokenLoginAsync(string refreshToken)
        {
            try
            {
                //Access token süresi geçmiş ise refresh token kontrol edilir ve oturum süresini uzatmak için yeni bir access token oluşturulur.
                var user = await _context.FirstOrDefaultAsync(u => u.RefreshToken == refreshToken);
                if (user != null && user?.RefreshTokenExpirationDate > DateTime.UtcNow)
                {
                    TokenDto token = _tokenHandler.CreateAccessToken(user.SicilNo ?? string.Empty);
                    await _tokenHandler.UpdateRefreshTokenAsync(user, token.RefreshToken, token.RefreshTokenExpirationDate);

                    return token;
                }
                else
                    return new TokenDto { IsSuccess = false, ErrorMessage = "User not found!" };

            }
            catch (Exception ex)
            {
                return new TokenDto { IsSuccess = false, ErrorMessage = ex.Message };
            }
        }
    }
}
