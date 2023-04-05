namespace SB1.ProjTest.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MovimentoEstoque", "unidadesVendidas", c => c.Int(nullable: false));
            DropColumn("dbo.TabelaPreco", "unidadesVendidas");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TabelaPreco", "unidadesVendidas", c => c.Int(nullable: false));
            DropColumn("dbo.MovimentoEstoque", "unidadesVendidas");
        }
    }
}
