using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace GerenciadorDeTarefas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult EfetuarLogin([FromBody] LoginRequisicaoDto requisicao)
        {
            try
            {
            }
            catch(Exception e)
            {
                _logger.LogError("Ocorreu erro ao efetuar login", e, requisicao);
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao efetuar o Login: {e)
            }
        }
        {

        }

    }
}
