using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Previewer;

namespace AvansDevOpsApplication.Domain.Factory
{
    public class ExportPdf : Export
    {
        [Obsolete]
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
                        text.DefaultTextStyle(x => x.Size(20));
                        text.Span($"{header}");
                        text.Element()
                        .PaddingBottom(-6)
                        .Height(24)
                        .Width(48)
                        .Image(Placeholders.Image);
                    });
                    page.Content().Background(Colors.Grey.Lighten3);
                    page.Footer().Height(50).Background(Colors.Grey.Lighten1).AlignCenter().Text(text =>
                    {
                        text.DefaultTextStyle(x => x.Size(16));
                        text.Span($"{footer}");
                    });
                });
            })
                .ShowInPreviewer();
        }
    }
}
