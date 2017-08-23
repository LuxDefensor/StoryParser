using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoryParser
{

    public class Timeline 
    {
        #region Private fields
        private string _title;
        private Story _story;
        private List<StoryPoint> _events;
        private StoryPoint _startPoint;
        #endregion

        #region Constructors

        public Timeline(Story story, string title, StoryPoint startPoint = null)
        {
            _story = story;
            _title = title;
            _events = new List<StoryPoint>();
            if (startPoint == null)
            {
                StoryPoint p = new StoryPoint(this, TimeSpan.Zero, "Story start");
                this._startPoint = p;
            }
        }
        #endregion

        #region Properties
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
        public List<StoryPoint> Events
        {
            get;
        }
        public StoryPoint StartPoint
        {
            get;
        }
        #endregion

        public void Clear()
        {
            _story = null;
            foreach (StoryPoint p in _events)
            {
                p.Clear();
            }
            _events.Clear();
            _events = null;
            _startPoint.Clear();
            _startPoint = null;
        }
    }
}
