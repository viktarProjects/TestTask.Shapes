using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestTask.Domain.ApplicationFeatures.Shape.Commands;

namespace TestTask.WebAPI.Controllers
{
    [Route("calculate/shapes")]
    [ApiController]
    public class ShapeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ShapeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("/circle")]
        public async Task<IActionResult> GetCircleArea(double radius)
        {
            try
            {
                var result = await _mediator.Send(new CalculateCircleAreaCommand(radius));

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("/triangle")]
        public async Task<IActionResult> GetTriangleArea(double sideA, double sideB, double sideC)
        {
            try
            {
                var result = await _mediator.Send(new CalculateTriangleAreaCommand(sideA, sideB, sideC));

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
