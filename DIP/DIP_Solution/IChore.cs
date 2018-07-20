namespace DIP_Solution
{
    public interface IChore
    {
        string ChoreName { get; set; }
        double HoursWorked { get; set; }
        bool IsCompleted { get; set; }
        IPerson Owner { get; set; }

        void CompletedChore();
        void PerformedWork(int hours);
    }
}