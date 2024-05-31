namespace AvansDevOpsApplication.Domain.NotificationObserver
{
    public class EmailObserver : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Email: " + message);
        }
    }
}
