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
            var backlogItem = new BacklogItem("Name", "Nice description", null, localDate);
            var activity = new Activity("help please","Help");

        }

        [Fact]
        public void ShouldNotSetActivityTodo()
        {
            //Arrange
            var localDate = new DateTime(2023, 12, 25, 10, 30, 50);
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);
            var activity = new Activity("help please", "");
        }
    }
}
