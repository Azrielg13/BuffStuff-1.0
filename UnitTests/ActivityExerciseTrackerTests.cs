using BuffStuff.Interfaces;
using BuffStuff.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuffStuff.UnitTests
{
    public class ActivityExerciseTrackerTests
    {
        [TestFixture]
        public class ProgressSinceLastDayTest
        {
            [Test]
            public void progressFromLastDayCorrect(){
                var mockActivityExercise = new Mock<IActivityExercise>();

                mockActivityExercise.Setup(x => x.)

                var activityExerciseTracker = new ActivityExerciseTracker(mockActivityExercise.Object);
                
                mockActivityExerciseTracker.

            }
        }
    }
}