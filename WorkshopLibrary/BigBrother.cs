using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopLibrary
{
    public class BigBrother
    {
        private IRepository<Employee> _repository;

        public BigBrother(IRepository<Employee> repository)
        {
            _repository = repository;
        }

        //ToDo: get all employees sort by department and job title

        //ToDo: For a given manager get all employees who have notes associated with them

        //TODO: return a list of managers and the total number of employees that report to them.
    }
}
