using AvansDevOpsApplication.Domain.StrategySprint;

namespace AvansDevOpsApplication.Domain.SprintState.ReviewSprintState
{
    public class CreatedReviewState : ISprintState
    {
        ReviewSprint sprint;
        public CreatedReviewState(ReviewSprint sprint)
        {
            this.sprint = sprint;
        }

        public void AddBacklogItem(BacklogItem backlogItem)
        {
            sprint.getBacklogItems().Add(backlogItem);
        }

        public void RemoveBacklogItem(Guid id)
        {
            var x = sprint.getBacklogItems().Where(x => x.Id == id).SingleOrDefault();
            sprint.getBacklogItems().Remove(x);
        }

        //set name en begin and end date
        public void SetName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
