using AvansDevOpsApplication.Domain.StrategySprint;

namespace AvansDevOpsApplication.Domain.SprintState.ReleaseSprintState
{
    public class CancelReleaseState : ISprintState
    {
        public void AddBacklogItem(BacklogItem backlogItem)
        {
            Console.WriteLine("Sprint release is canceled");
        }

        public void RemoveBacklogItem(Guid id)
        {
            Console.WriteLine("Sprint release is canceled");
        }
    }
}
