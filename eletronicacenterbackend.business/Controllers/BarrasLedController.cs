using eletronicacenterbackend.business.Service.Interface;
using eletronicacenterbackend.model.Model;
using Microsoft.AspNetCore.Mvc;

namespace eletronicacenterbackend.business.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BarrasLedController(IBarrasLedService _barrasLedService) : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetBarras()
        {
            try
            {
                var barras = await _barrasLedService.GetAllBarrasLed();
                return Ok(barras);
            }
            catch(Exception e)
            {
               return BadRequest(e.Message);
            }
        }

    }
}
