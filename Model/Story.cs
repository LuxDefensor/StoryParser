using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace StoryParser
{
    public class Story
    {
        public static int maxID = 0;
        #region Private fields
        private List<Timeline> _timelines;
        private List<StoryPoint> _flow;
        private Subject _narrator;
        private Subject _reader;
        private List<Subject> _subjects;
        private List<World> _worlds;
        private List<UnitConversion> _conversions;
        private string _title;
        private string _author;
        private string _storyType;
        private string _sourceURI;
        #endregion

        #region Constructors
        public Story()
        {
            _timelines = new List<Timeline>();
            _timelines.Add(new Timeline(this, "Main"));
            _flow = new List<StoryPoint>();
            _worlds = new List<World>();
            _conversions = new List<UnitConversion>();
            _narrator = new Subject();
            _reader = new Subject();
        }
        #endregion

        #region Properties

        public List<Timeline> Timelines
        {
        get
            {
                return _timelines;
            }
        }
        public Subject Narrator
        {
            get
            {
                return _narrator;
            }
            set
            {
                _narrator = value;
            }
        }
        public Subject Reader
        {
            get
            {
                return _reader;
            }
            set
            {
                _reader = value;
            }
        }
        public List<Subject> Subjects
        {
            get;
        }
        public List<World> Worlds
        {
            get;
        }

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

        public string Author
        {
            get
            {
                return _author;
            }

            set
            {
                _author = value;
            }
        }

        public string StoryType
        {
            get
            {
                return _storyType;
            }

            set
            {
                _storyType = value;
            }
        }

        public string SourceURI
        {
            get
            {
                return _sourceURI;
            }

            set
            {
                _sourceURI = value;
            }
        }

        public List<Tuple<Subject, int>> RatedSubjects
        {
            get
            {
                List<Tuple<Subject, int>> result;
                var query=from Subject s in _subjects
                          select new Tuple<Subject,int>(s,_timelines.Sum(t=>t.Events.Count(p=>s.Lifeline.Any(lp=>lp.Storypoint==p))));
                result = query.ToList();
                return result;
            }
        }


        public void Erase()
        {
            foreach (Timeline t in _timelines)
            {
                t.Clear();
            }
            _timelines.Clear();
            _timelines = null;
        }

        public void Save(string fileName)
        {
            XmlWriter xml = XmlWriter.Create(_title + ".xml");
            xml.WriteStartDocument();
            xml.WriteStartElement("Story");
            xml.WriteAttributeString("title", _title);
            xml.WriteAttributeString("authhor", _author);
            xml.WriteAttributeString("storyType", _storyType);
            xml.WriteAttributeString("narrator", _narrator.ID.ToString());
            xml.WriteAttributeString("reader", _reader.ID.ToString());
            foreach (Timeline t in _timelines)
            {
                xml.WriteStartElement("Timeline");
                xml.WriteAttributeString("title", t.Title);
                xml.WriteAttributeString("StartPoint", t.StartPoint.ID.ToString());
                foreach (StoryPoint p in t.Events)
                {
                    xml.WriteStartElement("StoryPoint");
                    xml.WriteAttributeString("ID", p.ID.ToString());
                    xml.WriteAttributeString("TimeStamp", p.Timestamp.ToString());
                    xml.WriteAttributeString("Title", p.Title);
                    xml.WriteEndElement(); 
                }
                xml.WriteEndElement();
            }
            foreach (World w in _worlds)
            {
                xml.WriteStartElement("World");
                xml.WriteAttributeString("Name", w.Name);
                foreach (Place p in w.Places)
                {
                    xml.WriteStartElement("Place");
                    xml.WriteAttributeString("Name", p.Name);
                    xml.WriteEndElement();
                }
                xml.WriteEndElement();
            }
            foreach (Subject s in _subjects)
            {
                xml.WriteStartElement("Subject");
                xml.WriteAttributeString("Name", s.Name);
                xml.WriteAttributeString("ID", s.ID.ToString());
                foreach (Lifepoint p in s.Lifeline)
                {
                    xml.WriteStartElement("Lifepoint");
                    xml.WriteAttributeString("Timestamp", p.Timestamp.ToString());
                    xml.WriteAttributeString("StoryPoint", p.Storypoint.ID.ToString());
                    xml.WriteEndElement();
                }
                foreach (SubjectProperty p in s.Properties)
                {
                    xml.WriteStartElement("SubjectProperty");
                    xml.WriteAttributeString("Name", p.Name);
                    xml.WriteAttributeString("Value", p.Value);
                    xml.WriteAttributeString("StoryPoint", p.StoryPoint.ID.ToString());
                    xml.WriteEndElement();
                }
                xml.WriteEndElement();
            }
            xml.WriteEndDocument();
            xml.Close();
        }

        #endregion
    }
}
