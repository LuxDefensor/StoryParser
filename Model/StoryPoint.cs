using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoryParser
{
    public class StoryPoint
    {
        #region Private fields
        private Timeline _timeline;
        private TimeSpan _timestamp;
        private string _title;
        private int _id;
        private double _positionInSource;

        #endregion

        #region Constructors
        public StoryPoint(Timeline timeline, TimeSpan timestamp, string title, int id)
        {
            _title = title;
            _timeline = timeline;
            _timestamp = timestamp;
            Story.maxID = _id = id;
        }
        public StoryPoint(Timeline timeline, TimeSpan timestamp, string title)
            : this(timeline, timestamp, title, Story.maxID + 1)
        {

        }

        #endregion

        #region Properties
        public int ID
        {
        get
            {
                return _id;
            }
        }
        public TimeSpan Timestamp
        {
        get
            {
                return _timestamp;
            }
        }
        public DateTime Point
        {
        get
            {
                if (this == _timeline.StartPoint)
                    return DateTime.MinValue + _timestamp;
                else
                    return _timeline.StartPoint.Point + _timestamp;
            }
        }

        public string Title
        {
            get
            {
                return _title;
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
            _timeline = null;

        }
        #endregion

        #region Private methods

        #endregion
    }
}
