using AvansDevOpsApplication.Domain;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApplication.Tests
{
    public class ProjectTests
    {
        [Fact]
        public void ShouldCreateProject()
        {
            //Arrange
            var project = new Project("Penguin protection forum project");

            //Assert
           project.GetProjectBacklog().getBacklogItems().Should().HaveCount(0);
        }
    }
}
