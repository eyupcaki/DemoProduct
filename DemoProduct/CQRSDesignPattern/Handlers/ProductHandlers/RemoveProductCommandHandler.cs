﻿using DemoProduct.Context;
using DemoProduct.CQRSDesignPattern.Commands.ProductCommands;

namespace DemoProduct.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class RemoveProductCommandHandler
    {
        private readonly CQRSContext _context;
        public RemoveProductCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(RemoveProductCommand command)
        {
            var value = _context.Products.Find(command.ProductId);
            _context.Products.Remove(value);
            _context.SaveChanges();
        }
    }
}
