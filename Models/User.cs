﻿using BuffStuff.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuffStuff.Models
{
    public class User : IUser
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual DateTime Dob { get; set; }
        public virtual string Height { get; set; }
        public virtual double Weight { get; set; }
        public virtual ICollection<IWorkOutSession> WorkOutSessions { get; set; }

    }
}