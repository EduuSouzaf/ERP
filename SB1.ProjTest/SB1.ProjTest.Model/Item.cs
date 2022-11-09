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
        public string descircao { get; set; }

        [Column("valorMinimo")]
        public string valorMinimo { get; set; }

        [Column("valorCompra")]
        public string valorCompra { get; set; }

        [Column("valorVenda")]
        public string valorVenda { get; set; }

        [Column("fornecedor")]
        public string fornecedor { get; set; }

        [Column("dataInsercao")]
        public DateTime dataInsercao { get; set; }

        [Column("quantidade")]
        public string quantidade { get; set; }

        [Column("unidadeMedida")]
        public string unidadeMedida { get; set; }

        [Column("categoria")]
        public string categoria { get; set; }

        [Column("ativo")]
        public bool ativo { get; set; }

        //método de gravação
        public bool Gravar (Contexto contexto)
        {
            try
            {
                //fazendo a chamda do método "contexto" 
                contexto.Item.Add(this);
                contexto.Entry(this).State = id > 0 ? EntityState.Modified : EntityState.Added; //if ternario
                contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //mensagem de erro
                throw new Exception(ex.Message);
            }
          
        }
        //Consulta única 
        public static Item Consultar(int id, Contexto contexto)
        {
            try
            {
                //instanciando o objeto
                Item item = new Item();

                item = contexto.Item.Where(consultaItem => consultaItem.id == id).FirstOrDefault();

                return item;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        //várias consultas
        //int? = int que aceita receber valores nulos
        public static BindingSource ConsultarLista (int? id, String nomePesquisa, Contexto contexto)
        {
            try
            {
                BindingSource bsItem = new BindingSource();
                using (contexto)
                {
                    var bindingItem = from Item in contexto.Item
                                          where (Item.id == id || id == null) &&
                                                (Item.nome.Contains(nomePesquisa) || String.IsNullOrEmpty(nomePesquisa))
                                          select Item;

                    bsItem.DataSource = bindingItem.ToList();
                }
                return bsItem;
            }
            catch (Exception ex)
            {

                throw new Exception (ex.Message);
            }
        }

        //excluir
        public bool Excluir (Contexto contexto)
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
    }
}
