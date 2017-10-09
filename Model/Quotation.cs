using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryParser
{
    public enum QuoteTypes
    {
        CharacterImage,
        Plot,
        Funny,
        Aphorism,
        Lifehack
    }
    class Quotation
    {
        private string _shortDescription;
        private string _fullText;
        private double _positionInSource;
        private QuoteTypes _type;

        public Quotation(string shortDescription, string fullText,double positionInSource,QuoteTypes type)
        {
            _shortDescription = shortDescription;
            _fullText = fullText;
            _positionInSource = positionInSource;
            _type = type;
        }

        public string ShortDescription
        {
            get
            {
                return _shortDescription;
            }
        }

        public string FullText
        {
            get
            {
                return _fullText;
            }
        }

        public double PositionInSource
        {
            get
            {
                return _positionInSource;
            }
        }

        public QuoteTypes Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }
    }
}
