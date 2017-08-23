using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryParser
{
    class Knowledge
    {
        private Subject _source;
        private StoryPoint _knownSince;
        private Fact _fact;
        private double _positionInSource;
        private Parameters.Certainty _subjectiveCertainty;

        public Knowledge(Fact fact, Subject source, StoryPoint knownSince, double positionInSource)
        {
            _fact = fact;
            _source = source;
            _knownSince = knownSince;
            _positionInSource = positionInSource;
        }

        public Subject Source
        {
            get
            {
                return _source;
            }
        }

        public StoryPoint KnownSince
        {
            get
            {
                return _knownSince;
            }
        }

        internal Fact Fact
        {
            get
            {
                return _fact;
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

        public Parameters.Certainty SubjectiveCertainty
        {
            get
            {
                return _subjectiveCertainty;
            }

            set
            {
                _subjectiveCertainty = value;
            }
        }

        public Knowledge()
        {

        }
    }
}
