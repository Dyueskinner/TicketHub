using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicketHub.Properties;

namespace TicketHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentInfoController : ControllerBase
    {
        private readonly ILogger<PaymentInfoController> _logger;

        public PaymentInfoController(ILogger<PaymentInfoController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok("Welcome to my api");
        }

        [HttpPost]
        public IActionResult Post([FromBody]PaymentInfo paymentInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid details.");
            }

            return Ok(paymentInfo);

        }
    }

  
}
