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
        public void ShouldNotAssignUserInDoneState()
        {
            //Arrange
            var backlogItem = new BacklogItem("Turtle shop", "Backlog for the turtle shop project", null, DateTime.Now);
            var user = new User("Tristan", "Tristan@mail.com", DateTime.Now, RoleType.DEVELOPER, new EmailObserver());

            //Act
            backlogItem.SetState(backlogItem.GetDoneState());
            backlogItem.AssignUser(user);

            //Assert
            backlogItem.AssigedUsers.Should().HaveCount(0);
        }

        [Fact]
        public void ShouldNotRemoveUserInDoneState()
        {
            //Arrange
            var backlogItem = new BacklogItem("Turtle shop", "Backlog for the turtle shop project", null, DateTime.Now);
            var user = new User("Tristan", "Tristan@mail.com", DateTime.Now, RoleType.DEVELOPER, new EmailObserver());

            //Act
            backlogItem.AssignUser(user);
            backlogItem.SetState(backlogItem.GetDoneState());
            backlogItem.RemoveUser(user);

            //Assert
            backlogItem.AssigedUsers.Should().HaveCount(1);
        }


        [Fact]
        public void ShouldNotChangeStateInDoneState()
        {
            //Arrange
            var backlogItem = new BacklogItem("Turtle shop", "Backlog for the turtle shop project", null, DateTime.Now);

            //Act
            backlogItem.SetState(backlogItem.GetDoneState());
            backlogItem.ChangeState(backlogItem.GetTodoState());

            //Assert
            backlogItem.GetState().Should().Be(backlogItem.GetDoneState());
        }

        [Fact]
        public void ShouldNotSetDoing()
        {
            //Arrange
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);

            //act
            backlogItem.ChangeState(backlogItem.GetDoingState());
            //assert
            backlogItem.GetState().Should().NotBe(backlogItem.GetDoingState());
        }

        [Fact]
        public void ShouldSetDoing()
        {
            //Arrange
            var localDate = new DateTime(2023, 12, 25, 10, 30, 50);
            var notificationService = new EmailObserver();
            var user = new User("Tristan", "Tristan@mail.com", localDate, RoleType.DEVELOPER, notificationService);
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);

            //act
            backlogItem.AssignUser(user);
            backlogItem.ChangeState(backlogItem.GetDoingState());
            //assert
            backlogItem.GetState().Should().Be(backlogItem.GetDoingState());
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
            var tester = new User("Tristan", "Tristan@mail.com", localDate, RoleType.TESTER, notificationService);
            var developer = new User("Tristan", "Tristan@mail.com", localDate, RoleType.DEVELOPER, notificationService);
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);

            //Act
            backlogItem.AssignUser(developer);
            backlogItem.ChangeState(backlogItem.GetDoingState());
            backlogItem.ChangeState(backlogItem.GetReadyForTestingState());
            backlogItem.AssignUser(tester);
            backlogItem.ChangeState(backlogItem.GetTestingState());

            //Assert
            backlogItem.GetState().Should().Be(backlogItem.GetTestingState());
        }

        [Fact]
        public void ShouldSetDone()
        {
            //Arrange
            var localDate = new DateTime(2023, 12, 25, 10, 30, 50);
            var notificationService = new EmailObserver();
            var tester = new User("Tristan", "Tristan@mail.com", localDate, RoleType.TESTER, notificationService);
            var developer = new User("Tristan", "Tristan@mail.com", localDate, RoleType.DEVELOPER, notificationService);
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);

            //Act
            backlogItem.AssignUser(developer);
            backlogItem.ChangeState(backlogItem.GetDoingState());
            backlogItem.ChangeState(backlogItem.GetReadyForTestingState());
            backlogItem.AssignUser(tester);
            backlogItem.ChangeState(backlogItem.GetTestingState());
            backlogItem.ChangeState(backlogItem.GetDoneState());

            //Assert
            backlogItem.GetState().Should().Be(backlogItem.GetDoneState());
        }

        [Fact]
        public void ShouldNotSetDone()
        {
            //Arrange
            var localDate = new DateTime(2023, 12, 25, 10, 30, 50);
            var notificationService = new EmailObserver();
            var tester = new User("Tristan", "Tristan@mail.com", localDate, RoleType.TESTER, notificationService);
            var developer = new User("Tristan", "Tristan@mail.com", localDate, RoleType.DEVELOPER, notificationService);
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);

            //Act
            backlogItem.ChangeState(backlogItem.GetDoneState());

            //Assert
            backlogItem.GetState().Should().NotBe(backlogItem.GetDoneState());
        }

        [Fact]
        public void ShouldAssignUserInReadyForTestingStateIfRoleIsTester()
        {
            //Arrange
            var notificationService = new EmailObserver();
            var user = new User("Tristan", "Tristan@mail.com", DateTime.Now, RoleType.TESTER, notificationService);
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);

            //Act
            backlogItem.SetState(backlogItem.GetReadyForTestingState());
            backlogItem.AssignUser(user);

            //Assert
            backlogItem.AssigedUsers.Should().Contain(user);
        }

        [Fact]
        public void ShouldNotAssignUserInReadyForTestingStateIfRoleIsNotTester()
        {
            //Arrange
            var notificationService = new EmailObserver();
            var user = new User("Tristan", "Tristan@mail.com", DateTime.Now, RoleType.DEVELOPER, notificationService);
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);

            //Act
            backlogItem.SetState(backlogItem.GetReadyForTestingState());
            backlogItem.AssignUser(user);

            //Assert
            backlogItem.AssigedUsers.Should().NotContain(user);
        }

        [Fact]
        public void ShouldChangeStateToTestingIfAssignedTester()
        {
            //Arrange
            var notificationService = new EmailObserver();
            var user = new User("Tristan", "Tristan@mail.com", DateTime.Now, RoleType.TESTER, notificationService);
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);

            //Act
            backlogItem.SetState(backlogItem.GetReadyForTestingState());
            backlogItem.AssignUser(user);
            backlogItem.ChangeState(backlogItem.GetTestingState());

            //Assert
            backlogItem.GetState().Should().Be(backlogItem.GetTestingState());
        }

        [Fact]
        public void ShouldNotChangeStateToTestingIfNoAssignedTester()
        {
            //Arrange
            var notificationService = new EmailObserver();
            var user = new User("Tristan", "Tristan@mail.com", DateTime.Now, RoleType.DEVELOPER, notificationService);
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);

            //Act
            backlogItem.SetState(backlogItem.GetReadyForTestingState());
            backlogItem.AssignUser(user);
            backlogItem.ChangeState(backlogItem.GetTestingState());

            //Assert
            backlogItem.GetState().Should().Be(backlogItem.GetReadyForTestingState());
        }
    }
}
