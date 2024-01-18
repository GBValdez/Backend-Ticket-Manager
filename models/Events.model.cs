using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tickets.models
{
    public class Events
    {
        public int id { get; set; }
        public string name { get; set; }
        public string location { get; set; }

        [ForeignKey("Entity")]
        public int responsibleId { get; set; }
        public Entity Entity { get; set; }
    }
}