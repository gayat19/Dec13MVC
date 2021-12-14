using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppFromStart.Services
{
    public interface IRepo<T>
    {
        ICollection<T> GetAll();
        bool Add(T t);
        T Get(int id);
    }
}
