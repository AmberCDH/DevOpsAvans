using AvansDevOpsApplication.Domain.ReportTemplate;
using AvansDevOpsApplication.Domain;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvansDevOpsApplication.Domain.StrategySprint;

namespace AvansDevOpsApplication.Tests
{
    public class BacklogItemManagerTests
    {

        [Fact]
        public void ShouldMoveBacklogItem()
        {
            //Arrange
            BacklogItemManager manager = new BacklogItemManager();
            var item = new BacklogItem("Add exhaust", "Add exhaust to car", null, DateTime.Now);
            var penguinBacklog = new ProjectBacklog(Guid.NewGuid());
            var carBacklog = new ProjectBacklog(Guid.NewGuid());
            penguinBacklog.AddItemToBacklog(item);

            //Act
            manager.MoveBacklogItem(penguinBacklog, carBacklog, item);

            //Assert
            carBacklog.getBacklogItems().Should().Contain(item);
        }
    }
}
