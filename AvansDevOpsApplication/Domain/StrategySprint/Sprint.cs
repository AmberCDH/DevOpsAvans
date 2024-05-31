
using AvansDevOpsApplication.Domain.State;

namespace AvansDevOpsApplication.Domain.StrategySprint
{
    abstract class Sprint
    {
        private ISprintState createdState;
        private ISprintState activeState;
        private ISprintState state;

        private string name;
        private DateTime startTime;
        private DateTime endTime;

        private Guid id;
        public Sprint()
        {

        }

        public virtual void RemoveBacklogItem(Guid id) { }
        public virtual void AddBacklogItem(BacklogItem backlogItem) { }
        public virtual void SetState(ISprintState state) { }

        public virtual ISprintState GetActiveState() 
        {
            return this.state;
        }
        public virtual ISprintState GetCreatedState() 
        {
            return this.createdState;
        }
    }
}
