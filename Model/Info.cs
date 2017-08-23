using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoryParser
{
    /// <summary>
    /// deprecated
    /// use class Fact instead
    /// </summary>
    public class Info
    {

        public enum InfoType
        {
            Person,
            Place,
            Event,
            Item,
            Universe
        }

        #region Private fields
        private InfoType _type;
        private StoryPoint _appeared;
        private Parameters.Veracity _veracity;
        private object _infoaboutwhat;
        #endregion

        #region Constructors

        #endregion

        #region Properties

        #endregion

        #region Public methods

        #endregion

        #region Private methods

        #endregion
    }
}
