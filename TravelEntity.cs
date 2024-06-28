using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class TravelEntity
    {
        protected string name,description;
        public TravelEntity() { }
        public TravelEntity(string name ,string description)
        {
            this.name = name;
            this.description = description;
        }
      public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Description
        {
            set { description = value; }
            get { return description; }
        }

    }
}
