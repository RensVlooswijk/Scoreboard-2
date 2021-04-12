using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScoreboardApp_3;

namespace ScoreboardApp_3
{
    public class CounterAlgorithms
    {
        public void CounterAlgorithm()
        {
            CounterPage CPAl = new CounterPage();
            //For volleyball every click just adds one point but for tennis the added points depend on its current score
            if (CPAl.CurrentSport == "Volleyball")
            {
                CPAl.AddValue = 1;
            }
            if (CPAl.CurrentSport == "Tennis")
            {
                if (CPAl.HomeScoreCounter == 0 || CPAl.HomeScoreCounter == 15)
                {
                    CPAl.AddValue = 15;
                }
                if (CPAl.HomeScoreCounter == 30)
                {
                    CPAl.AddValue = 10;
                }
                if (CPAl.HomeScoreCounter > 39)
                {
                    CPAl.AddValue = 5;
                }
            }
            return;
        }
    }
}
