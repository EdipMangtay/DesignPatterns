using DesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BusinessLayer.Abstract
{
    public interface ICustomerService :IGenericService<Customer>
    {
    }
}
