using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffStuff.Interfaces
{
    interface IDateGoal
    {
        public virtual int Id { get; set; }
        public virtual DateTime DateAcheived { get; set; }
        public virtual DateTime DateTargeted { get; set; }
    }
}
