using System;
using System.Collections.Generic;
using System.Linq;

namespace MavenThought.PrDC.Api
{
    public interface IDay
    {
        string Name { get; set; }
        IEnumerable<ScheduleSlot> ScheduleSlot { get; set; }
    }
}
