using AvansDevOpsApplication.Domain;
using AvansDevOpsApplication.Domain.NotificationObserver;
using FluentAssertions;

namespace AvansDevOpsApplication.Tests
{
    public class BacklogItemTests
    {
        [Fact]
        public void ShouldCreateBacklogItem()
        {
            //Arrange
            var backlogItem = new BacklogItem("Turtle shop", "Backlog for the turtle shop project", null, DateTime.Now);

            //Assert
            backlogItem.GetState().Should().NotBeNull();
        }

        [Fact]
        public void ShouldAssignUserToBacklogItem()
        {
            //Arrange
            var backlogItem = new BacklogItem("Turtle shop", "Backlog for the turtle shop project", null, DateTime.Now);
            var user = new User("Max", "max@mail.com", DateTime.Now, RoleType.DEVELOPER, new EmailObserver());

            //Act
            backlogItem.AssignUser(user);

            //Assert
            backlogItem.GetState().Should().NotBeNull();
            backlogItem.AssigedUsers.Should().HaveCount(1);
        }

        [Fact]
        public void ShouldAddActivityToList()
        {
            //Arrange
            var backlogItem = new BacklogItem("Turtle shop", "Backlog for the turtle shop project", null, DateTime.Now);
            var activity = new Activity("Clean up unused imports in web project", "unused imports");

            //Act
            backlogItem.AddActivityToList(activity);

            //Assert
            backlogItem.Activitys.Should().HaveCount(1);  
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
            var user = new User("Tristan", "Tristan@mail.com", localDate, RoleType.DEVELOPER, notificationService);
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);
            var activity = new Activity("help please", "");
        }

        [Fact]
        public void ShouldRemoveUser()
        {
            //Arrange
            var localDate = new DateTime(2023, 12, 25, 10, 30, 50);
            var notificationService = new EmailObserver();
            var user = new User("Tristan", "Tristan@mail.com", localDate, RoleType.DEVELOPER, notificationService);
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
            var user = new User("Tristan", "Tristan@mail.com", localDate, RoleType.DEVELOPER, notificationService);
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);
            var activity = new Activity("help please", "");
        }

        [Fact]
        public void ShouldSetDone()
        {
            //Arrange
            var localDate = new DateTime(2023, 12, 25, 10, 30, 50);
            var notificationService = new EmailObserver();
            var user = new User("Tristan", "Tristan@mail.com", localDate, RoleType.DEVELOPER, notificationService);
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);
            var activity = new Activity("help please", "");
        }

        [Fact]
        public void ShouldNotSetDone()
        {
            //Arrange
            var localDate = new DateTime(2023, 12, 25, 10, 30, 50);
            var notificationService = new EmailObserver();
            var user = new User("Tristan", "Tristan@mail.com", localDate, RoleType.DEVELOPER, notificationService);
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);
            var activity = new Activity("help please", "");
        }
    }
}
