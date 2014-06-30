using BuffStuff.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffStuff.Interfaces
{
    interface IActivity
    {
        public virtual int Id { get; set; }
        public virtual IWorkOutSession _WorkOutSession { get; set; }
        public virtual IActivityType _Type { get; set; }

    }
}
