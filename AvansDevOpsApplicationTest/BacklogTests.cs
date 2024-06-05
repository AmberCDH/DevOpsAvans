using AvansDevOpsApplication.Domain;
using FluentAssertions;

namespace AvansDevOpsApplication.Tests
{
    public class BacklogTests
    {
        [Fact]
        public void ShouldAddBacklogItem()
        {
            //Arrange
            var localDate = new DateTime(2023, 12, 25, 10, 30, 50);
            var backlog = new BacklogInterface("Alot of items", "Please send help");
            var backlogItem = new BacklogItem("Name", "Nice description", null, localDate, "Backlog");

            //Act
            backlog.AddBacklogItem(backlogItem);

            //Assert
            backlog.BacklogItems.Should().HaveCount(1);
        }

        [Fact]
        public void ShouldRemoveBacklogItem()
        {
            //Arrange
            var localDate = new DateTime(2023, 12, 25, 10, 30, 50);
            var backlog = new BacklogInterface("Alot of items", "Please send help");
            var backlogItem = new BacklogItem("Name", "Nice description", null, localDate, "Backlog");

            //Act
            backlog.AddBacklogItem(backlogItem);
            backlog.RemoveBacklogItem(backlogItem.Id);

            //Assert
            backlog.BacklogItems.Should().HaveCount(0);
        }

        [Fact]
        public void ShouldAddSprint()
        {
            //Arrange
            var backlog = new BacklogInterface("Alot of items", "Please send help");
            var sprint = new Sprint("First 2 weeks!", DateTime.Now, DateTime.Now.AddDays(14));
            //Act
            backlog.AddSprint(sprint);

            //Assert
            backlog.Sprints.Should().HaveCount(1);
            backlog.Sprints.Should().Contain(sprint);
        }

        [Fact]
        public void ShouldRemoveSprint()
        {
            //Arrange
            var backlog = new BacklogInterface("Alot of items", "Please send help");
            var sprint = new Sprint("First 2 weeks!", DateTime.Now, DateTime.Now.AddDays(14));
            //Act
            backlog.AddSprint(sprint);
            backlog.RemoveSprint(sprint.Id);

            //Assert
            backlog.Sprints.Should().HaveCount(0);
            backlog.Sprints.Should().NotContain(sprint);
        }
    }
}
