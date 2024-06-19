using AvansDevOpsApplication.Domain.StrategySprint;

namespace AvansDevOpsApplication.Domain.SprintState.ReleaseSprintState
{
    public class ReleaseState : ISprintState
    {
        public void AddBacklogItem(BacklogItem backlogItem)
        {
            Console.WriteLine("Sprint is released");
        }

        public void RemoveBacklogItem(Guid id)
        {
            Console.WriteLine("Sprint is released");
        }
    }
}
