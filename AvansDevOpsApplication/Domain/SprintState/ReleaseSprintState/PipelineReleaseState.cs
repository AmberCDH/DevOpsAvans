using AvansDevOpsApplication.Domain.StrategySprint;

namespace AvansDevOpsApplication.Domain.SprintState.ReleaseSprintState
{
    public class PipelineReleaseState : ISprintState
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
