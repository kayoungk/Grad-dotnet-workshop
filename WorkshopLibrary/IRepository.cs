using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopLibrary
{
   public interface IRepository<T> where T:class, IEmployee, new()
    {
        IList<T> GetAll();
        bool AddOrUpdate(T value);
        bool Delete(T valueToDelete);
    }
}
