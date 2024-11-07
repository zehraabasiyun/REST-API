using Microsoft.AspNetCore.Mvc;

namespace REST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToplamController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetToplam(int a, int b)
        {
            int toplam = a + b;
            return Ok(new { sonuc = toplam });
        }
    }
}
