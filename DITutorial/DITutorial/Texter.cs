using System;
using System.Collections.Generic;
using System.Text;

namespace DITutorial
{
    public class Texter 
    {

        public void SendMessage(Employee employee, string text)
        {
            Console.WriteLine("Sending SMS to " + employee.Name + " " + employee.Surname + " this message: \n" + text);
        }
    }
}
