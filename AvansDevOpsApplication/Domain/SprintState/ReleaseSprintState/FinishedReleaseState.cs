using AvansDevOpsApplication.Domain.StrategySprint;

namespace AvansDevOpsApplication.Domain.SprintState.ReleaseSprintState
{
    public class FinishedReleaseState : ISprintState
    {
        public void AddBacklogItem(BacklogItem backlogItem)
        {
            Console.WriteLine("Sprint is finished");
        }

        public void RemoveBacklogItem(Guid id)
        {
            Console.WriteLine("Sprint is finished");
        }
    }
}
