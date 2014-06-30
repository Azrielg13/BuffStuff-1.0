using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffStuff.Interfaces
{
    interface IActivityTracker
    {
        public virtual double ProgressSinceLastDay();
        public virtual double ProgressForMonth();
        public virtual double ProgressForYear();
        public virtual double ProgressOverall();
    }
}
