using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryParser
{
    class Fact
    {
        private Subject _source;
        private StoryPoint _stated;
        private double _positionInSource;
        private string _shortDescription;
        private string _longDescription;
        private Parameters.Certainty _certainty;
        private Parameters.Veracity _veracity;

        public Fact(Subject source, StoryPoint when, double positionInSource, string shortDescription, string longDescription)
        {
            _source = source;
            _stated = when;
            _positionInSource = positionInSource;
            _shortDescription = shortDescription;
            _longDescription = longDescription;
            _veracity = Parameters.Veracity.Truth;
            _certainty = Parameters.Certainty.NoIdeaIfTrue;
        }

        public Fact(Subject source, StoryPoint when, double positionInText, string shortDescription)
            : this(source, when, positionInText, shortDescription, string.Empty)
        {

        }

        public Subject Source
        {
            get
            {
                return _source;
            }
        }

        public StoryPoint Stated
        {
            get
            {
                return _stated;
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

        public string ShortDescription
        {
            get
            {
                return _shortDescription;
            }

            set
            {
                _shortDescription = value;
            }
        }

        public string LongDescription
        {
            get
            {
                return _longDescription;
            }

            set
            {
                _longDescription = value;
            }
        }

        public Parameters.Certainty Certainty
        {
            get
            {
                return _certainty;
            }

            set
            {
                _certainty = value;
            }
        }

        public Parameters.Veracity Veracity
        {
            get
            {
                return _veracity;
            }

            set
            {
                _veracity = value;
            }
        }
    }
}
