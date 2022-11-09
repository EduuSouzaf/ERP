namespace SB1.ProjTest.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ParceiroNegocio",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        tipoDocumento = c.String(),
                        documento = c.String(),
                        telefone = c.String(),
                        eMail = c.String(),
                        parceiroNegocio = c.String(),
                        dataInsercao = c.DateTime(nullable: false),
                        dataAtualizacao = c.DateTime(nullable: false),
                        ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ParceiroNegocio");
        }
    }
}
