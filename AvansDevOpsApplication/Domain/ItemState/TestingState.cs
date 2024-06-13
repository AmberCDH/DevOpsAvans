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
            Console.WriteLine("Can't assign users in testing state");
        }

        public void ChangeState(IItemState state)
        {
            if (state == backlogItem.GetTodoState())
            {
                backlogItem.AssigedUsers = [];
                backlogItem.SetState(state);
            }
            else if (state == backlogItem.GetDoneState())
            {
                backlogItem.SetState(state);
            }
            else
            {
                Console.WriteLine("Invalid operation");
            }
        }

        public void RemoveUser(User user)
        {
            Console.WriteLine("Can't remove users in testing state");
        }
    }
}
