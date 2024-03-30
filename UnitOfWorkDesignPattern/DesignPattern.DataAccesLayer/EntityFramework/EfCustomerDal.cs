using DesignPattern.DataAccesLayer.Abstract;
using DesignPattern.DataAccesLayer.Concrete;
using DesignPattern.DataAccesLayer.Repositories;
using DesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DataAccesLayer.EntityFramework
{
    public class EfCustomerDal :GenericRepository<Customer>,ICustomerDal
    {
        public EfCustomerDal(Context context) : base(context)
        {
            // base ifadesi ile GenericRepository sınıfının constructor'ını çalıştırıyoruz.
        }
    }
}
