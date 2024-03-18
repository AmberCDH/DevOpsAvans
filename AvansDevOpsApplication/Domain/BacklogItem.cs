﻿
using System.Xml.Linq;

namespace AvansDevOpsApplication.Domain
{
    public class BacklogItem
    {
        private Guid id;
        private string name;
        private string description;
        private List<Activity> activitys;
        private User user;
        private bool wantsNotification;
        private string inList;
        private DateTime timeOfCreation;
        public BacklogItem(string name, string description, List<Activity>? activitys, DateTime timeOfCreation, string inList)
        {
            this.name = name;
            this.description = description;
            this.timeOfCreation = timeOfCreation;
            this.inList = inList;
            this.activitys = activitys ?? new List<Activity>();
            this.id = Guid.NewGuid();
        }

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public User User { get => user; set => user = value; }
        public bool WantsNotification { get => wantsNotification; set => wantsNotification = value; }
        public string InList { get => inList; set => inList = value; }
        public DateTime TimeOfCreation { get => timeOfCreation; set => timeOfCreation = value; }
        public List<Activity> Activitys { get => activitys; set => activitys = value; }
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

        public Guid Id
        {
            get { return id; }
        }
    }
}
