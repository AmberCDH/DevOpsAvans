using AvansDevOpsApplication.Domain.StrategySprint;

namespace AvansDevOpsApplication.Domain.SprintState.ReviewSprintState
{
    public class PipelineReviewState : ISprintState
    {
        public void AddBacklogItem(BacklogItem backlogItem)
        {
            Console.WriteLine("Sprint is in pipeline state. Cannot add backlogitems");
        }

        public void RemoveBacklogItem(Guid id)
        {
            Console.WriteLine("Sprint is in pipeline state. Cannot remove backlogitems");
        }
    }
}
