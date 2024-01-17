using Common.DTO;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Security.Abstract
{
    public interface ITokenHandler
    {
        public TokenDto CreateToken(int sicilId);
        string CreateRefreshToken();

    }
}
