namespace AvansDevOpsApplication.Domain.ActivityState
{
    public class ToDoActivityState : IActivityState
    {
        private Activity activity;
        public ToDoActivityState(Activity activity)
        {
            this.activity = activity;
        }

        public void ChangeState(IActivityState state)
        {
            if (activity.getState().GetType() == state.GetType())
            {
                Console.WriteLine("Activity already in ToDo state");
            } else
            {
                activity.SetState(state);
            }
        }
    }
}
