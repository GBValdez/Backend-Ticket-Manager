using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tickets.models
{
    public class EventDate
    {
        public int id { get; set; }
        public DateTime initDate { get; set; }
        public DateTime finalDate { get; set; }
        public int eventId { get; set; }
        public Events Events { get; set; }
    }
}