using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabinet.idao
{
    interface Idao<T>
    {
        bool create(T o);
        bool delete(T o);
        bool update(T o);
        T getById(int id);
        List<T> getAll();
    }
}
