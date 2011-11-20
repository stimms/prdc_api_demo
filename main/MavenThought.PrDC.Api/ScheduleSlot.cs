using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MavenThought.PrDC.Api
{
    public class ScheduleSlot : IScheduleSlot
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public String Customer { get; set; }
        public bool Main { get; set; }
        public int SessionId { get; set; }
        public string Room { get; set; }
    }
}
