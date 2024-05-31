using AvansDevOpsApplication.Domain.State;

namespace AvansDevOpsApplication.Domain.StrategySprint
{
    public interface IReleaseSprint
    {
        void AddBacklogItem(BacklogItem backlogItem);
        bool Equals(object? obj);
        ISprintState GetActiveState();
        ISprintState GetCreatedState();
        int GetHashCode();
        void RemoveBacklogItem(Guid id);
        void SetState(ISprintState state);
        string? ToString();
    }
}