using DITutorialInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DITutorailInterface
{
    public class Texter : IMessageSender
    {
        public void SendMessage(IEmployee employee, string text)
        {
            Console.WriteLine("Sending SMS to " + employee.Name + " the text: " + text);
        }
    }
}
