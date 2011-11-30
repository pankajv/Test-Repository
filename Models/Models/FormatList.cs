using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class FormatList
    {
        Guid _id;
        string _name;
        IList<Franchise> _lstFranchise;

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
        internal IList<Franchise> LstFranchise
        {
            get { return _lstFranchise; }
            set { _lstFranchise = value; }
        }
    }
}
