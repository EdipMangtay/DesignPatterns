using DesignPattern.CQRS.CQRSPattern.Command;
using DesignPattern.CQRS.DAL;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            var values = _context.products.Find(command.ProductID);

            values.Price = command.Price;
            values.Name = command.Name;
            values.Status = true;
            values.Stock = command.Stock;
            values.Description = command.Description;
            _context.SaveChanges();
        }
    }
}
