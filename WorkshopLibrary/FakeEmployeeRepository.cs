using GenerateFakeUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkshopLibrary
{
    public class FakeEmployeeRepository : IRepository<Employee>
    {
        private List<Employee> _fakeEmployees;

        public FakeEmployeeRepository(int numberOfEmployees)
        {
            _fakeEmployees = GenerateFakeEmployees(numberOfEmployees); ;
            
        }
        public bool AddOrUpdate(Employee value)
        {
            var employee = _fakeEmployees.FirstOrDefault(e => e.Id == value.Id);
            if (employee == null)
            {
                AddNewEmployee(value);
            }else
            {
                employee.FirstName = value.FirstName;
                employee.LastName = value.LastName;
                //TODO: if new department need to update managers
                employee.Department = value.Department;
                employee.JobTitle = value.JobTitle;
            }
            return true;
        }
  
        public bool Delete(Employee valueToDelete)
        {
            if(valueToDelete is IManager)
            {
                throw new ArgumentException("Can't Delete an employee who is a manager", nameof(valueToDelete));
            }
            //TODO: delete employee

            return true;
        }

        public IList<Employee> GetAll()
        {
            return _fakeEmployees.AsReadOnly();
        }

        private void AddNewEmployee(Employee value)
        {
            int lastId = GetLastEmployeeId();
            value.Id = lastId + 1;
            _fakeEmployees.Add(value);
            var manager = _fakeEmployees.FirstOrDefault(e => e is IManager && e.Department == value.Department);
            (manager as IManager)?.Employees.Add(value.Id);
        }
        private int GetLastEmployeeId()
        {
            return _fakeEmployees.Max(e => e.Id);
        }
        private List<Employee> GenerateFakeEmployees(int employeesToGenerate)
        {
            var userGenerator = new EmployeeDataGenerator<Employee>(employeesToGenerate);
            var managers = new Dictionary<string, Manager>();
            var employees = new List<Employee>();


            foreach (var emp in userGenerator.Employees)
            {
                if (!managers.ContainsKey(emp.Department))
                {
                    var manager = new Manager
                    {
                        Id = emp.Id,
                        FirstName = emp.FirstName,
                        LastName = emp.LastName,
                        Department = emp.Department,
                        DoB = emp.DoB,
                        JobTitle = JobTitles.Manager
                    };
                    managers.Add(manager.Department, manager);
                    employees.Add(manager);
                }
                else
                {
                    employees.Add(emp);
                    managers[emp.Department].Employees.Add(emp.Id);
                    var empNotes = userGenerator.GenerateNotes(4, emp.Id);
                    managers[emp.Department].EmployeeNotes.AddRange(empNotes);

                }
            }

            return employees;
        }

        
    }
}
