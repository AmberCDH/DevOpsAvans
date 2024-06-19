using AvansDevOpsApplication.Domain;
using AvansDevOpsApplication.Domain.SprintState.ReleaseSprintState;
using AvansDevOpsApplication.Domain.SprintState.ReviewSprintState;
using AvansDevOpsApplication.Domain.StrategySprint;
using FluentAssertions;

namespace AvansDevOpsApplication.Tests.SprintTests
{
    public class ReviewSprintTests
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
            sprint.GetState().Should().BeOfType<CreatedReviewState>();
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
            sprint.GetState().Should().BeOfType<FinishedReviewState>();
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
            sprint.GetState().Should().BeOfType<PipelineReviewState>();
        }

        [Fact]
        public void ShouldAddBacklogItemInActiveState()
        {
            //Arrange
            var startDate = new DateTime(2023, 12, 25);
            var endDate = DateTime.Now;
            var sprint = new ReviewSprint("Mayonaise wiki", startDate, endDate);
            var item = new BacklogItem("Update dutch mayonaise brands", "Update dutch brand entries with more information", null, DateTime.Now);

            //Act
            sprint.SetState(sprint.GetActiveState());
            sprint.AddItemToBacklog(item);


            //Assert
            sprint.GetActiveState().Should().BeOfType<ActiveReviewState>();
            sprint.getBacklogItems().Should().HaveCount(1);
        }

        [Fact]
        public void ShouldRemoveBacklogItemInActiveState()
        {
            //Arrange
            var startDate = new DateTime(2023, 12, 25);
            var endDate = DateTime.Now;
            var sprint = new ReviewSprint("Mayonaise wiki", startDate, endDate);
            var item = new BacklogItem("Update dutch mayonaise brands", "Update dutch brand entries with more information", null, DateTime.Now);

            //Act
            sprint.AddItemToBacklog(item);
            sprint.SetState(sprint.GetActiveState());
            sprint.RemoveFromBacklog(item.ID);


            //Assert
            sprint.GetActiveState().Should().BeOfType<ActiveReviewState>();
            sprint.getBacklogItems().Should().HaveCount(0);
        }


        [Fact]
        public void ShouldNotRemoveItemInReviewCancelState()
        {
            //Arrange
            var startDate = new DateTime(2023, 12, 25);
            var endDate = DateTime.Now;
            var sprint = new ReviewSprint("Mayonaise wiki", startDate, endDate);
            var item = new BacklogItem("Update dutch mayonaise brands", "Update dutch brand entries with more information", null, DateTime.Now);

            //Act
            sprint.AddItemToBacklog(item);
            sprint.SetState(sprint.GetCancelState());
            sprint.RemoveFromBacklog(item.ID);


            //Assert
            sprint.GetState().Should().BeOfType<CancelReviewState>();
            sprint.getBacklogItems().Should().HaveCount(1);
        }

        [Fact]
        public void ShouldNotAddItemInReviewCancelState()
        {
            //Arrange
            var startDate = new DateTime(2023, 12, 25);
            var endDate = DateTime.Now;
            var sprint = new ReviewSprint("Mayonaise wiki", startDate, endDate);
            var item = new BacklogItem("Update dutch mayonaise brands", "Update dutch brand entries with more information", null, DateTime.Now);

            //Act
            sprint.SetState(sprint.GetCancelState());
            sprint.AddItemToBacklog(item);


            //Assert
            sprint.GetState().Should().BeOfType<CancelReviewState>();
            sprint.getBacklogItems().Should().HaveCount(0);
        }

        [Fact]
        public void ShouldNotRemoveItemInReviewFinishedState()
        {
            //Arrange
            var startDate = new DateTime(2023, 12, 25);
            var endDate = DateTime.Now;
            var sprint = new ReviewSprint("Mayonaise wiki", startDate, endDate);
            var item = new BacklogItem("Update dutch mayonaise brands", "Update dutch brand entries with more information", null, DateTime.Now);

            //Act
            sprint.AddItemToBacklog(item);
            sprint.SetState(sprint.GetFinishedState());
            sprint.RemoveFromBacklog(item.ID);


            //Assert
            sprint.GetState().Should().BeOfType<FinishedReviewState>();
            sprint.getBacklogItems().Should().HaveCount(1);
        }

        [Fact]
        public void ShouldNotAddItemInReviewFinishedState()
        {
            //Arrange
            var startDate = new DateTime(2023, 12, 25);
            var endDate = DateTime.Now;
            var sprint = new ReviewSprint("Mayonaise wiki", startDate, endDate);
            var item = new BacklogItem("Update dutch mayonaise brands", "Update dutch brand entries with more information", null, DateTime.Now);

            //Act
            sprint.SetState(sprint.GetFinishedState());
            sprint.AddItemToBacklog(item);


            //Assert
            sprint.GetState().Should().BeOfType<FinishedReviewState>();
            sprint.getBacklogItems().Should().HaveCount(0);
        }
    }
}
