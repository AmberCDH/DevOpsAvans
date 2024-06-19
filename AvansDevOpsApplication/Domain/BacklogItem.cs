using AvansDevOpsApplication.Domain.ActivityState;
using AvansDevOpsApplication.Domain.ItemState;
using AvansDevOpsApplication.Domain.NotificationObserver;

namespace AvansDevOpsApplication.Domain
{
    public class BacklogItem : INotificationSubject
    {
        private Guid id;
        private string name;
        private string description;
        private List<Activity> activitys;
        private User user;
        private bool wantsNotification;
        private int effort;
        private DateTime timeOfCreation;
        private DateTime timeCompleted;
        private List<User> assignedUsers = [];

        private IItemState itemState;

        private IItemState doingState;
        private IItemState doneState;
        private IItemState todoState;
        private IItemState testingState;
        private IItemState readyForTestingState;

        public BacklogItem(string name, string description, List<Activity>? activitys, DateTime timeOfCreation)
        {
            this.name = name;
            this.description = description;
            this.timeOfCreation = timeOfCreation;
            this.activitys = activitys ?? new List<Activity>();
            this.id = Guid.NewGuid();
 
            doingState = new DoingState(this);
            doneState = new DoneState();
            todoState   = new TodoState(this);
            testingState = new TestingState(this);
            readyForTestingState = new ReadyForTestingState(this);
            this.itemState = todoState;
        }

        public string Name { get => name; set => name = value; }
        public Guid ID { get => id; }
        public string Description { get => description; set => description = value; }
        public User User { get => user; set => user = value; }
        public bool WantsNotification { get => wantsNotification; set => wantsNotification = value; }
        public DateTime TimeOfCreation { get => timeOfCreation; set => timeOfCreation = value; }
        public List<Activity> Activitys { get => activitys; set => activitys = value; }
        public List<User> AssigedUsers { get => assignedUsers; set => assignedUsers = value; }
        public void AddActivityToList(Activity activity)
        {
            activitys.Add(activity);
        }

        // Alleen als een user eraan gekoppeld is, kan deze verplaatst worden,
        // notificaties geabboneerd en uit de backlog komen(inList van een een ander komen).
        public string toString()
        {
            return "BacklogItem ~ Name; " + name + "; description ~ " + description + "; timeOfCreation ~ " + timeOfCreation + "; Activity's ~ " + activitys.Count;

        }

        public void NotifyObserver(string message)
        {
            foreach (User user in assignedUsers)
            {
                user.GetNotificationService().Update(message);
            }
        }

        public void AssignUser(User user)
        {
            itemState.AssignUser(user);
        }

        public void RemoveUser(User user)
        {
            itemState.RemoveUser(user);
        }

        public Guid Id
        {
            get { return id; }
        }

        public DateTime TimeCompleted
        { get { return timeCompleted; } }
        public int Effort
        {
            get { return effort; }
            set {  effort = value; }
        }
        public void ChangeState(IItemState state)
        {
            NotifyObserver(name + " changed state");
            itemState.ChangeState(state);
        }

        public void SetState(IItemState state)
        {
            this.itemState = state;
        }

        public IItemState GetTodoState()
        {
            return todoState;
        }

        public IItemState GetTestingState()
        {
            return testingState;
        }

        public IItemState GetDoneState()
        {
            return doneState;
        }
        public IItemState GetReadyForTestingState()
        {
            return readyForTestingState;
        }


        public IItemState GetDoingState()
        {
            return doingState;
        }
        public IItemState GetState()
        {
            return itemState;
        }

        public bool activitysDone()
        {
            foreach(Activity a in activitys)
            {
                if (a.getState().GetType() != typeof(DoneActivityState))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
