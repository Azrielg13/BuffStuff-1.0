using BuffStuff.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuffStuff.Models
{
    public class WorkOutSession : IWorkOutSession
    {
        public int Id { get; set; }
        public IUser _User { get; set; }
        public DateTime Date { get; set; }

        public void WorkOutSession(IUser user)
        {
            this._User = user;
        }

    }
}