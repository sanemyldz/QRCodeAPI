using Common.DTO;
using DAL.Models;
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
        public TokenDto CreateAccessToken(string sicilNo);
        string CreateRefreshToken();
        Task UpdateRefreshTokenAsync(MobileAppUser user, string? refreshToken, DateTime? refreshTokenExpirationDate);

    }
}
