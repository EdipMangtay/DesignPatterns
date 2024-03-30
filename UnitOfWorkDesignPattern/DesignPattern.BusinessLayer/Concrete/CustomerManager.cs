using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.DataAccesLayer.Abstract;
using DesignPattern.DataAccesLayer.UnitOfWorks;
using DesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        private readonly IUnitOfWork _unitOfWork;

        public CustomerManager(ICustomerDal customerDal, IUnitOfWork unitOfWork)
        {
            _customerDal = customerDal;
            _unitOfWork = unitOfWork;
        }

        public void Idelete(Customer t)
        {
            _customerDal.delete(t);
            _unitOfWork.Save();
        }

        public List<Customer> IGetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer IGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public void Iinsert(Customer t)
        {
            _customerDal.insert(t);
            _unitOfWork.Save();
        }

        public void IMultiUpdate(List<Customer> t)
        {
            _customerDal.MultiUpdate(t);
            _unitOfWork.Save();
        }

        public void Iupdate(Customer entity)
        {
            _customerDal.update(entity);
            _unitOfWork.Save();
        }
    }
}
