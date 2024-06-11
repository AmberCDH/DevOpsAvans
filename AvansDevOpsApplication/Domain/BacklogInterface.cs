using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApplication.Domain
{
    public interface BacklogInterface
    {
        public void RemoveFromBacklog(Guid id);
        public void AddItemToBacklog(BacklogItem backlogItem);
    }
}
