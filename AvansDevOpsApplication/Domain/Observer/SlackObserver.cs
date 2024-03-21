namespace AvansDevOpsApplication.Domain.Observer
{
    public class SlackObserver : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Slack: " + message);
        }
    }
}
