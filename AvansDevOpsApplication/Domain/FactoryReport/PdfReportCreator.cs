using AvansDevOpsApplication.Domain.Factory;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Previewer;

namespace AvansDevOpsApplication.Domain.FactoryReport
{
    public class PdfReportCreator : IReportCreator
    {
        public void exportReport(string header, string footer, List<User> teamInSprint)
        {
            Console.WriteLine("Pdf");
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Header().Height(100).Background(Colors.Grey.Lighten1).AlignCenter().Text(text =>
                    {
                        text.DefaultTextStyle(x => x.FontSize(20));
                        text.Span($"{header}");
                        text.Element()
                        .PaddingBottom(-6)
                        .Height(24)
                        .Width(48)
                        .Image(Placeholders.Image);
                    });
                    page.Content().Background(Colors.Grey.Lighten3).Text(text =>
                    {
                        foreach (User user in teamInSprint)
                        {
                            text.Span($"{user.Name} | {user.Role} \n");
                        }

                        text.DefaultTextStyle(x => x.FontSize(20));
                    });
                    page.Footer().Height(50).Background(Colors.Grey.Lighten1).AlignCenter().Text(text =>
                    {
                        text.DefaultTextStyle(x => x.FontSize(16));
                        text.Span($"{footer}");
                    });
                });
            })
                .GeneratePdf("report.pdf");
            //.ShowInPreviewer();
        }
    }
}
