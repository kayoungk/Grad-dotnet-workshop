using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopLibrary
{
   public interface IRespository<T> where T:class, new()
    {
        IList<T> GetAll();
        T GetNew();
        bool AddOrUpdate(T value);
        bool Delete(T valueToDelete);
    }
}
