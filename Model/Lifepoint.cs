using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoryParser
{
    public class Lifepoint
    {

        #region Private fields
        //private Subject _subject;
        private StoryPoint _storypoint;
        private TimeSpan _timestamp;
        double _positionInSource;
        #endregion

        #region Constructors
        public Lifepoint(StoryPoint storypoint, TimeSpan timestamp)
        {
            _storypoint = storypoint;
            _timestamp = timestamp;
        }
        #endregion

        #region Properties
        public TimeSpan Timestamp
        {
        get
            {
                return _timestamp;
            }
        }
        public StoryPoint Storypoint
        {
        get
            {
                return _storypoint;
            }
        }

        public double PositionInSource
        {
            get
            {
                return _positionInSource;
            }

            set
            {
                _positionInSource = value;
            }
        }
        #endregion

        #region Public methods
        public void Clear()
        {
            _storypoint.Clear();
            _storypoint = null;
        }
        #endregion

        #region Private methods

        #endregion
    }
}
