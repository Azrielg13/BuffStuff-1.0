using BuffStuff.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace BuffStuff.Models
{
    public class ActivityCardioTracker : IActivityTracker
    {
        public IActivityCardio _ActivityCardio { get; set; }

        public ActivityCardioTracker(IActivityCardio activityCardio)
        {
            this._ActivityCardio = activityCardio;
        }

        public double ProgressSinceLastDay()
        {
            throw new NotImplementedException();
        }

        public double ProgressForMonth()
        {
            throw new NotImplementedException();
        }

        public double ProgressForYear()
        {
            throw new NotImplementedException();
        }

        public double ProgressOverall()
        {
            throw new NotImplementedException();
        }


    }
}