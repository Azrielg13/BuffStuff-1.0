using System;
using System.Collections.Generic;
namespace BuffStuff.Interfaces
{
    interface IWorkOutSession
    {
        public virtual int Id { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual IUser _User { get; set; }
        public virtual ICollection<IActivityExercise> ActivityExercises { get; set; }
        public virtual ICollection<IActivityCardio> ActivityCardios { get; set; }
    }
}
