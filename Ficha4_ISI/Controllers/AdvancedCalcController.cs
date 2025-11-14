using Microsoft.AspNetCore.Mvc;

namespace Ficha4_ISI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdvancedCalcController : ControllerBase
    {
        [HttpGet("Pow")]
        public double Pow(double a, double b) => Math.Pow(a, b);

        [HttpGet("Abs")]
        public double Abs(double v) => Math.Abs(v);

        [HttpGet("Factorial")]
        public long Factorial(int n)
        {
            if (n < 0)
                return -1;

            long result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;

            return result;
        }
    }
}