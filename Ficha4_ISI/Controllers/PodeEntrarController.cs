using Microsoft.AspNetCore.Mvc;

namespace Ficha4_ISI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PodeEntrarController : ControllerBase
    {
        [HttpGet("Verificar")]
        public bool Verificar(string codigo, string email)
        {
            string[] codigosValidos = { "A1", "B2", "C3" };

            bool codigoOK = codigosValidos.Contains(codigo);
            bool emailOK = new UtilsController().ValidateEmail(email);

            return codigoOK && emailOK;
        }
    }
}