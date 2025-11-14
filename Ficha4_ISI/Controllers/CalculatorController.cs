using Microsoft.AspNetCore.Mvc;

namespace Ficha4_ISI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("Add")]
        public double Add(double a, double b) => a + b;

        [HttpGet("Sub")]
        public double Sub(double a, double b) => a - b;

        [HttpGet("Mul")]
        public double Mul(double a, double b) => a * b;

        [HttpGet("Div")]
        public ActionResult<double> Div(double a, double b)
        {
            if (b == 0)
                return BadRequest("Divisão por zero não é permitida.");
            return a / b;
        }
    }
}