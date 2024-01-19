
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

namespace QRCodeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
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
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Ok();
        }

    }
}
