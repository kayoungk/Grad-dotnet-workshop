using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopLibrary
{
   public interface IEmployee : IPerson
    {
        int Id { get; set; }
        string Department { get; set; }
        string JobTitle { get; set; }

    }
}
