using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryParser
{
    public enum Directions
    {
        North = 0,
        NorthEast = 45,
        East = 90,
        SouthEast = 135,
        South = 180,
        SouthWest = 225,
        West = 270,
        NorthWest = 315
    }

    class Distance
    {
        private Place _placeA;
        private Place _placeB;
        private Directions _direction;
        private double _length;
        private DistanceUnit _unit;

        public Place PlaceA
        {
            get
            {
                return _placeA;
            }
        }

        public Place PlaceB
        {
            get
            {
                return _placeB;
            }
        }

        public Directions Direction
        {
            get
            {
                return _direction;
            }
        }

        public double Length
        {
            get
            {
                return _length;
            }
        }

        public DistanceUnit Unit
        {
            get
            {
                return _unit;
            }
        }

        public Distance(Place a, Place b, Directions direction, double length, DistanceUnit unit)
        {
            _placeA = a;
            _placeB = b;
            _direction = direction;
            _length = length;
            _unit = unit;
        }

        public bool Connects(Place place)
        {
            return _placeA == place || _placeB == place;
        }

        public Place OtherEnd(Place place)
        {
            if (place == _placeA)
                return _placeB;
            else if (place == _placeB)
                return _placeA;
            else
                return null;
        }
    }
}

