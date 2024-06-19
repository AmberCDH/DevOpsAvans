using AvansDevOpsApplication.Domain;
using FluentAssertions;

namespace AvansDevOpsApplication.Tests
{
    public class ProjectBacklogTests
    {
        [Fact]
        public void ShouldAddBacklogItem()
        {
            //Arrange
            var localDate = new DateTime(2023, 12, 25, 10, 30, 50);
            var backlog = new ProjectBacklog(Guid.NewGuid());
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);

            //Act
            backlog.AddItemToBacklog(backlogItem);

            //Assert
            backlog.getBacklogItems().Should().HaveCount(1);
        }

        [Fact]
        public void ShouldRemoveBacklogItem()
        {
            //Arrange
            var localDate = new DateTime(2023, 12, 25, 10, 30, 50);
            var backlog = new ProjectBacklog(Guid.NewGuid());
            var backlogItem = new BacklogItem("Name", "Backlog for the turtle shop project", null, DateTime.Now);

            //Act
            backlog.AddItemToBacklog(backlogItem);
            backlog.RemoveFromBacklog(backlogItem.Id);

            //Assert
            backlog.getBacklogItems().Should().HaveCount(0);
        }
    }
}
