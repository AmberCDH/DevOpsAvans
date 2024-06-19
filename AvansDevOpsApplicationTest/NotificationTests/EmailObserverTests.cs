using AvansDevOpsApplication.Domain;
using AvansDevOpsApplication.Domain.NotificationObserver;
using FluentAssertions;
using Xunit.Abstractions;

namespace AvansDevOpsApplication.Tests.NotificationTests
{
    public class EmailObserverTests
    {
        private readonly ITestOutputHelper output;

        public EmailObserverTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void ShouldSendEmailUpdate()
        {
            //Arrange
            var emailObserver = new EmailObserver();
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            emailObserver.Update("Hello universe");

            //Assert
            writer.ToString().Should().Contain("Hello universe");
        }

        [Fact]
        public void ShouldSendSlackUpdate()
        {
            //Arrange
            var slackObserver = new SlackObserver();
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            slackObserver.Update("Hello universe");

            //Assert
            writer.ToString().Should().Contain("Hello universe");
        }

        [Fact]
        public void TestBacklogItemStateChangeNotifiesEmailObservers()
        {
            // Arrange
            var backlogItem = new BacklogItem("Add foxes", "Description of Task 1", null, DateTime.Now);
            var emailUser = new User("John", "john@example.com", new DateTime(1992, 1, 1), RoleType.DEVELOPER, new EmailObserver());
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            backlogItem.AssignUser(emailUser);
            backlogItem.ChangeState(backlogItem.GetDoingState());

            //Assert
            writer.ToString().Should().Contain("Email: Add foxes changed state");
        }

        [Fact]
        public void TestBacklogItemStateChangeNotifiesSlackObservers()
        {
            // Arrange
            var backlogItem = new BacklogItem("Add foxes", "Description of Task 1", null, DateTime.Now);
            var slackUser = new User("John", "john@example.com", new DateTime(1992, 1, 1), RoleType.DEVELOPER, new SlackObserver());
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            backlogItem.AssignUser(slackUser);
            backlogItem.ChangeState(backlogItem.GetDoingState());

            //Assert
            writer.ToString().Should().Contain("Slack: Add foxes changed state");

        }
    }
}
