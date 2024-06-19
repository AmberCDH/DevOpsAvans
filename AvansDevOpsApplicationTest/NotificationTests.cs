using AvansDevOpsApplication.Domain;
using AvansDevOpsApplication.Domain.NotificationObserver;

namespace AvansDevOpsApplication.Tests
{
    public class NotificationTests
    {
        [Fact]
        public void TestBacklogItemStateChangeNotifiesEmailObservers()
        {
            // Arrange
            var backlogItem = new BacklogItem("Task 1", "Description of Task 1", null, DateTime.Now);
            var emailUser = new User("John", "john@example.com", 30, new DateTime(1992, 1, 1), RoleType.DEVELOPER, new EmailObserver());
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);
        }

        [Fact]
        public void TestBacklogItemStateChangeNotifiesSlackObservers()
        {
            // Arrange
            var backlogItem = new BacklogItem("Task 1", "Description of Task 1", null, DateTime.Now);
            var slackUser = new User("John", "john@example.com", 30, new DateTime(1992, 1, 1), RoleType.DEVELOPER, new SlackObserver());
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);
        }
    }
}
