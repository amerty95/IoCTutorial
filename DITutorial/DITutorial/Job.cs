using System;
using System.Collections.Generic;
using System.Text;

namespace DITutorial
{
    public class Job
    {
        public string JobName { get; set; }
        public Employee Employee { get; set; }
        public int WorkedHour { get; private set; } = 0;   

        public void DoJob(int hour)
        {
            Logger logger = new Logger();
            WorkedHour += hour;
            logger.Log(Employee.Name + " worked " + hour + " hours.");

        }

        public void FinishJob()
        {
            Logger logger = new Logger();
            logger.Log(Employee.Name + " finished the job");

            Emailer emailer = new Emailer();
            emailer.SendMessage(Employee.Name + " " + Employee.Surname + " worked and finished the job");

        }

    }
}
