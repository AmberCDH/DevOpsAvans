﻿namespace AvansDevOpsApplication.Domain.ReportTemplate
{
    abstract class ReportTemplate
    {
        private BacklogProvider backlogProvider;

        public ReportTemplate(BacklogProvider backlogProvider)
        {
            this.backlogProvider = backlogProvider;
        }

        public void GenerateReport()
        {
            var backlogItems = FilterBacklogItems();
            SetHeader();
            SetBody(backlogItems);
            SetFooter();
        }

        protected abstract List<BacklogItem> FilterBacklogItems();
        protected abstract void SetHeader();
        protected abstract void SetBody(List<BacklogItem> backlogItems);
        protected abstract void SetFooter();
    }
}
