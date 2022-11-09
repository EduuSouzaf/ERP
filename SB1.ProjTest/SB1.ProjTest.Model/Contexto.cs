using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB1.ProjTest.Model
{
    public class Contexto : DbContext
    {
        public Contexto() : base("SqlServerConnection") { }

        public DbSet<ParceiroNegocio> ParceiroNegocio { get; set; }

        public DbSet<Item> Item { get; set; }

    }
}
