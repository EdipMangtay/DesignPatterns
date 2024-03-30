using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void Iinsert(T entity);
        void Iupdate(T entity);
        void Idelete(T entity);
        List<T> IGetAll();
        T IGetById(int id);
        void IMultiUpdate(List<T> t);
        //Bütün burasının amacı CRUD işlemlerini yapabilmek için oluşturulmuş bir interface
    }
}
