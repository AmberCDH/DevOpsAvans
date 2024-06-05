using AvansDevOpsApplication.Domain.State;

namespace AvansDevOpsApplication.Domain.StrategySprint
{
    class ReleaseSprint : Sprint
    {
        public ReleaseSprint(string name, DateTime startTime, DateTime endTime) : base(name, startTime, endTime)
        {
        }
    }
}
