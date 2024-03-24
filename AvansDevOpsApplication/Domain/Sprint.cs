using AvansDevOpsApplication.Domain.State;

namespace AvansDevOpsApplication.Domain
{

    public class Sprint
    {
        ISprintState createdState;
        ISprintState activeState;
        ISprintState finishedState;
        ISprintState pipelineState;
        ISprintState releasedState;
        ISprintState state;

        private Guid id;
        private string name;
        private DateTime startTime;
        private DateTime endTime;
        private List<BacklogItem> backlogItems;

        public Sprint(string name, DateTime startTime, DateTime endTime)
        {
            backlogItems = [];
            createdState = new CreatedState(this);
            activeState = new ActiveState(this);
            finishedState = new FinishedState(this);
            pipelineState = new PipelineState(this);
            releasedState = new ReleasedState(this);
            state = createdState;
            id = Guid.NewGuid();
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

        public ISprintState GetFinishedState()
        {
            return finishedState;
        }

        public ISprintState GetPipelineState()
        {
            return pipelineState;
        }

        public ISprintState GetReleasedState()
        {
            return releasedState;
        }

        public ISprintState State { get { return state; } }

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
