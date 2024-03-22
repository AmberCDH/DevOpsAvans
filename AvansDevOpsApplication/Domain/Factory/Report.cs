namespace AvansDevOpsApplication.Domain.Factory
{
    public class Report
    {
        public Export createExport(string format)
        {
            switch (format)
            {
                case "pdf":
                    {
                        return new ExportPdf();
                    }
                case "png":
                    {
                        return new ExportPng();
                    }
                default:
                    {
                        return new ExportPdf();
                    }
            }
        }
    }
}
