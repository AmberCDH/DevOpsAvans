using AvansDevOpsApplication.Domain;
using AvansDevOpsApplication.Domain.SprintState.ReleaseSprintState;
using FluentAssertions;

namespace AvansDevOpsApplication.Tests
{
    public class SprintStateTests
    {
        [Fact]
        public void ShouldSetStateActive()
        {
            //Arrange
            var startDate = new DateTime(2023, 12, 25);
            var endDate = DateTime.Now;
            var sprint = new Sprint("Cool sprint", startDate, endDate);

            //Act
            sprint.SetState(sprint.GetActiveState());


            //Assert
            sprint.State.Should().BeOfType<ActiveState>();
        }
        [Fact]
        public void ShouldSetStateCreated()
        {
            //Arrange
            var startDate = new DateTime(2023, 12, 25);
            var endDate = DateTime.Now;
            var sprint = new Sprint("Cool sprint", startDate, endDate);

            //Act
            sprint.SetState(sprint.GetCreatedState());


            //Assert
            sprint.State.Should().BeOfType<CreatedReleaseState>();
        }
        [Fact]
        public void ShouldSetStateFinished()
        {
            //Arrange
            var startDate = new DateTime(2023, 12, 25);
            var endDate = DateTime.Now;
            var sprint = new Sprint("Cool sprint", startDate, endDate);

            //Act
            sprint.SetState(sprint.GetFinishedState());


            //Assert
            sprint.State.Should().BeOfType<FinishedReviewState>();
        }
        [Fact]
        public void ShouldSetStatePipeline()
        {
            //Arrange
            var startDate = new DateTime(2023, 12, 25);
            var endDate = DateTime.Now;
            var sprint = new Sprint("Cool sprint", startDate, endDate);

            //Act
            sprint.SetState(sprint.GetPipelineState());


            //Assert
            sprint.State.Should().BeOfType<PipelineReviewState>();
        }
        [Fact]
        public void ShouldSetStateReleased()
        {
            //Arrange
            var startDate = new DateTime(2023, 12, 25);
            var endDate = DateTime.Now;
            var sprint = new Sprint("Cool sprint", startDate, endDate);

            //Act
            sprint.SetState(sprint.GetReleasedState());


            //Assert
            sprint.State.Should().BeOfType<ReviewState>();
        }
    }
}
