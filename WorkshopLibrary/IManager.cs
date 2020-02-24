using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopLibrary
{
    interface IManager
    {
        List<IEmployee> Employees { get; }

    }
}
