using BuffStuff.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuffStuff.Models
{
    public class ActivityCardio : IActivityCardio
    {
        public int Id { get; set; }
        public IWorkOutSession _WorkOutSession { get; set; }
        public IActivityType _Type { get; set; }
        public double Duration { get; set; }
        public double Distance { get; set; }

        public ActivityCardio(IWorkOutSession workOutSession, IActivityType type)
        {
            this._WorkOutSession = workOutSession;
            this._Type = type;
        }
    }
}