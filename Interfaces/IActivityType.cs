using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffStuff.Interfaces
{
    interface IActivityType
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual byte[] Image { get; set; }
        public virtual string VideoUrl { get; set; }

    }
}
