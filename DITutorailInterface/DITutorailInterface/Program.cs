using DITutorailInterface;
using System;

namespace DITutorialInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee myEmployee = Factory.CreateIEmployee();
            myEmployee.Name = "Mert";
            myEmployee.Surname = "Yavuz";
            myEmployee.Age = 25;


            IJob job = Factory.CreateIJob();
            job.Employee = myEmployee;
            job.JobName = "Doing an IoC presentation";
            

            job.DoJob(2);
            job.DoJob(1);
            job.FinishJob();
        }
    }
}
