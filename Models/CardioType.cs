using BuffStuff.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuffStuff.Models
{
    public class CardioType : IActivityType
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual byte[] Image { get; set; }
        public virtual string VideoUrl { get; set; }
    }
}