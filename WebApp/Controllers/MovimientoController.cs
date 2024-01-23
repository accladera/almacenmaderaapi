using Application.UseCases.Commands.MovimientoAgregar;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class MovimientoController : ControllerBase
    {
        private readonly ILogger<MovimientoController> _logger;
        private readonly IMediator _mediator;

        public MovimientoController(IMediator mediator, ILogger<MovimientoController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }
        [HttpPost]
        public async Task<IActionResult> CrearMovimiento([FromBody] MovimientoAgregarCommand command)
        {
            try
            {
                var resultGuid = await _mediator.Send(command);
                return Ok(resultGuid);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al registrar.");
                return StatusCode(500, ex.Message);
            }
        }
    }
}
