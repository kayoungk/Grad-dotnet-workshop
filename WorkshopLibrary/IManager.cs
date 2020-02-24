using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopLibrary
{
    public interface IManager
    {
        List<int> Employees { get; }
        List<EmployeeNote> EmployeeNotes {get;}

    }
}
