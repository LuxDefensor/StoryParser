using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryParser
{
    public class DistanceUnit
    {
        private string _unitName;
        private string _abbreviation;
        private double _inUniversalUnits;
        public static List<DistanceUnit> allUnits = new List<DistanceUnit>();

        public DistanceUnit(string unitName, string abbreviation, double inUniversalUnits)
        {
            _unitName = unitName;
            _abbreviation = abbreviation;
            _inUniversalUnits = inUniversalUnits;
            if (allUnits.Contains(this))
                throw new Exception("Duplicate distance unit");
            allUnits.Add(this);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != typeof(DistanceUnit))
                return false;
            DistanceUnit other = (DistanceUnit)obj;
            return other.UnitName == this.UnitName;
        }

        public DistanceUnit(string unitName, double inUniversalUnits) : this(unitName, unitName.Substring(0, 1).ToUpper(), inUniversalUnits)
        {

        }

        public string UnitName
        {
            get
            {
                return _unitName;
            }
        }

        public string Abbreviation
        {
            get
            {
                return _abbreviation;
            }
        }

        public double InUniversalUnits
        {
            get
            {
                return _inUniversalUnits;
            }
        }
    }
}
