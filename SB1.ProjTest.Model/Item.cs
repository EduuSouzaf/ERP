using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SB1.ProjTest.Model
{
    #region tabela
    //criando a minha tabela
    [Table("Item", Schema = "dbo")]
    public class Item
    {
        [Key] // chave primária
        [Column("id")] //define as colunas
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Define que o campo será autoincremento.
        public int id { get; set; } //gravar os dados na coluna

        [Column("nome")]
        public string nome { get; set; }

        [Column("descricao")]
        public string descricao { get; set; }

        [Column("fornecedor")]
        public string fornecedor { get; set; }

        [Column("dataInsercao")]
        public DateTime dataInsercao { get; set; }

        [Column("marca")]
        public string marca { get; set; }

        [Column("unidadeMedida")]
        public string unidadeMedida { get; set; }

        [Column("codCategoria")]
        public string codCategoria { get; set; }
        #endregion

        #region Gravar
        //método de gravação, e usando a classe contexto como parâmetro
        public bool Gravar(Contexto contexto)
        {
            try
            { 
                contexto.Item.Add(this);
                //se id > 0 modifica, se não adiciona
                contexto.Entry(this).State = id > 0 ? EntityState.Modified : EntityState.Added; //if ternario
                //salva as alterações
                contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //mensagem de erro
                throw new Exception(ex.Message);
            }

        }
        #endregion
        //Consulta única
        #region Consultar
        public static Item Consultar(int id, Contexto contexto)
        {
            try
            {
                //instanciando o objeto
                Item item = contexto.Item.FirstOrDefault(consultaItem => consultaItem.id == id);

                //retorna a consulta que o item recebeu
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static int ConsultarIdItem(Contexto contexto)
        {
            try
            {
                var ultimoItem = contexto.Item.OrderByDescending(x => x.id).FirstOrDefault();
                int proximoId;

                if (ultimoItem == null)
                {
                    // não há registros na tabela ainda
                    // o próximo identificador será 1
                    proximoId = 1;
                }
                else
                {
                    proximoId = ultimoItem.id + 1;
                    // o próximo identificador será o valor do último registro + 1
                }
                return proximoId;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        //várias consultas
        //int? = int que aceita receber valores nulos
        #region ConsultarLista
        public static BindingSource ConsultarLista(int? id, string nomePesquisa, Contexto contexto)
        {
            try
            {
                //instanciando o objeto de vinculação BindingSource
                BindingSource bsItem = new BindingSource();
                using (contexto)
                {
                    //a variavel bindingItem recebendo a consulta
                    var bindingItem = from item in contexto.Item
                                      join estoque in contexto.MovimentoEstoque on item.id equals estoque.idItem
                                      join preco in contexto.TabelaPreco on item.id equals preco.idItem
                                      join categoria in contexto.Categoria on item.codCategoria equals categoria.codigo
                                      where (item.id == id || id == null) &&
                                            (item.nome.Contains(nomePesquisa) || nomePesquisa == null)
                                      select new { item.id, item.nome, categoria.categoria, preco.precoCusto, preco.precoVenda, estoque.quantidade, estoque.totalEstoque, estoque.totalEstoqueVenda};

                    bsItem.DataSource = bindingItem.ToList();
                }
                return bsItem;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultarEstoque
        public static BindingSource ConsultarEstoque(int? id, string nomePesquisa, string categoriaCod, string marcaCod, Contexto contexto)
        {
            try
            {
                //instanciando o objeto de vinculação BindingSource
                BindingSource bsItem = new BindingSource();
                using (contexto)
                {
                    //a variavel bindingItem recebendo a consulta
                    var bindingItem = from item in contexto.Item
                        join estoque in contexto.MovimentoEstoque on item.id equals estoque.idItem
                        join preco in contexto.TabelaPreco on item.id equals preco.idItem
                        join categoria in contexto.Categoria on item.codCategoria equals categoria.codigo
                        join marca in contexto.Marca on item.marca equals marca.codigo
                        where (item.id == id || id == null) &&
                              (item.nome.Contains(nomePesquisa) || string.IsNullOrEmpty(nomePesquisa)) &&
                              (categoria.codigo.Contains(categoriaCod) || string.IsNullOrEmpty(categoriaCod)) &&
                              (marca.codigo.Contains(marcaCod) || string.IsNullOrEmpty(marcaCod))
                        select new { item.id, item.nome, categoria.categoria, marca.marca, preco.precoCusto, preco.precoVenda, estoque.unidadesVendidas, estoque.quantidade, estoque.totalEstoque, estoque.totalEstoqueVenda };

                    bsItem.DataSource = bindingItem.ToList();
                }
                return bsItem;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultaNomeItemPedido
        public static string ConsultaNomeItemPedido(int id, Contexto contexto)
        {
            try
            {
                //o item, instanciado acima recebe a consulta
                string item = Convert.ToString(contexto.Item.FirstOrDefault(itemPedido => itemPedido.id == id)?.nome);

                //retorna a consulta que o item recebeu
                return item;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        public static int ConsultaIdItemPedido(int id, Contexto contexto)
        {
            try
            {
                int item = Convert.ToInt32(contexto.MovimentoEstoque.FirstOrDefault(estoque => estoque.idItem == id)?.id);

                return item;
                //retorna a consulta que o item recebeu
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #region verificaIdItem
        public static int VerificaIdItem(int id, Contexto contexto)
        {
            try
            {
                int item = Convert.ToInt32(contexto.Item.FirstOrDefault(verifItem => verifItem.id == id)?.id);

                return item;
                //retorna a consulta que o item recebeu
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultaPrecoItemPedido
        public static double ConsultaPrecoItemPedido(int id, Contexto contexto)
        {
            try
            {
                //instanciando o objeto
                //Item item = new Item();

                //o item, instanciado acima recebe a consulta
                double item = Convert.ToDouble(contexto.Item.FirstOrDefault(valorPedido => valorPedido.id == id));

                //retorna a consulta que o item recebeu
                return item;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        //excluir
        #region Excluir
        public bool Excluir(Contexto contexto)
        {
            try
            {
                contexto.Item.Add(this);
                contexto.Entry(this).State = EntityState.Deleted;

                return true;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        public static implicit operator Item(BindingSource v)
        {
            throw new NotImplementedException();
        }
    }
}
