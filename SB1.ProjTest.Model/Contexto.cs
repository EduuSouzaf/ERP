using System.Data.Entity;

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

        public DbSet<MovimentoEstoque> MovimentoEstoque { get; set; }

        public DbSet<TabelaPreco> TabelaPreco { get; set; }

        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<UnidadeMedida> UnidadeMedida { get; set; }

        public DbSet<Marca> Marca { get; set; }
    }
}
