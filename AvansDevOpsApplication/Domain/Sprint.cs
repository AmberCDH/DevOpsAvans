using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApplication.Domain
{

    public abstract class Sprint
    {
        private Guid id;
        private string name;

        public Sprint(Guid id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Guid Id
        {
            get { return id; }
        }
    }
}
