namespace AvansDevOpsApplication.Domain.ActivityState
{
    public class DoneActivityState : IActivityState
    {
        private Activity activity;
        public DoneActivityState(Activity activity)
        {
            this.activity = activity;
        }

        public void ChangeState(IActivityState state)
        {
            Console.WriteLine("This activity is already completed.");
        }
    }
}
