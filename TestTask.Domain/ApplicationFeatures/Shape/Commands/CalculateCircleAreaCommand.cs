using MediatR;

namespace TestTask.Domain.ApplicationFeatures.Shape.Commands
{
    public class CalculateCircleAreaCommand : IRequest<double>
    {
        public double Radius { get; set; }

        public CalculateCircleAreaCommand(double radius)
        {
            Radius = radius;
        }
    }
}
