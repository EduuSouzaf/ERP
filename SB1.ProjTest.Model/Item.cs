using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        [Column("valorMinimo")]
        public double valorMinimo { get; set; }

        [Column("valorCompra")]
        public double valorCompra { get; set; }

        [Column("valorVenda")]
        public double valorVenda { get; set; }

        [Column("fornecedor")]
        public string fornecedor { get; set; }

        [Column("dataInsercao")]
        public DateTime dataInsercao { get; set; }

        [Column("quantidade")]
        public int quantidade { get; set; }

        [Column("custo")]
        public double custo { get; set; }

        [Column("marca")]
        public string marca { get; set; }

        [Column("unidadeMedida")]
        public string unidadeMedida { get; set; }

        [Column("categoria")]
        public string categoria { get; set; }
        #endregion

        #region Gravar
        //método de gravação, e usando a classe contexto como parâmetro
        public bool Gravar(Contexto contexto)
        {
            try
            {
                //fazendo a chamda do meu item na classe "contexto" 
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
                Item item = new Item();

                //o item, instanciado acima recebe a consulta
                item = contexto.Item.Where(consultaItem => consultaItem.id == id).FirstOrDefault();

                //retorna a consulta que o item recebeu
                return item;
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
        public static BindingSource ConsultarLista(int? id, String nomePesquisa, Contexto contexto)
        {
            try
            {
                //instanciando o objeto de vinculação BindingSource
                BindingSource bsItem = new BindingSource();
                using (contexto)
                {
                    //a variavel bindingItem recebendo a consulta
                    var bindingItem = from Item in contexto.Item
                                          //onde o id do item for igual ao id do parametro
                                      where (Item.id == id || id == null) &&
                                            (Item.nome.Contains(nomePesquisa) || string.IsNullOrEmpty(nomePesquisa))
                                      select Item;

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
        #region ConsultarListaItem
        public static BindingSource ConsultarListaItem(Contexto contexto)
        {
            BindingSource bsConsultarListaItem = new BindingSource();
            using (contexto)
            {
                var bindingItem = from Item in contexto.Item
                                      //  where Item.status == true 
                                  select Item;

                bsConsultarListaItem.DataSource = bindingItem.ToList();
            }
            return bsConsultarListaItem;
        }
        #endregion
        #region ConsultaItemPedido
        public static string ConsultaNomeItemPedido(int id, Contexto contexto)
        {
            try
            {
                //instanciando o objeto
                //Item item = new Item();

                //o item, instanciado acima recebe a consulta
                string item = Convert.ToString(contexto.Item.Where(itemPedido => itemPedido.id == id).FirstOrDefault().nome);

                //retorna a consulta que o item recebeu
                return item;
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
                double item = Convert.ToDouble(contexto.Item.Where(valorPedido => valorPedido.id == id).FirstOrDefault().valorVenda);

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
