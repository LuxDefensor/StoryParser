using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoryParser
{
    public class Subject
    {
        #region Private fields
        private string _name;
        private List<Lifepoint> _lifeline;
        private List<SubjectProperty> _properties;
        private int _id;
        private StoryPoint _appeared;
        private double _postionInSource;
        private List<Knowledge> _knowledge;
        private List<Quotation> _quotes;
        #endregion

        #region Constructor
        public Subject() : this(Story.maxID + 1)
        {

        }

        public Subject(int id)
        {
            _lifeline = new List<Lifepoint>();
            _properties = new List<SubjectProperty>();
            _knowledge = new List<StoryParser.Knowledge>();
            Quotes = new List<Quotation>();
            Story.maxID = _id = id;
        }
        #endregion

        #region Properties
        public string Name
        {
        get
            {
                return _name;
            }
        set
            {
                _name = value;
            }
        }
        public List<Lifepoint> Lifeline
        {
            get
            {
                return _lifeline;
            }
        }

        public int ID
        {
            get
            {
                return _id;
            }
        }
        public List<SubjectProperty> Properties
        {
            get
            {
                return _properties;
            }
        }

        public StoryPoint Appeared
        {
            get
            {
                return _appeared;
            }

            set
            {
                _appeared = value;
            }
        }

        public double PostionInSource
        {
            get
            {
                return _postionInSource;
            }

            set
            {
                _postionInSource = value;
            }
        }

        internal List<Knowledge> Knowledge
        {
            get
            {
                return _knowledge;
            }
        }

        internal List<Quotation> Quotes
        {
            get
            {
                return _quotes;
            }
        }
        #endregion

        public void Clear()
        {
            foreach (Lifepoint p in _lifeline)
            {
                p.Clear();
            }
            _lifeline.Clear();
            _lifeline = null;
            foreach (SubjectProperty p in _properties)
            {
                p.Clear();
            }
            _properties.Clear();
            _properties = null;

        }
    }
}
