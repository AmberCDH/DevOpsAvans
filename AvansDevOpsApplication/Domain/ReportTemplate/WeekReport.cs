namespace AvansDevOpsApplication.Domain.ReportTemplate
{
    public class WeekReport : ReportTemplate
    {
        private BacklogProvider backlogProvider;
        public WeekReport(BacklogProvider backlogProvider)
        {
            this.backlogProvider = backlogProvider;
        }

        protected override List<BacklogItem> FilterBacklogItems()
        {
            return backlogProvider.getBacklogItems().Where(x => x.TimeOfCreation >= DateTime.Now.AddDays(-7)).ToList();
        }

        protected override void SetBody(List<BacklogItem> backlogItems)
        {
            foreach (var item in backlogItems)
            {
                Console.WriteLine("~Backlog item: "+item.Name);
            }
        }

        protected override void SetFooter()
        {
            Console.WriteLine("=============="+DateTime.Now+"==============");
        }

        protected override void SetHeader()
        {
            Console.WriteLine("Weekly backlog report");
        }
    }
}
