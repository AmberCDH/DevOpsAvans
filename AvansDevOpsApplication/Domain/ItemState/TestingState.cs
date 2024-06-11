using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApplication.Domain.ItemState
{
    public class TestingState : IItemState
    {
        private BacklogItem backlogItem;
        public TestingState(BacklogItem backlogItem)
        {
            this.backlogItem = backlogItem;
        }

        public void AssignUser(User user)
        {
            throw new NotImplementedException();
        }

        public void ChangeState(IItemState state)
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
