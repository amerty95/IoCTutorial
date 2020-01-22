using System;
using System.Collections.Generic;
using System.Text;

namespace DITutorialInterface
{
    public class Job : IJob
    {
        ILogger logger;
        IMessageSender messageSender;
        public string JobName { get; set; }
        public IEmployee Employee { get; set; }
        public int WorkedHour { get; private set; } = 0;


        public Job(ILogger logger, IMessageSender messageSender)
        {
            this.logger = logger;
            this.messageSender = messageSender;
        }
        public void DoJob(int hour)
        {
            ILogger logger = new Logger();
            WorkedHour += hour;
            logger.Log(Employee.Name + " worked " + hour + " hours.");

        }

        public void FinishJob()
        {
            logger.Log(Employee.Name + " finished the job");

            messageSender.SendMessage(Employee, "You finished the job!!!!");

        }

    }
}
