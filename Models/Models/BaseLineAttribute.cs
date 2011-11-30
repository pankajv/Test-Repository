using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class BaseLineAttribute
    {
        Guid _id;
        string _name;

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
    }
}
