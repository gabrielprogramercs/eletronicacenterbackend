using eletronicacenterbackend.model.Model;
using Microsoft.AspNetCore.Mvc;

namespace eletronicacenterbackend.business.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BarrasLedController : ControllerBase
    {
        public IActionResult GetBarras()
        {
            var barras = new List<barras_led> { };
            return Ok();
        }
    }
}
