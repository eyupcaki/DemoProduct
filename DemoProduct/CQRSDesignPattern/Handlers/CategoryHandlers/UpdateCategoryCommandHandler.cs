using DemoProduct.Context;
using DemoProduct.CQRSDesignPattern.Commands.CategoryCommands;

namespace DemoProduct.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly CQRSContext _context;

        public UpdateCategoryCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handler(UpdateCategoryCommand command)
        {
            var values = _context.Categories.Find(command.CategoryId);
            values.CategoryName=command.CategoryName;
            _context.SaveChanges();
        }
    }
}
