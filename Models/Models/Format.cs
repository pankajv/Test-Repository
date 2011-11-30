using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    class Format
    {
        Guid _id;
        string _name;
        BaseLineAttribute _baselineAttribute;
        BarterAttribute _barterAttribute;
        NonBarterAttribute _nbarterAttribute;
        DateTime _startDateTime;
        DateTime _endDateTime;

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
        public BaseLineAttribute BaselineAttribute
        {
            get { return _baselineAttribute; }
            set { _baselineAttribute = value; }
        }
        internal NonBarterAttribute NbarterAttribute
        {
            get { return _nbarterAttribute; }
            set { _nbarterAttribute = value; }
        }
        public DateTime StartDateTime
        {
            get { return _startDateTime; }
            set { _startDateTime = value; }
        }
        public DateTime EndDateTime
        {
            get { return _endDateTime; }
            set { _endDateTime = value; }
        }
    }
}
