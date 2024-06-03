using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApplication.Domain.ReportTemplate
{
    internal class WeekReport : ReportTemplate
    {
        private BacklogProvider backlogProvider;
        public WeekReport(BacklogProvider backlogProvider) : base(backlogProvider)
        {
            this.backlogProvider = backlogProvider;
        }

        protected override List<BacklogItem> FilterBacklogItems()
        {
            return backlogProvider.getBacklogItems().Where(x => x.TimeOfCreation >= DateTime.Now.AddDays(-7)).ToList();
        }

        protected override void SetBody(List<BacklogItem> backlogItems)
        {
            throw new NotImplementedException();
        }

        protected override void SetFooter()
        {
            throw new NotImplementedException();
        }

        protected override void SetHeader()
        {
            throw new NotImplementedException();
        }
    }
}
