using AvansDevOpsApplication.Domain.StrategySprint;

namespace AvansDevOpsApplication.Domain.SprintState.ReviewSprintState
{
    public class ActiveReleaseState : ISprintState
    {
        private ReleaseSprint sprint;
        public ActiveReleaseState(ReleaseSprint sprint)
        {
            this.sprint = sprint;
        }

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
