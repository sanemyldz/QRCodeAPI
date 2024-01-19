using Common.DTO;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IAccountService
    {
        public Task<TokenDto> Authenticate(LoginDto loginParameters);
    }
}
