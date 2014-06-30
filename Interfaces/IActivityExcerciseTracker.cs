using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffStuff.Interfaces
{
    interface IActivityExcerciseTracker : IActivityTracker
    {
        public virtual IActivityExercise _ActivityExercise { get; set; }
    }
}
