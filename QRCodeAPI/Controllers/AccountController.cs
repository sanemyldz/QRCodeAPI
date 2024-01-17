using Common.DTO;
using Common.Security.Abstract;
using Common.Security.Concrete;
using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QRCodeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly IConfiguration _configuration;
        private readonly ITokenHandler _tokenHandler;
        public AccountController(IConfiguration configuration, ITokenHandler tokenHandler)
        {
            _configuration = configuration;
            _tokenHandler = tokenHandler;
        }

       
    }
}
