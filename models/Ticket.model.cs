using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tickets.models
{
    public class Ticket
    {
        public int id { get; set; }

        [ForeignKey("ClientEntity")]
        public int idClient { get; set; }
        public Entity ClientEntity { get; set; } // Propiedad de navegación para el cliente

        // Llave foránea para el receptor
        [ForeignKey("ReceiverEntity")]
        public int idReceiver { get; set; }
        public Entity ReceiverEntity { get; set; } // Propiedad de navegación para el receptor

        public int idEventDate { get; set; }
        public EventDate EventDate { get; set; }
        public int idSection { get; set; }
        public Section Section { get; set; }

    }
}