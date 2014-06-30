using BuffStuff.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuffStuff.Models
{
    public class ActivityExercise : IActivityExercise
    {

        public int Id { get; set; }
        public IWorkOutSession _WorkOutSession { get; set; }
        public IActivityType _ActivityType { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public double Weight { get; set; }

        public ActivityExercise(IWorkOutSession workOutSession, IActivityType activityType)
        {
            this._WorkOutSession = workOutSession;
            this._ActivityType = activityType;
        }

    }
}