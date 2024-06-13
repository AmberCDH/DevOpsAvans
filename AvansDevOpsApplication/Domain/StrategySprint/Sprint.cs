using AvansDevOpsApplication.Domain.ReportTemplate;
using AvansDevOpsApplication.Domain.SprintState;

namespace AvansDevOpsApplication.Domain.StrategySprint
{
    public abstract class Sprint : BacklogInterface, BacklogProvider
    {
        private List<BacklogItem> backlogItemInSprint;
        private string name;
        private DateTime startTime;
        private DateTime endTime;
        private Guid id;
        private ISprintState state;

        public Sprint(string name, DateTime startTime, DateTime endTime)
        {
            this.name = name;
            this.startTime = startTime;
            this.endTime = endTime;
            this.backlogItemInSprint = new List<BacklogItem>();
        }

        public virtual void SetState(ISprintState state) {
            this.state = state;
        }

        public void RemoveFromBacklog(Guid id)
        {
            state.RemoveBacklogItem(id);
        }

        public void AddItemToBacklog(BacklogItem backlogItem)
        {
           state.AddBacklogItem(backlogItem);
        }

        public List<BacklogItem> getBacklogItems()
        {
            return backlogItemInSprint;
        }
    }
}
