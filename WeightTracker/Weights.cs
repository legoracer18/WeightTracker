using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightTracker
{
    public class Weights
    {
        private string date;
        private string weightNum;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string WeightNum
        {
            get { return weightNum; }
            set { weightNum = value; }
        }
    }
}
