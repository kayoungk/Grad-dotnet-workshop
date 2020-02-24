using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopLibrary
{
    public class Employee : IEmployee
    {
        const string UnknownUser = "Unknown Employee";
        public int Id { get ; set ; }
        public string Department { get ; set ; }
        public string JobTitle { get ; set ; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public DateTime? DoB { get ; set ; }

        public int Age { get => CurrentAge(); }

        public string DisplayName()
        {
            if (string.IsNullOrWhiteSpace(FirstName) && string.IsNullOrEmpty(LastName))
            {
                return UnknownUser;
            }

            var firstName = FirstName ?? "*****";
            return $"{firstName} {LastName}";
        }

        private int CurrentAge()
        {
            if (DoB.HasValue)
            {
                int age = 0;
                age = DateTime.Now.Year - DoB.Value.Year;
                if (DateTime.Now.DayOfYear < DoB.Value.DayOfYear)
                    age = age - 1;

                return age;
            }
            return 0;
        }
    }
}
