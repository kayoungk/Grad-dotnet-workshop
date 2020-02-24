using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopLibrary
{
   public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime? DoB { get; set; }
        int Age { get; }
       string DisplayName();

    }
}
