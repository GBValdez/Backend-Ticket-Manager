using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tickets.models;

namespace tickets
{
    public class AplicationDBContex : DbContext
    {
        public AplicationDBContex(DbContextOptions<AplicationDBContex> options) : base(options)
        {

        }
        public DbSet<EventDate> EventDate { get; set; }
        public DbSet<EventXSection> EventXSection { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Responsible> Responsible { get; set; }
        public DbSet<Section> Section { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Entity> Entity { get; set; }
    }
}