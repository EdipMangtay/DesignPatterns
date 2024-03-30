using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DataAccesLayer.UnitOfWorks
{
    public interface IUnitOfWork
    {
        void Save();
    }
}
