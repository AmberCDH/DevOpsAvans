using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApplication.Domain.ItemState
{
    public class DoneState : IItemState
    {
        private BacklogItem backlogItem;
        public DoneState(BacklogItem backlogItem)
        {
            this.backlogItem = backlogItem;
        }

        public void AssignUser(User user)
        {
            Console.WriteLine("Can't assign users in done state");
        }

        public void ChangeState(IItemState state)
        {
            Console.WriteLine("Can't change state");
        }

        public void RemoveUser(User user)
        {
            Console.WriteLine("Can't remove users in done state");
        }
    }
}
