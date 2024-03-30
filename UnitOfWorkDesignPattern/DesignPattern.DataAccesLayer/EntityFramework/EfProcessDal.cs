using DesignPattern.DataAccesLayer.Abstract;
using DesignPattern.DataAccesLayer.Concrete;
using DesignPattern.DataAccesLayer.Repositories;
using DesignPattern.EntityLayer;

namespace DesignPattern.DataAccesLayer.EntityFramework
{
    public class EfProcessDal :GenericRepository<Process>, IProcessDal
    {
        public EfProcessDal(Context context) : base(context)
        {
            
        }
    }
}
