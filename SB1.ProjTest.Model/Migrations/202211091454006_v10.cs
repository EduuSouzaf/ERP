namespace SB1.ProjTest.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v10 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pedido", "dataVencimento", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pedido", "dataVencimento", c => c.DateTime(nullable: false));
        }
    }
}
