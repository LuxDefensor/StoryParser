using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoryParser
{
    public class Place
    {

        #region Private fields
        private string _name;
        private World _world;
        private StoryPoint _appeared;
        private double _positionInSource;
        #endregion

        #region Constructors
        public Place(World world)
        {
            _world = world;
        }
        #endregion

        #region Properties
        public string Name
        {
            get;
            set;
        }
        public World WhichWorld
        {
            get;
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
            _world = null;
        }
        #endregion

        #region Private methods

        #endregion
    }
}
