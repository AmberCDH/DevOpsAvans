using AvansDevOpsApplication.Domain.ActivityState;

namespace AvansDevOpsApplication.Domain
{
    public class Activity
    {
        private string name;
        private string comment;

        private IActivityState activityState;

        private IActivityState todoActivityState;
        private IActivityState doneActivityState;

        public Activity(string comment, string name)
        {
            this.comment = comment;
            this.name = name;

            todoActivityState = new ToDoActivityState(this);
            doneActivityState = new DoneActivityState(this);

            this.activityState = todoActivityState;

        }

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
       
        public string toString()
        {
            return "Activity ~ Comment; " + comment;
        }

        public void SetState(IActivityState state)
        {
            this.activityState = state;
        }
        public void ChangeState(IActivityState state)
        {
            this.activityState.ChangeState(state);
        }

        public IActivityState getState()
        {
            return this.activityState;
        }
    }
}
