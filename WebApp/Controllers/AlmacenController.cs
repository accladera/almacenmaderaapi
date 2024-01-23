using Application.UseCases.Commands.AlmacenAgregaProducto;
using Application.UseCases.Query.GetAlmacenes;
using Application.UseCases.Query.GetAlmacenesBySucursal;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class AlmacenController : ControllerBase
    {
        private readonly ILogger<AlmacenController> _logger;
        private readonly IMediator _mediator;

        public AlmacenController(IMediator mediator, ILogger<AlmacenController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }


        [HttpPost("almacenarProducto")]
        public async Task<IActionResult> AlmacenarProducto([FromBody] AlmacenAgregarProductoCommand command)
        {
            try
            {
                var resultGuid = await _mediator.Send(command);
                return Ok(resultGuid);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al registrar");
                return StatusCode(500, ex.Message);
            }
        }



        [HttpGet("all")]
        public async Task<IActionResult> ListaAlmacenes()
        {
            try
            {
                var query = new GetAlmacenesQuery();
                var list = await _mediator.Send(query);

                if (list == null)
                    return BadRequest();

                return Ok(list);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                return BadRequest(ex.Message);
            }
        }






        [Route("bySucursal")]
        [HttpPost]
        public async Task<IActionResult> ListaAlmacenesPorSucursal([FromBody] GetAlmacenesBySucursalQuery query)
        {
            try
            {
                var list = await _mediator.Send(query);

                if (list == null)
                    return BadRequest();

                return Ok(list);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                return BadRequest(ex.Message);
            }
        }

    }
}
