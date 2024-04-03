using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Gerenciador.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AcessController:ControllerBase
    {
        [HttpGet]
        [Authorize(Policy ="EmailConfirm")]
        public IActionResult Get()
        {
            return Ok("Acesso Permitido");
        }
    }
}
