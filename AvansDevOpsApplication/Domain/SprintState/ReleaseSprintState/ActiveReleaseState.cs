using AvansDevOpsApplication.Domain.StrategySprint;

namespace AvansDevOpsApplication.Domain.SprintState.ReleaseSprintState
{
    public class ActiveReleaseState : ISprintState
    {
        private ReleaseSprint sprint;
        public ActiveReleaseState(ReleaseSprint sprint)
        {
            this.sprint = sprint;
        }

        public void RemoveBacklogItem(Guid id)
        {
            var x = sprint.getBacklogItems().Where(x => x.Id == id).SingleOrDefault();
            sprint.getBacklogItems().Remove(x);
        }

        public void AddBacklogItem(BacklogItem backlogItem)
        {
            sprint.getBacklogItems().Add(backlogItem);
        }
    }
}
