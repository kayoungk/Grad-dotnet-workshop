using Bogus;
using System;
using System.Collections.Generic;
using System.Text;
using WorkshopLibrary;

namespace GenerateFakeUsers
{
    public class EmployeeDataGenerator<T> where T : class, IEmployee
    {
        private List<string> _fakeDepartments = new List<string> { "Department One", "Department Two", "Deparment Three" };
        private List<string> _fakeJobTitles = new List<string> { "Job Title One", "Job Title Two", "Job Title Three", "Job Title Four" };
        private  Queue<T> _employees = new Queue<T>();
        private Random _random = new Random();

        public Queue<T> Employees {
            get { return _employees; }
        }
        public EmployeeDataGenerator(int totalEmployees)
        {
            CreateFakeUsers(totalEmployees);
        }
        public List<EmployeeNote> GenerateNotes(int possibleNumberOfNotes, int employeeId)
        {
            Randomizer.Seed = new Random(2345);
            var startDate = new DateTime(2019, 1, 1);
            var endDate = new DateTime(2020, 2, 1);
            var noteTypes = new[] { NoteTypes.Feedback, NoteTypes.FollowUp, NoteTypes.Information };

            var faker = new Faker<EmployeeNote>()
                .RuleFor(n => n.EmployeeId, f => employeeId)
                .RuleFor(n => n.Created, f => f.Date.Between(startDate, endDate))
                .RuleFor(n => n.NoteType, f => f.PickRandom(noteTypes))
                .RuleFor(n => n.Text, f => f.Lorem.Sentence(5,10));

            return faker.Generate(_random.Next(0,possibleNumberOfNotes));
        }
        private void CreateFakeUsers(int totalEmployees)
        {
            Randomizer.Seed = new Random(totalEmployees);
            var id = 0;
            var faker = new Faker<T>()
                .RuleFor(e => e.Id, f => ++id)
                .RuleFor(e => e.FirstName, f => f.Person.FirstName)
                .RuleFor(e => e.LastName, f => f.Person.LastName)
                .RuleFor(e => e.DoB, f => f.Person.DateOfBirth)
                .RuleFor(e => e.Department, f => f.PickRandom(_fakeDepartments))
                .RuleFor(e => e.JobTitle, f => f.PickRandom(_fakeJobTitles))
                ;

            var generatedUsers = faker.Generate(totalEmployees);
            _employees = new Queue<T>(generatedUsers);
        }
    }
}
