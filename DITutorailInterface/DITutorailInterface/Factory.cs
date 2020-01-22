using DITutorialInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DITutorailInterface
{
    public class Factory
    {
        public static IEmployee CreateIEmployee()
        {
            return new Employee();
        }

        public static IJob CreateIJob()
        {
            return new Job(CreateILogger(), CreateMessageSender());
        }

        public static ILogger CreateILogger()
        {
            return new Logger();
        }

        public static IMessageSender CreateMessageSender()
        {
            return new Emailer();
        }

    }
}
