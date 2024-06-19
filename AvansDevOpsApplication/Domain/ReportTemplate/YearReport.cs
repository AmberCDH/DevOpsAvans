namespace AvansDevOpsApplication.Domain.ReportTemplate
{
    internal class YearReport : ReportTemplate
    {
        private BacklogProvider backlogProvider;
        public YearReport(BacklogProvider backlogProvider)
        {
            this.backlogProvider = backlogProvider;
        }

        protected override List<BacklogItem> FilterBacklogItems()
        {
            return backlogProvider.getBacklogItems().Where(x => x.TimeOfCreation >= DateTime.Now.AddYears(-1)).ToList();
        }

        protected override void SetBody(List<BacklogItem> backlogItems)
        {
            foreach (var item in backlogItems)
            {
                Console.WriteLine(item.Name);
            }
        }

        protected override void SetFooter()
        {
           Console.WriteLine("============================");
        }

        protected override void SetHeader()
        {
            Console.WriteLine("Yearly backlog report");
        }
    }
}
