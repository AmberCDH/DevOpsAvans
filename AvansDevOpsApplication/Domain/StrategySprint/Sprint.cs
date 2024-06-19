using AvansDevOpsApplication.Domain.ReportTemplate;
using AvansDevOpsApplication.Domain.SprintState;
using AvansDevOpsApplication.Domain.SprintState.ReleaseSprintState;
using AvansDevOpsApplication.Domain.SprintState.ReviewSprintState;

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

        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
        public string Name { get => name; private set => name = value; }

        public Sprint(string name, DateTime startTime, DateTime endTime)
        {
            this.Name = name;
            this.startTime = startTime;
            this.endTime = endTime;
            this.backlogItemInSprint = new List<BacklogItem>();
        }

        public virtual ISprintState GetState()
        {
            return this.state;
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

        public void SetName(string name)
        {
            if (state.GetType() == typeof(CreatedReleaseState) || state.GetType() == typeof(CreatedReviewState))
            {
                Name = name;
            }
        }
        public void SetEndTime(DateTime endTime)
        {
            if (state.GetType() == typeof(CreatedReleaseState) || state.GetType() == typeof(CreatedReviewState))
            {
                EndTime = endTime;
            }
        }
        public void SetStartTime(DateTime startTime)
        {
            if (state.GetType() == typeof(CreatedReleaseState) || state.GetType() == typeof(CreatedReviewState))
            {
                StartTime = startTime;
            }
        }
    }
}
