﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopLibrary
{
    public class Manager : Employee, IManager
    {
        public List<IEmployee> Employees { get; }

        public Manager()
        {
            Employees = new List<IEmployee>();
        }
    }
}
