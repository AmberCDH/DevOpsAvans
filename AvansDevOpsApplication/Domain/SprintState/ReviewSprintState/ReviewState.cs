using AvansDevOpsApplication.Domain.StrategySprint;

namespace AvansDevOpsApplication.Domain.SprintState.ReviewSprintState
{
    public class ReviewState : ISprintState
    {
        public void AddBacklogItem(BacklogItem backlogItem)
        {
            Console.WriteLine("Sprint is being reviewed");
        }

        public void RemoveBacklogItem(Guid id)
        {
            Console.WriteLine("Sprint is being reviewed");
        }
    }
}
