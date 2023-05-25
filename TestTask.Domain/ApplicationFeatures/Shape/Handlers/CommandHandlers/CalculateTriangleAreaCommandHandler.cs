using MediatR;
using TestTask.Domain.ApplicationFeatures.Shape.Commands;
using TestTask.Domain.Dto_s.Triangle;

namespace TestTask.Domain.ApplicationFeatures.Shape.Handlers.CommandHandlers
{
    public class CalculateTriangleAreaCommandHandler : IRequestHandler<CalculateTriangleAreaCommand, TriangleDto>
    {
        public async Task<TriangleDto> Handle(CalculateTriangleAreaCommand request, CancellationToken cancellationToken)
        {
            var sideA = request.SideA;
            var sideB = request.SideB;
            var sideC = request.SideC;
            var isTriangular = false;

            var semiPerimeter = (sideA + sideB + sideC) / 2;

            var largestSide = Math.Max(sideA, Math.Max(sideB, sideC));

            if (largestSide == sideA)
            {
                isTriangular = Math.Pow(largestSide, 2) == Math.Pow(sideB, 2) + Math.Pow(sideC, 2);
            }
            else if (largestSide == sideB)
            {
                isTriangular = Math.Pow(largestSide, 2) == Math.Pow(sideA, 2) + Math.Pow(sideC, 2);
            }
            else if (largestSide == sideC)
            {
                isTriangular = Math.Pow(largestSide, 2) == Math.Pow(sideB, 2) + Math.Pow(sideA, 2);
            }

            var triangleArea = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));

            var triangleDto = new TriangleDto()
            {
                Area = triangleArea,
                Isrectangular = isTriangular
            };

            //possible manipulations with database

            return triangleDto;
        }
    }
}
