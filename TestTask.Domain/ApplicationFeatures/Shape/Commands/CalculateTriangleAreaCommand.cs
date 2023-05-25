using MediatR;
using TestTask.Domain.Dto_s.Triangle;

namespace TestTask.Domain.ApplicationFeatures.Shape.Commands
{
    public class CalculateTriangleAreaCommand : IRequest<TriangleDto>
    {
        public double SideA { get; set; }

        public double SideB { get; set; }

        public double SideC { get; set; }

        public CalculateTriangleAreaCommand(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
    }
}
