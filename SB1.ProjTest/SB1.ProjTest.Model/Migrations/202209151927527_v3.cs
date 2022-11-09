namespace SB1.ProjTest.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Item", "valorMinimo", c => c.String());
            AddColumn("dbo.Item", "valorCompra", c => c.String());
            AddColumn("dbo.Item", "valorVenda", c => c.String());
            AddColumn("dbo.Item", "fornecedor", c => c.String());
            AddColumn("dbo.Item", "quantidade", c => c.String());
            AddColumn("dbo.Item", "unidadeMedida", c => c.String());
            AddColumn("dbo.Item", "categoria", c => c.String());
            AlterColumn("dbo.Item", "ativo", c => c.Boolean(nullable: false));
            DropColumn("dbo.Item", "observacao");
            DropColumn("dbo.Item", "precoMinimo");
            DropColumn("dbo.Item", "preco");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Item", "preco", c => c.String());
            AddColumn("dbo.Item", "precoMinimo", c => c.String());
            AddColumn("dbo.Item", "observacao", c => c.String());
            AlterColumn("dbo.Item", "ativo", c => c.String());
            DropColumn("dbo.Item", "categoria");
            DropColumn("dbo.Item", "unidadeMedida");
            DropColumn("dbo.Item", "quantidade");
            DropColumn("dbo.Item", "fornecedor");
            DropColumn("dbo.Item", "valorVenda");
            DropColumn("dbo.Item", "valorCompra");
            DropColumn("dbo.Item", "valorMinimo");
        }
    }
}
