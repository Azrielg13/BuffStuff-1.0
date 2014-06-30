using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffStuff.Interfaces
{
    interface IActivityCardioTracker : IActivityTracker
    {
        public virtual IActivityCardio _ActivityCardio { get; set; }
    }
}
