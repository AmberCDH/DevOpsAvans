using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApplication.Domain.ItemState
{
    public interface IItemState
    {
        public void AssignUser(User user);
        public void RemoveUser(User user);
        public void ChangeState(IItemState state);
    }
}
