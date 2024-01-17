using BLL.Abstract;
using Common.DTO;
using Common.Security.Abstract;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class AccountService : IAccountService
    {
        private readonly DEVELOP_MEYERContext _context;
        private readonly ITokenHandler _tokenHandler;
        public AccountService(DEVELOP_MEYERContext context, ITokenHandler tokenHandler)
        {
            _context = context;
            _tokenHandler = tokenHandler;
        }
        public TokenDto Authenticate(LoginDto loginParameters)
        {
            try
            {

                var user = _context.MobileAppUsers.Where(x => x.SicilNo == loginParameters.Username).Where(x => x.Password == loginParameters.Password).FirstOrDefault();

                if (user != null)
                {
                    return _tokenHandler.CreateToken(loginParameters.SicilId ?? 0);
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
