using DemoProduct.Context;
using DemoProduct.CQRSDesignPattern.Commands.ProductCommands;

namespace DemoProduct.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class UpdateProductCommandHandler
    {
        private readonly CQRSContext _context;

        public UpdateProductCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            var value = _context.Products.Find(command.ProductId);
            value.ProductName = command.ProductName;
            value.ProductStock= command.ProductStock;
            value.CategoryId = command.CategoryId;  
            _context.SaveChanges();

        }
    }
}
