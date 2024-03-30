using DesignPattern.DataAccesLayer.Abstract;
using DesignPattern.DataAccesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DataAccesLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context;
        public GenericRepository(Context context)
        {
            _context = context; // Dependency Injection ile Context sınıfını enjekte ediyoruz.
        }
        public void delete(T t)
        {
            _context.Remove(t);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList(); // T tipindeki entity'lerin tüm verilerini veritabanından çekme işlemi.
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id); // T tipindeki entity'lerin primary key'ine göre veritabanından veri çekme işlemi.
        }

        public void insert(T t)
        {
            _context.Add(t);
        }

        public void MultiUpdate(List<T> t)
        {
            _context.UpdateRange(t);
        }

        public void update(T t)
        {
            _context.Update(t);
        }
    }
}
