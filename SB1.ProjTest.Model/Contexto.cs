using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB1.ProjTest.Model
{
    //método de contexto, que faz a conexão com o banco, para alterações no mesmo
    public class Contexto : DbContext
    {
        public Contexto() : base("SqlServerConnection") { }

        public DbSet<ParceiroNegocio> ParceiroNegocio { get; set; }

        public DbSet<Endereco> Endereco { get; set; }

        public DbSet<Item> Item { get; set; }

        public DbSet<ItemPedido> ItemPedido { get; set; }

        public DbSet<Pedido> Pedido { get; set; }

    }
}
