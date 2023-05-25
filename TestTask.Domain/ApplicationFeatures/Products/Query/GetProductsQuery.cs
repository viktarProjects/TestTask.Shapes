using MediatR;
using TestTask.Domain.Dto_s.Product;

namespace TestTask.Domain.ApplicationFeatures.Products.Query
{
    public class GetProductsQuery : IRequest<List<ProductDto>>
    {
    }
}
