using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB1.ProjTest.Model
{
    //Tabela
    #region Tabela
    [Table("Pedido", Schema = "dbo")]
    public class Pedido
    {
        [Key]
        [Column("idPedido")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idPedido { get; set; }

        [Column("idItem")]
        public int idItem { get; set; }

        [Column("idParceiro")]
        public int idParceiro { get; set; }

        [Column("idEndereco")]
        public int idEndereco { get; set; }

        [Column("tipoPedido")]
        public string tipoPedido { get; set; }

        [Column("status")]
        public bool status { get; set; }

        [Column("dataInsercao")]
        public DateTime dataInsercao { get; set; }

        [Column("dataVencimento")]
        public string dataVencimento { get; set; }
        #endregion

        #region Gravar
        //método de gravação, e usando a classe contexto como parâmetro
        public bool Gravar(Contexto contexto)
        {
            try
            {
                //fazendo a chamda do meu item na classe "contexto" 
                contexto.Pedido.Add(this);
                //se id > 0 modifica, se não adiciona
                contexto.Entry(this).State = idPedido > 0 ? EntityState.Modified : EntityState.Added; //if ternario
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
    }
}
