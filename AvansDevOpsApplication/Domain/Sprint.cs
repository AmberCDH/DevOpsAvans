using AvansDevOpsApplication.Domain.SprintState;

namespace AvansDevOpsApplication.Domain
{

    public class Sprint
    {
        ISprintState createdState;
        ISprintState activeState;
        ISprintState state;

        private Guid id;
        private string name;
        private DateTime startTime;
        private DateTime endTime;
        private List<BacklogItem> backlogItems;

        public Sprint(Guid id, string name, DateTime startTime, DateTime endTime)
        {
            backlogItems = [];
            createdState = new CreatedState(this);
            activeState = new ActiveState(this);
            state = createdState;
            this.id = id;
            this.name = name;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public void SetState(ISprintState state)
        {
            this.state = state;
        }

        public ISprintState GetCreatedState()
        {
            return createdState;
        }
        public ISprintState GetActiveState()
        {
            return activeState;
        }

        public Guid Id
        {
            get { return id; }
        }

        public List<BacklogItem> BacklogItems
        {
            get { return backlogItems; }
        }

        public void AddBacklogItem(BacklogItem backlogItem)
        {
            state.AddBacklogItem(backlogItem);
        }

        public void RemoveBacklogItem(Guid id)
        {
            state.RemoveBacklogItem(id);
        }
    }
}
