using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryParser
{
    public class UnitConversion
    {
        private string _unitName;
        private string _unitNameAbbr;
        private double _inUniversalUnits;

        public UnitConversion(string unitName, double inUniversalUnits)
            : this(unitName, unitName, inUniversalUnits)
        {
        }

        public UnitConversion(string unitName, string unitNameAbbr, double inUniversalUnits)
        {
            _unitName = unitName;
            _unitNameAbbr = unitNameAbbr;
            _inUniversalUnits = inUniversalUnits;
        }

        public string UnitName
        {
            get
            {
                return _unitName;
            }
        }

        public string UnitNameAbbr
        {
            get
            {
                return _unitNameAbbr;
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
