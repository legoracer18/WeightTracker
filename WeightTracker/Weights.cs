using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightTracker
{
    public class Weights
    {
        private DateTime date;
        private double weightNum;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public double WeightNum
        {
            get { return weightNum; }
            set { weightNum = value; }
        }
    }
}
