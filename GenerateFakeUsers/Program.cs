using System;
using System.Collections.Generic;
using System.Linq;
using WorkshopLibrary;

namespace GenerateFakeUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var userGenerator = new EmployeeDataGenerator<Employee>(15);

            foreach (var emp in userGenerator.Employees)
            {
                Console.WriteLine($"{emp.Id}:{ emp.DisplayName()} - {emp.Department}: {emp.JobTitle}");
            }

            var employees = new List<IEmployee> { new Manager { FirstName = "Bob" } };

            var result = employees.Where(e => e is IManager);
            foreach (var r in result)
            {
                Console.WriteLine(r.GetType().Name);
            }

            var notes = userGenerator.GenerateNotes(2, 1);

            foreach (var note in notes)
            {
                Console.WriteLine(note.ToString());
            }

            Console.ReadLine();
        }
    }
}
