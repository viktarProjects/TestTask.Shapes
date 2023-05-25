using MediatR;
using TestTask.Domain.ApplicationFeatures.Shape.Commands;

namespace TestTask.Domain.ApplicationFeatures.Shape.Handlers.CommandHandlers
{
    public class CalculateCircleAreaCommandHandler : IRequestHandler<CalculateCircleAreaCommand, double>
    {
        private readonly double PI = Math.PI;

        public async Task<double> Handle(CalculateCircleAreaCommand request, CancellationToken cancellationToken)
        {
            var radius = request.Radius;

            var cicrleArea = PI * Math.Pow(radius, 2);

            //Possible manipulation with Database

            return cicrleArea;
        }
    }
}
