using AvansDevOpsApplication.Domain.Observer;

namespace AvansDevOpsApplication.Domain.Adapter
{
    public class SlackObserver : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Slack: " + message);
        }
    }
}
