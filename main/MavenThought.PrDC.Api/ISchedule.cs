using System;
using System.Collections.Generic;
using System.Linq;

namespace MavenThought.PrDC.Api
{
    public interface ISchedule
    {
        IEnumerable<Day> Days { get; set; }
    }
}
