﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopLibrary
{
    public class FakeRepository : IRespository<Employee>
    {
        private List<Employee> _fakeEmployees;

        public FakeRepository()
        {
            _fakeEmployees = new List<Employee>();
            GenerateFakeEmployees();
        }
        public bool AddOrUpdate(Employee value)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Employee valueToDelete)
        {
            throw new NotImplementedException();
        }

        public IList<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetNew()
        {
            return new Employee();
        }

        private void GenerateFakeEmployees()
        {

        }
    }
}
