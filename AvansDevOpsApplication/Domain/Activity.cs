namespace AvansDevOpsApplication.Domain
{
    public class Activity
    {
        private string name;
        private string comment;
        private string movedTo;
        private string movedFrom;
        private DateTime time;
        private BacklogItem backlogItem;
        private ActivityState activityState;

        public Activity(string comment, DateTime time, BacklogItem backlogItem, string name)
        {
            this.comment = comment;
            this.time = time;
            this.backlogItem = backlogItem;
            this.name = name;
            activityState = ActivityState.Todo; 
        }

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
       
        public DateTime Time
        {
            get { return time; }
        }
        public string toString()
        {
            return "Activity ~ Comment; " + comment + " ~ " + time;
        }

        public ActivityState ActivityState { get { return activityState; } }

        public void SetState(ActivityState x)
        {
            switch (activityState)
            {
                case ActivityState.Todo:
                    if(x == ActivityState.Done)
                    {
                        activityState = x;
                        backlogItem.NotifyObserver("Activity: " + name + " completed");
                    }
                    break;
            }
        }
    }
}
