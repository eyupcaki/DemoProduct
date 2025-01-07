using DemoProduct.Context;
using DemoProduct.CQRSDesignPattern.Results;

namespace DemoProduct.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class GetCategoryQueryCommandHandler
    {
        private readonly CQRSContext _context;

        public GetCategoryQueryCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public List<GetCategoryQueryResult> Handle() 
        {
            var values = _context.Categories.Select(x => new GetCategoryQueryResult
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName,
            });
            return values.ToList();
        }
    }
}