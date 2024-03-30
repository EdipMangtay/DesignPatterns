using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DataAccesLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void insert(T entity);
        void update(T entity);
        void delete(T entity);
        List<T> GetAll();
        T GetById(int id);
        void MultiUpdate(List<T> t);
        //Bütün burasının amacı CRUD işlemlerini yapabilmek için oluşturulmuş bir interface

    }
}
