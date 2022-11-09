namespace SB1.ProjTest.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Endereco", "idParceiroNegocio", c => c.Int(nullable: false));
            DropColumn("dbo.Endereco", "idParceiro");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Endereco", "idParceiro", c => c.String());
            DropColumn("dbo.Endereco", "idParceiroNegocio");
        }
    }
}
