using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

    /// <summary>
    /// deprecated
    /// use class Distance instead
    /// WARNING: Directions enum is declared here
    /// it is being used in other classes
    /// </summary>
    public class RelativePosition
    {

        #region Private fields
        private Place _relativePoint;
        private double _distance;
        private Parameters.Accuracy _distanceAccuracy;
        private Place _directionRelative;
        private Directions _directionAbsolute;
        #endregion

        #region Constructors
        public RelativePosition()
        {

        }
        #endregion

        #region Properties

        #endregion

        #region Public methods

        #endregion

        #region Private methods

        #endregion
    }
}
