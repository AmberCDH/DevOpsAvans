namespace AvansDevOpsApplication.Domain.NotificationObserver
{
    public class SlackObserver : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Slack: " + message);
        }
    }
}
