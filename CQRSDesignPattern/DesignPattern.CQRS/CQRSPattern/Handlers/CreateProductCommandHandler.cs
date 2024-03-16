using DesignPattern.CQRS.CQRSPattern.Comment;
using DesignPattern.CQRS.DAL;
using Microsoft.AspNetCore.Authentication;
using System;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    namespace DesignPattern.CQRS.CQRSPattern.Handlers
    {
        public class CreateProductCommandHandler
        {
            private readonly Context _context;
            public CreateProductCommandHandler(Context context)
            {
                _context = context;
            }
            public void Handle(CreateProductCommand command)
            {
                _context.products.Add(new Product
                {
                    Description = command.Description,
                    Name = command.Name,
                    Price = command.Price,
                    Status = true,
                    Stock = command.Stock
                });
                _context.SaveChanges();
            }
        }
    }
}
