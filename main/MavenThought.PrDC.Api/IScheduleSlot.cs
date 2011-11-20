using System;
using System.Collections.Generic;
using System.Linq;

namespace MavenThought.PrDC.Api
{
    public interface IScheduleSlot
    {
        int Id { get; set; }
        DateTime Start { get; set; }
        DateTime Finish { get; set; }
        String Customer { get; set; }
        bool Main { get; set; }
        int SessionId { get; set; }
        string Room { get; set; }
    }
}
