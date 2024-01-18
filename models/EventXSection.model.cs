using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tickets.models
{
    public class EventXSection
    {
        public int id { get; set; }
        public int SectionId { get; set; }
        public Section Section { get; set; }
        public int EventId { get; set; }
        public Events Events { get; set; }
        public float price { get; set; }
    }
}