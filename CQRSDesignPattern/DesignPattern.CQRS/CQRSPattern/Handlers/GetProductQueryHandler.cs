using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;

        }
        public List<GetProductQueryResult> Handle()
        {
            var values = _context.products.Select(x => new GetProductQueryResult()
            {
                ID = x.ProductID,
                ProductName = x.Name,
                Price = x.Price,
                Stock = x.Stock         // soldaki opsiyonel isimler önemli olan atamalar
            }).ToList();

            return values;
        }
    }
}
