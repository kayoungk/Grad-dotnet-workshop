using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopLibrary
{
   public interface IManager
    {
        List<IEmployee> Employees { get; }

    }
}
