using parola.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parola.Database.Concrete.EntityFramework
{
    public class ParolaContext : DbContext
    {
        public DbSet<Parola> parola { get; set; }

    }
}

