using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryParser
{
    public class SubjectProperty
    {
        private Subject _subject;
        private StoryPoint _storyPoint;
        private string _name;
        private string _value;

        public SubjectProperty(Subject who, StoryPoint when, string name, string value)
            : this(who, when)
        {

            _name = name;
            _value = value;
        }

        public SubjectProperty(Subject who, StoryPoint when)
        {
            _subject = who;
            _storyPoint = when;
        }

        public Subject Subject
        {
            get
            {
                return _subject;
            }
        }

        public StoryPoint StoryPoint
        {
            get
            {
                return _storyPoint;
            }
        }

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

        public string Value
        {
            get
            {
                return _value;
            }

            set
            {
                _value = value;
            }
        }

        public void Clear()
        {
            _subject = null;
            _storyPoint = null;
        }
    }
}
