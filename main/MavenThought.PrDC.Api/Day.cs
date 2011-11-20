using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MavenThought.PrDC.Api
{
    public class Day
    {
        public string Name { get; set; }
        public IEnumerable<ScheduleSlot> ScheduleSlot { get; set; }
    }
}
