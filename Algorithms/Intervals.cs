using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Intervals
    {
        public static int SumIntervals((int, int)[] intervals)
        {
            var sum = 0;
            //intervals.Select(o => new { val = (o.Item2 - o.Item1) })
            return intervals.Select(o => (o.Item2 - o.Item1)).Distinct().Sum();
            //Array.ForEach(intervals,(() => ))
        }
    }
}
