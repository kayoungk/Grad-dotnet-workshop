using System;
using System.Collections.Generic;

namespace WorkshopLibrary
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
        public int Age
        {
            get { return CurrentAge(); }
        }
        public string DisplayName()
        {
            return $"{FirstName} {LastName}";
        }

        private int CurrentAge()
        {
            int age = 0;
            age = DateTime.Now.Year - DoB.Year;
            if (DateTime.Now.DayOfYear < DoB.DayOfYear)
                age = age - 1;

            return age;
        }
    }

   
    
}
