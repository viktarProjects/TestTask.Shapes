using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestTask.Domain.ApplicationFeatures.Products.Query;
using TestTask.Domain.ApplicationFeatures.Shape.Commands;

namespace TestTask.WebAPI.Controllers
{
    [Route("products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            try
            {
                var result = await _mediator.Send(new GetProductsQuery());

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
