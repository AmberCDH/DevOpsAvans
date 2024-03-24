using AvansDevOpsApplication.Domain;

namespace AvansDevOpsApplication.Tests
{
    public class ActivityTests
    {
        [Fact]
        public void ShouldSetActivityToDone()
        {
            //Arrange
            var localDate = new DateTime(2023, 12, 25, 10, 30, 50);
            var backlogItem = new BacklogItem("Name", "Nice description", null, localDate, "Backlog");
            var activity = new Activity("help please", localDate, backlogItem, "Help");

            //Act
            activity.SetState(ActivityState.Done);

            //Assert
            Assert.Equal(ActivityState.Done, activity.ActivityState);
        }

        [Fact]
        public void ShouldNotSetActivityTodo()
        {
            //Arrange
            var localDate = new DateTime(2023, 12, 25, 10, 30, 50);
            var backlogItem = new BacklogItem("Name", "Nice description", null, localDate, "Backlog");
            var activity = new Activity("help please", localDate, backlogItem, "Help");

            //Act
            activity.SetState(ActivityState.Done);
            activity.SetState(ActivityState.Todo);

            //Assert
            Assert.NotEqual(ActivityState.Todo, activity.ActivityState);
        }
    }
}
