using AvansDevOpsApplication.Domain.NotificationObserver;
using AvansDevOpsApplication.Domain;
using AvansDevOpsApplication.Domain.ReportTemplate;
using FluentAssertions;

namespace AvansDevOpsApplication.Tests.ReportTests
{
    public class ReportTemplateTests
    {
        [Fact]
        public void ShouldGenerateYearlyReport()
        {
            //Arrange

            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            Project project = new Project("Bende van ellende");
            var backlog = project.GetProjectBacklog();
   
            var item = new BacklogItem("Pray", "Praying for a good grade", null, DateTime.Now);
            var item2 = new BacklogItem("Test", "Test", null, DateTime.Now);

            backlog.AddItemToBacklog(item);
            backlog.AddItemToBacklog(item2);

            var reportTemplate = new YearReport(project.GetProjectBacklog());

            //Act
            reportTemplate.GenerateReport();

            //Assert
            writer.ToString().Should().Contain("Yearly backlog report");
        }

        [Fact]
        public void ShouldGenerateWeeklyReport()
        {
            //Arrange
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            Project project = new Project("Bende van ellende");
            var backlog = project.GetProjectBacklog();

            var item = new BacklogItem("Pray", "Praying for a good grade", null, DateTime.Now);
            var item2 = new BacklogItem("Test", "Test", null, DateTime.Now);

            backlog.AddItemToBacklog(item);
            backlog.AddItemToBacklog(item2);

            var reportTemplate = new WeekReport(project.GetProjectBacklog());

            //Act
            reportTemplate.GenerateReport();

            //Assert
            writer.ToString().Should().Contain("Weekly backlog report");
        }
    }
}
