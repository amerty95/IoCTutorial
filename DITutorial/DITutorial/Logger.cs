using System;
using System.Collections.Generic;
using System.Text;

namespace DITutorial
{
    public class Logger
    {
        public void Log(string text)
        {
            Console.WriteLine("Time: " + DateTime.Now.ToString() + "| " +text);
        }
    }
}
