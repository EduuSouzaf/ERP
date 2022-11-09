namespace SB1.ProjTest.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ParceiroNegocio", "parceiroNegocio", c => c.String());
            DropColumn("dbo.Item", "status");
            DropColumn("dbo.ParceiroNegocio", "tipoParceiro");
            DropTable("dbo.Categoria");
            DropTable("dbo.Pedido");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Pedido",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tipoPedido = c.String(),
                        status = c.String(),
                        parceiro = c.String(),
                        endereco = c.String(),
                        dataInsercao = c.DateTime(nullable: false),
                        dataVencimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        dataInsercao = c.DateTime(nullable: false),
                        dataAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.ParceiroNegocio", "tipoParceiro", c => c.String());
            AddColumn("dbo.Item", "status", c => c.Boolean(nullable: false));
            DropColumn("dbo.ParceiroNegocio", "parceiroNegocio");
        }
    }
}
