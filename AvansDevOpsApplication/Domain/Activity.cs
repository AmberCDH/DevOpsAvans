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

        public Activity(string comment, string movedTo, string movedFrom, DateTime time, BacklogItem backlogItem, string name)
        {
            this.comment = comment;
            this.movedTo = movedTo;
            this.movedFrom = movedFrom;
            this.time = time;
            this.backlogItem = backlogItem;
            this.name = name;
            this.activityState = ActivityState.Todo; 
        }

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
        public string MovedTo
        {
            get { return movedTo; }
            set { movedTo = value; }
        }
        public string MovedFrom
        {
            get { return movedFrom; }
            set { movedFrom = value; }
        }
        public DateTime Time
        {
            get { return time; }
        }
        public string toString()
        {
            return "Activity ~ Comment; " + comment + " ~ " + time;
        }

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
