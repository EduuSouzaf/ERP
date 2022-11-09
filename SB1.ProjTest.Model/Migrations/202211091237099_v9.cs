namespace SB1.ProjTest.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v9 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemPedido",
                c => new
                    {
                        idItemPedido = c.Int(nullable: false, identity: true),
                        idPedido = c.Int(nullable: false),
                        nome = c.String(),
                        quantidade = c.Int(nullable: false),
                        valorUnitario = c.Double(nullable: false),
                        valorTotal = c.Double(nullable: false),
                        status = c.Boolean(nullable: false),
                        dataInsercao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.idItemPedido);
            
            AddColumn("dbo.Pedido", "idEndereco", c => c.Int(nullable: false));
            AlterColumn("dbo.Pedido", "status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pedido", "status", c => c.String());
            DropColumn("dbo.Pedido", "idEndereco");
            DropTable("dbo.ItemPedido");
        }
    }
}
