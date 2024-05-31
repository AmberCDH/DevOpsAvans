using AvansDevOpsApplication.Domain.FactoryReport;

namespace AvansDevOpsApplication.Domain.Factory
{
    public class Report
    {
        public IReportCreator createExport(string format)
        {
            switch (format)
            {
                case "pdf":
                    {
                        return new PdfReportCreator();
                    }
                case "png":
                    {
                        return new PngReportCreator();
                    }
                default:
                    {
                        return new PdfReportCreator();
                    }
            }
        }
    }
}
