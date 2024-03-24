using AvansDevOpsApplication.Domain;
using AvansDevOpsApplication.Domain.Adapter;

namespace AvansDevOpsApplication.Tests
{
    public class NotificationTests
    {
        [Fact]
        public void TestBacklogItemStateChangeNotifiesEmailObservers()
        {
            // Arrange
            var backlogItem = new BacklogItem("Task 1", "Description of Task 1", null, DateTime.Now, "Backlog");
            var emailUser = new User("John", "john@example.com", 30, new DateTime(1992, 1, 1), RoleType.DEVELOPER, new EmailObserver());
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            backlogItem.AssignUser(emailUser);
            backlogItem.SetState(ItemState.Doing);

            // Assert
            Assert.Equal("Email: Item in progress\r\n", writer.ToString());
        }

        [Fact]
        public void TestBacklogItemStateChangeNotifiesSlackObservers()
        {
            // Arrange
            var backlogItem = new BacklogItem("Task 1", "Description of Task 1", null, DateTime.Now, "Backlog");
            var slackUser = new User("John", "john@example.com", 30, new DateTime(1992, 1, 1), RoleType.DEVELOPER, new SlackObserver());
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            backlogItem.AssignUser(slackUser);
            backlogItem.SetState(ItemState.Doing);

            // Assert
            Assert.Equal("Slack: Item in progress\r\n", writer.ToString());
        }
    }
}
