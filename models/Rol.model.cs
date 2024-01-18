using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tickets.models
{
    public class Rol
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<User> Users { get; set; }
    }
}