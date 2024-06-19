using AvansDevOpsApplication.Domain;
using AvansDevOpsApplication.Domain.NotificationObserver;
using FluentAssertions;

namespace AvansDevOpsApplication.Tests
{
    public class BacklogItemTests
    {
        [Fact]
        public void ShouldAddActivityToList()
        {
            //Arrange
            var backlogItem = new BacklogItem("Turtle shop", "Backlog for the turtle shop project", null, DateTime.Now);
            var activity = new Activity("Clean up unused imports in web project","unused imports");

            //Act
            var before = backlogItem.toString();
            backlogItem.AddActivityToList(activity);
            var after = backlogItem.toString();

            //Assert
            Assert.NotEqual(before, after);
        }

        [Fact]
        public void ShouldNotSetDoing()
        {
            //Arrange
            var localDate = new DateTime(2023, 12, 25, 10, 30, 50);
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);
            var activity = new Activity("help please", "Help");
        }

        [Fact]
        public void ShouldSetDoing()
        {
            //Arrange
            var localDate = new DateTime(2023, 12, 25, 10, 30, 50);
            var notificationService = new EmailObserver();
            var user = new User("Tristan", "Tristan@mail.com", 60, localDate, RoleType.DEVELOPER, notificationService);
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);
            var activity = new Activity("help please", "");
        }

        [Fact]
        public void ShouldRemoveUser()
        {
            //Arrange
            var localDate = new DateTime(2023, 12, 25, 10, 30, 50);
            var notificationService = new EmailObserver();
            var user = new User("Tristan", "Tristan@mail.com", 60, localDate, RoleType.DEVELOPER, notificationService);
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);

            //Act
            backlogItem.AssigedUsers.Add(user);
            backlogItem.RemoveUser(user);

            //Assert
            backlogItem.AssigedUsers.Should().HaveCount(0);
        }

        [Fact]
        public void ShouldSetTesting()
        {
            //Arrange
            var localDate = new DateTime(2023, 12, 25, 10, 30, 50);
            var notificationService = new EmailObserver();
            var user = new User("Tristan", "Tristan@mail.com", 60, localDate, RoleType.DEVELOPER, notificationService);
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);
            var activity = new Activity("help please", "");
        }

        [Fact]
        public void ShouldSetDone()
        {
            //Arrange
            var localDate = new DateTime(2023, 12, 25, 10, 30, 50);
            var notificationService = new EmailObserver();
            var user = new User("Tristan", "Tristan@mail.com", 60, localDate, RoleType.DEVELOPER, notificationService);
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);
            var activity = new Activity("help please", "");
        }

        [Fact]
        public void ShouldNotSetDone()
        {
            //Arrange
            var localDate = new DateTime(2023, 12, 25, 10, 30, 50);
            var notificationService = new EmailObserver();
            var user = new User("Tristan", "Tristan@mail.com", 60, localDate, RoleType.DEVELOPER, notificationService);
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);
            var activity = new Activity("help please", "");
        }
    }
}
