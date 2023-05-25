using MediatR;
using Microsoft.EntityFrameworkCore;
using TestTask.Data.DataContext;
using TestTask.Data.Models;
using TestTask.Domain.ApplicationFeatures.Products.Query;
using TestTask.Domain.Dto_s.Product;

namespace TestTask.Domain.ApplicationFeatures.Products.Handlers.QueryHandlers
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, List<ProductDto>>
    {
        private readonly ApplicationContext _context;

        public GetProductsQueryHandler(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<ProductDto>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var result = await _context.Products
                .Select(p => new ProductDto() {
                    Name = p.Name,
                    Categories = p.Categories.Select(x => x.Name).ToArray(),
                }).ToListAsync();

            return result;
        }
    }
}
