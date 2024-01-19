using BLL.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace QRCodeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class QRController : ControllerBase
    {
        readonly IQRService _qrService;
        public QRController(IQRService qrService)
        {
            _qrService = qrService;
        }
        [HttpGet]
        [Route("/Qr")]
        public IActionResult GenerateQRCode()
        {
            var qr = _qrService.GenerateQRCodeAsync();
            return Ok(qr);
        }
    }
}
