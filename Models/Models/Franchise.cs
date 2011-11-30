using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class Franchise
    {
        Guid _id;
        string _name;
        IList<Format> _lstFormat;

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        internal IList<Format> ListFormat
        {
            get { return _lstFormat; }
            set { _lstFormat = value; }
        }
    }
}
