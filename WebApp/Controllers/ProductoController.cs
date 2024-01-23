using Application.UseCases.Commands.ProductoAgregar;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Application.UseCases.Query.GetProductosByAlmacen;
using Application.UseCases.Query.GetProductos;


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


        [HttpGet("all")]
        public async Task<IActionResult> ListaProductos( )
        {
            try
            {
                var query = new GetProductosQuery();
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






        [Route("byAlmacen")]
        [HttpPost]
        public async Task<IActionResult> ListaProductosPorInventarioDeAlmacen([FromBody] GetProductosByAlmacenQuery query)
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
