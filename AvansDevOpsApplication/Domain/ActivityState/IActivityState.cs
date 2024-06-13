namespace AvansDevOpsApplication.Domain.ActivityState
{
    public interface IActivityState
    {
        public void ChangeState(IActivityState state);
    }
}
