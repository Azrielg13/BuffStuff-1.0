using BuffStuff.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuffStuff.Models
{
    public class ActivityExerciseTracker : IActivityExerciseTracker
    {

        public IActivityExercise _Activity { get; set; }

        public ActivityExerciseTracker(IActivityExercise activity)
        {
            this._Activity = activity;
        }

        //gets furthest out workout session and most recent workout session of same type
        public double ProgressSinceLastDay()
        {
            //sort workout sessions by date closest and removes future dates to loop through less incase
            //of looking at historical progress tracking
            var sortedWorkOutSessions = _Activity._WorkOutSession._User.WorkOutSessions
                                                 .Where(a => a.Date <= _Activity._WorkOutSession.Date)
                                                 .OrderByDescending(a => a.Date)
                                                 .ToList();
            
            //finds first date less than the date for the activity passed into this tracker
            foreach (IWorkOutSession workOutSession in sortedWorkOutSessions)
            {
                if(workOutSession.Date<_Activity._WorkOutSession.Date)
                    foreach (IActivityExercise activity in workOutSession.ActivityExercises)
                    {
                        if (activity._Type == _Activity._Type)
                        {
                            //calculates percent gain ((new - old)/old)*100
                            return ((_Activity.Weight - activity.Weight) / activity.Weight)*100;
                        }
                    }
            }
            //if you never did the excerise before that's 100% increase
           return 100;
        }

        public double ProgressForMonth()
        {
            //sort workout sessions by date closest and removes future dates to loop through less incase
            //of looking at historical progress tracking
            var monthBackDate = _Activity._WorkOutSession.Date.AddMonths(-1);
            var sortedWorkOutSessions = _Activity._WorkOutSession._User.WorkOutSessions
                                                 .Where(a => a.Date <= monthBackDate)
                                                 .OrderByDescending(a => a.Date)
                                                 .ToList();

            //finds first date less than the date-1 month for the activity passed into this tracker
            foreach (IWorkOutSession workOutSession in sortedWorkOutSessions)
            {
                if (workOutSession.Date <= monthBackDate)
                    foreach (IActivityExercise activity in workOutSession.ActivityExercises)
                    {
                        if (activity._Type == _Activity._Type)
                        {
                            //calculates percent gain ((new - old)/old)*100
                            return ((_Activity.Weight - activity.Weight) / activity.Weight) * 100;
                        }
                    }
            }
            //if you never did the excerise before that's 100% increase
            return 100;
        }

        public double ProgressForYear()
        {
            //sort workout sessions by date closest out and removes future dates to loop through less incase
            //of looking at historical progress tracking
            var yearBackDate = _Activity._WorkOutSession.Date.AddYears(-1);
            var sortedWorkOutSessions = _Activity._WorkOutSession._User.WorkOutSessions
                                                 .Where(a => a.Date <= yearBackDate)
                                                 .OrderByDescending(a => a.Date)
                                                 .ToList();

            //finds first date less than the date-1 month for the activity passed into this tracker
            foreach (IWorkOutSession workOutSession in sortedWorkOutSessions)
            {
                if (workOutSession.Date <= yearBackDate)
                    foreach (IActivityExercise activity in workOutSession.ActivityExercises)
                    {
                        if (activity._Type == _Activity._Type)
                        {
                            //calculates percent gain ((new - old)/old)*100
                            return ((_Activity.Weight - activity.Weight) / activity.Weight) * 100;
                        }
                    }
            }
            //if you never did the excerise before that's 100% increase
            return 100;
        }

        public double ProgressOverall()
        {
            //sort workout sessions by date further out by type and grab the first one, this will return
            //the very first time of the attempted exercise

            var first = _Activity._WorkOutSession._User.WorkOutSessions.SelectMany(a => a.ActivityExercises)
                                                  .Where(a => a._Type == _Activity)
                                                  .OrderBy(a => a._WorkOutSession.Date)
                                                  .First();

            if (first != null)
            {
                return ((_Activity.Weight - first.Weight) / first.Weight) * 100;
            }
                                                
            //if you never did the excerise before that's 100% increase
            return 100;
        }
    }
}