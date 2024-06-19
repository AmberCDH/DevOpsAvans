using AvansDevOpsApplication.Domain;
using AvansDevOpsApplication.Domain.SprintState.ReleaseSprintState;
using AvansDevOpsApplication.Domain.SprintState.ReviewSprintState;
using AvansDevOpsApplication.Domain.StrategySprint;
using FluentAssertions;

namespace AvansDevOpsApplication.Tests.SprintTests
{
    public class ReleaseSprintStateTests
    {
        [Fact]
        public void ShouldSetReleaseStateActive()
        {
            //Arrange
            var startDate = new DateTime(2023, 12, 25);
            var endDate = DateTime.Now;
            var sprint = new ReleaseSprint("Cool sprint", startDate, endDate);

            //Act
            sprint.SetState(sprint.GetActiveState());


            //Assert
            sprint.GetActiveState().Should().BeOfType<ActiveReleaseState>();
        }
        [Fact]
        public void ShouldSetReleaseStateCreated()
        {
            //Arrange
            var startDate = new DateTime(2023, 12, 25);
            var endDate = DateTime.Now;
            var sprint = new ReleaseSprint("Cool sprint", startDate, endDate);

            //Act
            sprint.SetState(sprint.GetCreatedState());


            //Assert
            sprint.GetState().Should().BeOfType<CreatedReleaseState>();
        }
        [Fact]
        public void ShouldSetReleaseStateFinished()
        {
            //Arrange
            var startDate = new DateTime(2023, 12, 25);
            var endDate = DateTime.Now;
            var sprint = new ReleaseSprint("Cool sprint", startDate, endDate);

            //Act
            sprint.SetState(sprint.GetFinishedState());


            //Assert
            sprint.GetState().Should().BeOfType<FinishedReleaseState>();
        }

        [Fact]
        public void ShouldAddBacklogItemInReleaseActiveState()
        {
            //Arrange
            var startDate = new DateTime(2023, 12, 25);
            var endDate = DateTime.Now;
            var sprint = new ReleaseSprint("Mayonaise wiki", startDate, endDate);
            var item = new BacklogItem("Update dutch mayonaise brands", "Update dutch brand entries with more information", null, DateTime.Now);

            //Act
            sprint.SetState(sprint.GetActiveState());
            sprint.AddItemToBacklog(item);


            //Assert
            sprint.GetActiveState().Should().BeOfType<ActiveReleaseState>();
            sprint.getBacklogItems().Should().HaveCount(1);
        }

        [Fact]
        public void ShouldRemoveBacklogItemInReleaseActiveState()
        {
            //Arrange
            var startDate = new DateTime(2023, 12, 25);
            var endDate = DateTime.Now;
            var sprint = new ReleaseSprint("Mayonaise wiki", startDate, endDate);
            var item = new BacklogItem("Update dutch mayonaise brands", "Update dutch brand entries with more information", null, DateTime.Now);

            //Act
            sprint.AddItemToBacklog(item);
            sprint.SetState(sprint.GetActiveState());
            sprint.RemoveFromBacklog(item.ID);


            //Assert
            sprint.GetActiveState().Should().BeOfType<ActiveReleaseState>();
            sprint.getBacklogItems().Should().HaveCount(0);
        }
    }
}
