﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DITutorial
{
    public class Emailer
    { 
        public void SendMessage(Employee employee, string text)
        {
            Console.WriteLine("Sending email to " + employee.Name + " " + employee.Surname + " this message: \n" + text);
        }

    }
}
