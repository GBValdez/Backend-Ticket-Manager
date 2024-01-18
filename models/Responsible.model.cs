using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tickets.models
{
    public class Responsible
    {
        public int id { get; set; }
        public int EntityId { get; set; }
        public Entity Entity { get; set; }
        public string location { get; set; }
    }
}