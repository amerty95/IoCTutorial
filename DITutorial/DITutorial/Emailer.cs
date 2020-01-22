using System;
using System.Collections.Generic;
using System.Text;

namespace DITutorial
{
    public class Emailer
    { 
        public void SendMessage(string text)
        {
            Console.WriteLine("Sending email with the following message: " + text);
        }

    }
}
