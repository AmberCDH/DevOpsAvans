using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApplication.Domain.ReportTemplate
{
    public interface BacklogProvider
    {
        List<BacklogItem> getBacklogItems();
    }
}
