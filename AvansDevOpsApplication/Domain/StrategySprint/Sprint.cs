
using AvansDevOpsApplication.Domain.ReportTemplate;
using AvansDevOpsApplication.Domain.State;

namespace AvansDevOpsApplication.Domain.StrategySprint
{
    abstract class Sprint : BacklogInterface, BacklogProvider
    {
        private ISprintState createdState;
        private ISprintState activeState;
        private ISprintState state;

        private List<BacklogItem> backlogItemInSprint;

        private string name;
        private DateTime startTime;
        private DateTime endTime;

        private Guid id;

        public Sprint(string name, DateTime startTime, DateTime endTime)
        {
            this.name = name;
            this.startTime = startTime;
            this.endTime = endTime;
            this.backlogItemInSprint = new List<BacklogItem>();
        }

        public virtual void SetState(ISprintState state) { }

        public virtual ISprintState GetActiveState() 
        {
            return this.state;
        }
        public virtual ISprintState GetCreatedState() 
        {
            return this.createdState;
        }

        public BacklogItem RemoveFromBacklog(Guid id)
        {
            var item = backlogItemInSprint.Where(x => x.ID == id).FirstOrDefault();
            if (item != null)
            {
                backlogItemInSprint.Remove(item);
                return item;
            }
            else
            {
                return null;
            }
        }

        public BacklogItem AddItemToBacklog(BacklogItem backlogItem)
        {
            backlogItemInSprint.Add(backlogItem);
            return backlogItem;
        }

        public List<BacklogItem> getBacklogItems()
        {
            return backlogItemInSprint;
        }
    }
}
