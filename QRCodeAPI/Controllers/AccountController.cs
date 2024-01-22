
using BLL.Abstract;
using Common.DTO;
using Common.Security.Abstract;
using Common.Security.Concrete;
using DAL;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace QRCodeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly ITokenBlacklistService _tokenBlacklistService;
        public AccountController(IAccountService accountService, ITokenBlacklistService tokenBlacklistService)
        {
            _accountService = accountService;
            _tokenBlacklistService = tokenBlacklistService;
        }
        [Route("/Login")]
        [HttpPost]
        public async Task<IActionResult> login(LoginDto login)
        {
            var token = await _accountService.Authenticate(login);

            return Ok(token);
        }
        [Route("/Logout")]
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            var token = HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            _tokenBlacklistService.BlacklistToken(token);

            return Ok();
        }
    }
}
