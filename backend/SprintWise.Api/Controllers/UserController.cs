using Microsoft.AspNetCore.Mvc;

namespace SprintWise.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")] 
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { mensagem = "API funcionando corretamente!" });
        }
    }
}
