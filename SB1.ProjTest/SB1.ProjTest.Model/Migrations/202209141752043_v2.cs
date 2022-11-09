namespace SB1.ProjTest.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        descricao = c.String(),
                        observacao = c.String(),
                        precoMinimo = c.String(),
                        preco = c.String(),
                        dataInsercao = c.DateTime(nullable: false),
                        ativo = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Item");
        }
    }
}
