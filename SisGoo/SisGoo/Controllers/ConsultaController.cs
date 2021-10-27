using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SisGoo.Services;

namespace SisGoo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConsultaController : ControllerBase
    {
        private readonly ILogger<ConsultaController> _logger;
        private IConsultaService _consultaService;

        public ConsultaController(ILogger<ConsultaController> logger, IConsultaService consultaService)
        {
            _logger = logger;
            _consultaService = consultaService;
        }

        [HttpGet("{frase}")]
        public IActionResult Get(string frase)
        {
            if (!string.IsNullOrEmpty(frase))
            {
                return Ok(_consultaService.Buscar(frase));
            }
            return BadRequest("Invalid Input");
        }
    }
}
