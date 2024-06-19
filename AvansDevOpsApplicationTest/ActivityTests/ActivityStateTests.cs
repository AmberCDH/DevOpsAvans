using AvansDevOpsApplication.Domain.SprintState.ReleaseSprintState;
using AvansDevOpsApplication.Domain.StrategySprint;
using AvansDevOpsApplication.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvansDevOpsApplication.Domain.ActivityState;
using FluentAssertions;

namespace AvansDevOpsApplication.Tests.ActivityTests
{
    public class ActivityStateTests
    {
        [Fact]
        public void ShouldNotChangeStateWhenInDoneState()
        {
            //Arrange
            var activity = new Activity("Change div on the bottom of the page", "change div location");

            //Act
            activity.SetState(new DoneActivityState());
            activity.ChangeState(new ToDoActivityState(activity));


            //Assert
            activity.getState().Should().BeOfType<DoneActivityState>();
        }

        [Fact]
        public void ShouldSetActivityToDone()
        {
            //Arrange
            var localDate = new DateTime(2023, 12, 25, 10, 30, 50);
            var backlogItem = new BacklogItem("Name", "Nice description", null, localDate);
            var activity = new Activity("help please", "Help");

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
