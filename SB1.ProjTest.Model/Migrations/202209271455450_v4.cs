namespace SB1.ProjTest.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        idEndereco = c.Int(nullable: false, identity: true),
                        idParceiro = c.String(),
                        logradouro = c.String(),
                        numero = c.Int(nullable: false),
                        bairro = c.String(),
                        cidade = c.String(),
                        estado = c.String(),
                        cep = c.String(),
                        complemento = c.String(),
                        dataInsercao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.idEndereco);
            
            AddColumn("dbo.Item", "marca", c => c.String());
            AlterColumn("dbo.Item", "valorMinimo", c => c.Double(nullable: false));
            AlterColumn("dbo.Item", "valorCompra", c => c.Double(nullable: false));
            AlterColumn("dbo.Item", "valorVenda", c => c.Double(nullable: false));
            AlterColumn("dbo.Item", "quantidade", c => c.Int(nullable: false));
            DropColumn("dbo.Item", "ativo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Item", "ativo", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Item", "quantidade", c => c.String());
            AlterColumn("dbo.Item", "valorVenda", c => c.String());
            AlterColumn("dbo.Item", "valorCompra", c => c.String());
            AlterColumn("dbo.Item", "valorMinimo", c => c.String());
            DropColumn("dbo.Item", "marca");
            DropTable("dbo.Endereco");
        }
    }
}
