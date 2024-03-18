using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApplication.Domain.SprintState
{
    public interface ISprintState
    {
        public void AddBacklogItem(BacklogItem backlogItem);
        public void RemoveBacklogItem(Guid id);
    }
}
