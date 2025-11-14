using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace Ficha4_ISI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UtilsController : ControllerBase
    {
        [HttpGet("ValidateEmail")]
        public bool ValidateEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
    }
}