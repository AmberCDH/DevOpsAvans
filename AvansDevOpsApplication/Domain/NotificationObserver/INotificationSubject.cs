namespace AvansDevOpsApplication.Domain.NotificationObserver
{
    public interface INotificationSubject
    {
        void NotifyObserver(string message);
    }
}
