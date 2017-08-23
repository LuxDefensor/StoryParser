using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryParser
{
    public class World
    {
        private string _name;
        //private Story _story;
        private List<Place> _places;

        public World(Story story)
        {
            //_story = story;
            _places = new List<Place>();
        }
        public string Name
        {
            get; set;
        }

        public List<Place> Places
        {
            get
            {
                return _places;
            }
        }

        public void Clear()
        {
            foreach (Place p in _places)
            {
                p.Clear();
            }
            _places.Clear();
            _places = null;
        }
    }
}
