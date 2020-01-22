using System;
using System.Collections.Generic;
using System.Text;

namespace DITutorialInterface
{
    public class Logger : ILogger
    {
        public void Log(string text)
        {
            Console.WriteLine("Time: " + DateTime.Now.ToString() + "| " + text);
        }
    }
}
