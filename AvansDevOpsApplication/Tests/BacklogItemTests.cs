using AvansDevOpsApplication.Domain;
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
            var activity = new Activity("help", "done", "not done", localDate);
            var backlogItem = new BacklogItem("Name", "Nice description", null, localDate, "Backlog");

            //Act
            var before = backlogItem.toString();
            backlogItem.AddActivityToList(activity);
            var after = backlogItem.toString();

            //Assert
            Assert.NotEqual(before, after);
        }
    }
}
