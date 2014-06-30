using BuffStuff.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuffStuff.Models
{
    public class DateWeightGoal : IDateWeightGoal
    {
        public int Id { get; set; }
        public IUser _User { get; set; }
        public double DesiredWeight { get; set; }
        public DateTime DateTargeted { get; set; }
        public DateTime DateAcheived { get; set; }

        public DateWeightGoal(IUser user)
        {
            this._User = user;
        }

    }
}