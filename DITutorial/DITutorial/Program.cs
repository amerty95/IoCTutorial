using System;

namespace DITutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myEmployee = new Employee
            {
                Name = "Mert",
                Surname = "Yavuz",
                Age = 25
            };

            Job job = new Job
            {
                Employee = myEmployee,
                JobName = "Doing an IoC presentation"
            };

            job.DoJob(2);
            job.DoJob(1);
            job.FinishJob();
        }
    }
}
