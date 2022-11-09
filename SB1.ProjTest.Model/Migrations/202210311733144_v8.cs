namespace SB1.ProjTest.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v8 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pedido",
                c => new
                    {
                        idPedido = c.Int(nullable: false, identity: true),
                        idItem = c.Int(nullable: false),
                        idParceiro = c.Int(nullable: false),
                        tipoPedido = c.String(),
                        status = c.String(),
                        dataInsercao = c.DateTime(nullable: false),
                        dataVencimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.idPedido);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pedido");
        }
    }
}
