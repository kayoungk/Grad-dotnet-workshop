using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopLibrary
{
    public class Manager : Employee, IManager
    {
        public List<int> Employees { get; }

        public List<EmployeeNote> EmployeeNotes { get; }

        public Manager()
        {
            Employees = new List<int>();
            EmployeeNotes = new List<EmployeeNote>();
        }
    }
}
