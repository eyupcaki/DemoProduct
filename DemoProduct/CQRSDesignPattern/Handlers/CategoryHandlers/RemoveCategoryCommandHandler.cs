using DemoProduct.Context;
using DemoProduct.CQRSDesignPattern.Commands.CategoryCommands;
using DemoProduct.CQRSDesignPattern.Handlers;

namespace DemoProduct.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly CQRSContext _context;

        public RemoveCategoryCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public void Handle(RemoveCategoryCommand command)
        {
            var values = _context.Categories.Find(command.CategoryId);
            _context.Categories.Remove(values);
            _context.SaveChanges();
        }
    }
}
