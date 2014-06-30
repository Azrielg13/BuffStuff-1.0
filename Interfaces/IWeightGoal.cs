using System;

namespace BuffStuff.Interfaces
{
    interface IWeightGoal 
    {
        public virtual int Id { get; set; }
        public virtual double DesiredWeight { get; set; }
        public virtual IUser _User { get; set; }

    }
}
