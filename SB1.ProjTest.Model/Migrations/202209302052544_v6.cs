namespace SB1.ProjTest.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Item", "custo", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Item", "custo");
        }
    }
}
