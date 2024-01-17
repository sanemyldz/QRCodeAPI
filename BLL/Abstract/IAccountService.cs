using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IAccountService
    {
        public TokenDto Authenticate(LoginDto loginParameters);
    }
}
