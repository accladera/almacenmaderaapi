using Application.UseCases.Commands.ProductoAgregar;
using Microsoft.AspNetCore.Mvc;
using MediatR;


namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly ILogger<ProductoController> _logger;
        private readonly IMediator _mediator;

        public ProductoController(IMediator mediator, ILogger<ProductoController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> CrearProducto([FromBody] ProductoAgregarCommand command)
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









    }
}
