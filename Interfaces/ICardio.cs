using System;
namespace BuffStuff.Interfaces
{
    interface ICardio
    {
        public virtual int Id { get; set; }
        public virtual double Distance { get; set; }
        public virtual double Duration { get; set; }
    }
}
