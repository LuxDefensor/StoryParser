using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoryParser
{
    public class Parameters
    {
        public enum Veracity
        {
            Truth = 10,
            MostlyTruth = 9,
            LikelyTruth = 8,
            Undefined = 5,
            LikelyLie = 2,
            MostlyLie = 1,
            Lie = 0
        }

        public enum Accuracy
        {
            Exact = 10,
            AlmostExact = 9,
            Accurate = 8,
            Medium = 5,
            Approximate = 2,
            Vague = 1,
            TotallyVague = 0
        }

        public enum Certainty
        {
            Certain = 10,
            Positive = 9,
            ThinkSo = 5,
            Maybe = 2,
            NotSure = 1,
            NoIdeaIfTrue = 0
        }
    }
}
