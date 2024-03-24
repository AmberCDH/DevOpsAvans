using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApplication.Domain.State
{
    public class PipelineState : ISprintState
    {
        public void AddBacklogItem(BacklogItem backlogItem)
        {
            throw new NotImplementedException();
        }

        public void RemoveBacklogItem(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
