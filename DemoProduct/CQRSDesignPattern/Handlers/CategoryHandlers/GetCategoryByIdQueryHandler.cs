using DemoProduct.Context;
using DemoProduct.CQRSDesignPattern.Results.CategoryResults;
using DemoProduct.CQRSDesignPattern.Queries.CategoryQueries;
using DemoProduct.Entities;
using System.Drawing.Design;

namespace DemoProduct.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly CQRSContext _context;

        public GetCategoryByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public GetCategoryByIdQueryResult Handle(GetCategoryByIdQuery query)
        {
            var value = _context.Categories.Find(query.CategoryId);
            return new GetCategoryByIdQueryResult
            {
                CategoryId = value.CategoryId,
                CategoryName = value.CategoryName
            };
        }
    }
}
