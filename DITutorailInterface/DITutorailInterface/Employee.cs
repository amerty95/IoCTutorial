using System;
using System.Collections.Generic;
using System.Text;

namespace DITutorialInterface
{
    public class Employee : IEmployee
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public int Age { get; set; }


    }
}
