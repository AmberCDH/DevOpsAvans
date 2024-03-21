using AvansDevOpsApplication.Domain;
using AvansDevOpsApplication.Domain.Observer;
using Xunit;

namespace AvansDevOpsApplication.Tests
{
    public class BacklogItemTests
    {
        //We moeten gebruik maken van mocking..
        [Fact]
        public void ShouldAddActivityToList()
        {
            //Arrange
            var localDate = new DateTime(2023, 12, 25, 10, 30, 50);
            var backlogItem = new BacklogItem("Name", "Nice description", null, localDate, "Backlog");
            var activity = new Activity("help please", "done", "not done", localDate, backlogItem, "Help");

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
            var backlogItem = new BacklogItem("Name", "Nice description", null, localDate, "Backlog");            
            var activity = new Activity("help please", "done", "not done", localDate, backlogItem, "Help");

            //Act
            backlogItem.SetState(ItemState.Doing);

            //Assert
            Assert.Equal(ItemState.Todo, backlogItem.ItemState);
        }

        [Fact]
        public void ShouldSetDoing()
        {
            //Arrange
            var localDate = new DateTime(2023, 12, 25, 10, 30, 50);
            var notificationService = new EmailObserver();
            var user = new User("Tristan", "Tristan@mail.com", 60, localDate, RoleType.DEVELOPER, notificationService);
            var backlogItem = new BacklogItem("Name", "Nice description", null, localDate, "Backlog");
            var activity = new Activity("help please", "done", "not done", localDate, backlogItem, "Help");

            //Act
            backlogItem.AssignUser(user);
            backlogItem.SetState(ItemState.Doing);

            //Assert
            Assert.Equal(ItemState.Doing, backlogItem.ItemState);
        }


    }
}
