using AvansDevOpsApplication.Domain;
using AvansDevOpsApplication.Domain.Factory;
using AvansDevOpsApplication.Domain.FactoryReport;
using FluentAssertions;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApplication.Tests
{
    public class ExportTests
    {
        [Fact]
        public void ShouldGeneratePdf()
        {
            //Arrange
            QuestPDF.Settings.License = LicenseType.Community;
            var header = "Report";
            List<User> users = [];
            var footer = "End of report";
            var exportPdf = new PdfReportCreator();

            //Act
            exportPdf.exportReport(header, footer, users);
        }

        [Fact]
        public void ShouldGeneratePng()
        {
            //Arrange
            var header = "Report";
            List<User> users = [];
            var footer = "End of report";
            var exportPng = new PngReportCreator();

            //Act
            exportPng.exportReport(header, footer, users);
        }

        [Fact]
        public void ShouldCreatePdfExportClass()
        {
            //Arrange
            var report = new Report();

            //Act
            var export = report.createExport("pdf");

            //Assert
            export.Should().BeOfType<PdfReportCreator>();
        }

        [Fact]
        public void ShouldCreatePngExportClass()
        {
            //Arrange
            var report = new Report();

            //Act
            var export = report.createExport("png");

            //Assert
            export.Should().BeOfType<PngReportCreator>();
        }

        [Fact]
        public void ShouldCreatePdfExportDefaultClass()
        {
            //Arrange
            var report = new Report();

            //Act
            var export = report.createExport("");

            //Assert
            export.Should().BeOfType<PdfReportCreator>();
        }
    }
}
