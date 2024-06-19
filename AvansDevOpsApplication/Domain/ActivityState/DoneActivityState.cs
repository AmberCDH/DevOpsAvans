namespace AvansDevOpsApplication.Domain.ActivityState
{
    public class DoneActivityState : IActivityState
    {
        public void ChangeState(IActivityState state)
        {
            Console.WriteLine("This activity is already completed.");
        }
    }
}
