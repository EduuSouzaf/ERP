namespace SB1.ProjTest.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        codigo = c.String(nullable: false, maxLength: 128),
                        categoria = c.String(),
                        descricao = c.String(),
                        status = c.Boolean(nullable: false),
                        dataInsercao = c.DateTime(nullable: false),
                        dataAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.codigo);
            
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        idEndereco = c.Int(nullable: false, identity: true),
                        idParceiroNegocio = c.Int(nullable: false),
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
            
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        descricao = c.String(),
                        fornecedor = c.String(),
                        dataInsercao = c.DateTime(nullable: false),
                        marca = c.String(),
                        unidadeMedida = c.String(),
                        codCategoria = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ItemPedido",
                c => new
                    {
                        idPedido = c.Int(nullable: false),
                        idItemPedido = c.Int(nullable: false, identity: true),
                        idItem = c.Int(nullable: false),
                        nome = c.String(),
                        quantidade = c.Int(nullable: false),
                        valorUnitario = c.Double(nullable: false),
                        valorTotal = c.Double(nullable: false),
                        status = c.Boolean(nullable: false),
                        dataInsercao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.idItemPedido);
            
            CreateTable(
                "dbo.Marca",
                c => new
                    {
                        codigo = c.String(nullable: false, maxLength: 128),
                        marca = c.String(),
                        descricao = c.String(),
                        status = c.Boolean(nullable: false),
                        dataInsercao = c.DateTime(nullable: false),
                        dataAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.codigo);
            
            CreateTable(
                "dbo.MovimentoEstoque",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        idItem = c.Int(nullable: false),
                        quantidade = c.Int(nullable: false),
                        totalEstoque = c.Double(nullable: false),
                        totalEstoqueVenda = c.Double(nullable: false),
                        LucroEstoque = c.Double(nullable: false),
                        dataInsercao = c.DateTime(nullable: false),
                        dataAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
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
            
            CreateTable(
                "dbo.Pedido",
                c => new
                    {
                        idPedido = c.Int(nullable: false, identity: true),
                        idParceiro = c.Int(nullable: false),
                        idEndereco = c.Int(nullable: false),
                        tipoPedido = c.String(),
                        dataInsercao = c.DateTime(nullable: false),
                        dataVencimento = c.DateTime(nullable: false),
                        status = c.String(),
                        totalNota = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.idPedido);
            
            CreateTable(
                "dbo.TabelaPreco",
                c => new
                    {
                        idTabelaPreco = c.Int(nullable: false, identity: true),
                        idItem = c.Int(nullable: false),
                        precoCusto = c.Double(nullable: false),
                        precoMinimo = c.Double(nullable: false),
                        precoVenda = c.Double(nullable: false),
                        margemLucro = c.Double(nullable: false),
                        lucroTotal = c.Double(nullable: false),
                        unidadesVendidas = c.Int(nullable: false),
                        dataAtualizacao = c.DateTime(nullable: false),
                        dataInsercao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.idTabelaPreco);
            
            CreateTable(
                "dbo.UnidadeMedida",
                c => new
                    {
                        codigo = c.String(nullable: false, maxLength: 128),
                        unidadeMedida = c.String(),
                        descricao = c.String(),
                        status = c.Boolean(nullable: false),
                        dataInsercao = c.DateTime(nullable: false),
                        dataAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.codigo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UnidadeMedida");
            DropTable("dbo.TabelaPreco");
            DropTable("dbo.Pedido");
            DropTable("dbo.ParceiroNegocio");
            DropTable("dbo.MovimentoEstoque");
            DropTable("dbo.Marca");
            DropTable("dbo.ItemPedido");
            DropTable("dbo.Item");
            DropTable("dbo.Endereco");
            DropTable("dbo.Categoria");
        }
    }
}
