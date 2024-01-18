using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tickets.models
{
    public class User
    {
        public int id { get; set; }

        [ForeignKey("Entity")]
        public int clientId { get; set; }
        public Entity Entity { get; set; }

        public string password { get; set; }

        public string email { get; set; }
        public List<Rol> Roles { get; set; }

    }
}