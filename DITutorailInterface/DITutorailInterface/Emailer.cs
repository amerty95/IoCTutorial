using System;
using System.Collections.Generic;
using System.Text;

namespace DITutorialInterface
{
    public class Emailer : IMessageSender
    {
        public void SendMessage(IEmployee employee, string text)
        {
            Console.WriteLine("Sending email to " + employee.Name + " " + employee.Surname + " this message: \n" + text);
        }

    }
}
