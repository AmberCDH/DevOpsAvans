using AvansDevOpsApplication.Domain.StrategySprint;

namespace AvansDevOpsApplication.Domain.SprintState.ReviewSprintState
{
    public class CancelReviewState : ISprintState
    {
        public void AddBacklogItem(BacklogItem backlogItem)
        {
            Console.WriteLine("Sprint review is canceled");
        }

        public void RemoveBacklogItem(Guid id)
        {
            Console.WriteLine("Sprint review is canceled");
        }
    }
}
