using System;
namespace BuffStuff.Interfaces
{
    interface IExercise
    {
        public virtual int Id { get; set; }
        public virtual int Reps { get; set; }
        public virtual int Sets { get; set; }
        public virtual double Weight { get; set; }
    }
}
