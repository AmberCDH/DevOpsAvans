using AvansDevOpsApplication.Domain;
using AvansDevOpsApplication.Domain.SprintState.ReleaseSprintState;
using AvansDevOpsApplication.Domain.SprintState.ReviewSprintState;
using AvansDevOpsApplication.Domain.StrategySprint;
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
            var sprint = new ReviewSprint("Cool sprint", startDate, endDate);

            //Act
            sprint.SetState(sprint.GetActiveState());


            //Assert
            sprint.GetActiveState().Should().BeOfType<ActiveReviewState>();
        }
        [Fact]
        public void ShouldSetStateCreated()
        {
            //Arrange
            var startDate = new DateTime(2023, 12, 25);
            var endDate = DateTime.Now;
            var sprint = new ReviewSprint("Cool sprint", startDate, endDate);

            //Act
            sprint.SetState(sprint.GetCreatedState());


            //Assert
            sprint.GetActiveState().Should().BeOfType<CreatedReviewState>();
        }
        [Fact]
        public void ShouldSetStateFinished()
        {
            //Arrange
            var startDate = new DateTime(2023, 12, 25);
            var endDate = DateTime.Now;
            var sprint = new ReviewSprint("Cool sprint", startDate, endDate);

            //Act
            sprint.SetState(sprint.GetFinishedState());


            //Assert
            sprint.GetActiveState().Should().BeOfType<FinishedReviewState>();
        }
        [Fact]
        public void ShouldSetStatePipeline()
        {
            //Arrange
            var startDate = new DateTime(2023, 12, 25);
            var endDate = DateTime.Now;
            var sprint = new ReviewSprint("Cool sprint", startDate, endDate);

            //Act
            sprint.SetState(sprint.GetPipelineState());


            //Assert
            sprint.GetActiveState().Should().BeOfType<PipelineReviewState>();
        }
    }
}
