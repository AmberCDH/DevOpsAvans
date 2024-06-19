using AvansDevOpsApplication.Domain.StrategySprint;

namespace AvansDevOpsApplication.Domain.SprintState.ReviewSprintState
{
    public class FinishedReviewState : ISprintState
    {
        public void AddBacklogItem(BacklogItem backlogItem)
        {
            Console.WriteLine("Sprint review is finished");
        }

        public void RemoveBacklogItem(Guid id)
        {
            Console.WriteLine("Sprint review is finished");
        }
    }
}
