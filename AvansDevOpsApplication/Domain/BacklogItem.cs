
namespace AvansDevOpsApplication.Domain
{
    public class BacklogItem
    {
        private string name;
        private string description;
        private List<Activity> activitys;
        private User user;
        private bool wantsNotification;
        private string inList;
        private DateTime timeOfCreation;
        public BacklogItem() { }

    }
}
