using AvansDevOpsApplication.Domain.StrategySprint;

namespace AvansDevOpsApplication.Domain.SprintState.ReleaseSprintState
{
    public class CreatedReleaseState : ISprintState
    {
        ReleaseSprint sprint;
        public CreatedReleaseState(ReleaseSprint sprint)
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

        //set name en begin and end date
    }
}
