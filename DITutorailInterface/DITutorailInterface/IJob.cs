namespace DITutorialInterface
{
    public interface IJob
    {
        IEmployee Employee { get; set; }
        string JobName { get; set; }
        int WorkedHour { get; }

        void DoJob(int hour);
        void FinishJob();
    }
}