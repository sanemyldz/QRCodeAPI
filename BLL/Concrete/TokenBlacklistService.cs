using BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BLL.Concrete.TokenBlacklistService;

namespace BLL.Concrete
{
    public class TokenBlacklistService : ITokenBlacklistService
    {
        private readonly HashSet<string> blacklistedTokens = new HashSet<string>();

        public bool IsTokenBlacklisted(string token)
        {
            return blacklistedTokens.Contains(token);
        }

        public void BlacklistToken(string token)
        {
            blacklistedTokens.Add(token);
        }

    }
}
