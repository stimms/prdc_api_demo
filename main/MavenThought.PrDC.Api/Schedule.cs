using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MavenThought.PrDC.Api
{
    public class Schedule : ISchedule
    {
        public IEnumerable<Day> Days { get; set; }
    }
}
