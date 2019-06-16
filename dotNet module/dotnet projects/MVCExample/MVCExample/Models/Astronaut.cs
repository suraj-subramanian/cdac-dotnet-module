using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCExample.Models
{
    public class Astronaut
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Destination { set; get; }
    }

    public class AstronautDbContext : DbContext
    {
        public DbSet<Astronaut> Astronauts { set; get; }

    }
}