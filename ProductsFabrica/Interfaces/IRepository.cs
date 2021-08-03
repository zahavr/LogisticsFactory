using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsFactory.Interfaces
{
    public interface IRepository<T> where T : new()
    {
        T GetById(int id);
        IReadOnlyList<T> GetAll();
        bool DeleteById(int id);
        bool Add(T entity);
    }
}
