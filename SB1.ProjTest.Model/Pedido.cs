using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

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

        [Column("idParceiro")]
        public int idParceiro { get; set; }

        [Column("idEndereco")]
        public int idEndereco { get; set; }

        [Column("tipoPedido")]
        public string tipoPedido { get; set; }

        [Column("dataInsercao")]
        public DateTime dataInsercao { get; set; }

        [Column("dataVencimento")]
        public DateTime dataVencimento { get; set; }

        [Column("status")]
        public string status { get; set; }

        [Column("totalNota")]
        public double totalNota { get; set; }
        #endregion

        #region Gravar
        //método de gravação, e usando a classe contexto como parâmetro
        public bool Gravar(Contexto contexto)
        {
            try
            {
                contexto.Pedido.Add(this);
                contexto.Entry(this).State = idPedido > 0 ? EntityState.Modified : EntityState.Added;

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
        #region Consultar
        public static Pedido Consultar(int id, Contexto contexto)
        {
            try
            {
                Pedido pedido = contexto.Pedido.FirstOrDefault(ped => ped.idPedido == id);
                //parceiro de negocio esta recebendo uma consulta 
                return pedido;
            }

            //tratamento de exeção
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultarListaPedido
        public static BindingSource ConsultarListaPedido(Contexto contexto)
        {
            BindingSource bsConsultarListaPedido = new BindingSource();
            using (contexto)
            {
                var bindingPedido = from pedido in contexto.Pedido
                                    join parceiro in contexto.ParceiroNegocio on pedido.idParceiro equals parceiro.id
                                    select new { parceiro.nome, pedido.idPedido, pedido.totalNota, tipoPedido = pedido.tipoPedido == "PV" ? "Venda" : pedido.tipoPedido == "PC" ? "Compra" : pedido.tipoPedido, pedido.status, pedido.dataVencimento, pedido.dataInsercao };

                bsConsultarListaPedido.DataSource = bindingPedido.ToList();
            }
            return bsConsultarListaPedido;
        }
        #endregion
        #region ConsultarPedido
        public static BindingSource ConsultarPedido(int id, Contexto contexto)
        {
            try
            {



                BindingSource bsConsultarListaPedido = new BindingSource();
                using (contexto)
                {
                    var bindingPedido = from pedido in contexto.Pedido
                                        join parceiro in contexto.ParceiroNegocio on pedido.idParceiro equals parceiro.id
                                        where(pedido.idPedido == id)
                                        select new { parceiro.nome, pedido.idPedido, pedido.totalNota, tipoPedido = pedido.tipoPedido == "PV" ? "Venda" : pedido.tipoPedido == "PC" ? "Compra" : pedido.tipoPedido, pedido.status, pedido.dataVencimento, pedido.dataInsercao };

                    bsConsultarListaPedido.DataSource = bindingPedido.ToList();
                }
                return bsConsultarListaPedido;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region Excluir
        public static bool Excluir(ItemPedido itemPedido, Contexto contexto)
        {
            try
            {
                contexto.ItemPedido.Add(itemPedido);
                contexto.Entry(itemPedido).State = EntityState.Deleted;
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultarLista
        public static BindingSource ConsultarLista(string status, string tipoPedido, Contexto contexto)
        {
            try
            {
                BindingSource bsPedido = new BindingSource();

                using (contexto)
                {
                    var consultaPedido = from pedido in contexto.Pedido
                                         join parceiro in contexto.ParceiroNegocio on pedido.idParceiro equals parceiro.id
                                         where (pedido.tipoPedido == tipoPedido || tipoPedido == null) &&
                                               (pedido.status == status || status == null)
                                         select new { parceiro.nome, pedido.idPedido, pedido.totalNota, tipoPedido = pedido.tipoPedido == "PV" ? "Venda" : pedido.tipoPedido == "PC" ? "Compra" : pedido.tipoPedido, pedido.status, pedido.dataVencimento, pedido.dataInsercao };

                    bsPedido.DataSource = consultaPedido.ToList();

                }
                return bsPedido;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultarListaPed
        public static BindingSource ConsultarListaPed(string status, string tipoPedido, Contexto contexto)
        {
            try
            {
                BindingSource bsPedido = new BindingSource();

                using (contexto)
                {
                    var consultaPedido = from pedido in contexto.Pedido
                                         join parceiro in contexto.ParceiroNegocio on pedido.idParceiro equals parceiro.id
                                         where (pedido.tipoPedido == tipoPedido || tipoPedido == null) &&
                                               (pedido.status == status || status == null)
                                         select new { parceiro.nome, pedido.idPedido, pedido.totalNota, tipoPedido = pedido.tipoPedido == "PV" ? "Venda" : pedido.tipoPedido == "PC" ? "Compra" : pedido.tipoPedido, pedido.status, pedido.dataVencimento, pedido.dataInsercao };

                    bsPedido.DataSource = consultaPedido.ToList();

                }
                return bsPedido;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultarParceiro
        public static Pedido ConsultarParceiro(int idParceiro, Contexto contexto)
        {
            try
            {

                Pedido pedido = contexto.Pedido.FirstOrDefault(ped => ped.idParceiro == idParceiro);
                //parceiro de negocio esta recebendo uma consulta 
                return pedido;
            }

            //tratamento de exeção
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultarLista
        public static BindingSource ConsultarPedidoParceiro(int idParceiro, string status, string tipoPedido, Contexto contexto)
        {
            try
            {
                BindingSource bsPedido = new BindingSource();

                using (contexto)
                {
                    var consultaPedido = from pedido in contexto.Pedido
                                         join parceiro in contexto.ParceiroNegocio on pedido.idParceiro equals parceiro.id
                                         where (pedido.idParceiro == idParceiro || idParceiro == 0) &&
                                               (pedido.status == status || status == null) &&
                                               (pedido.tipoPedido == tipoPedido || tipoPedido == null)
                                         select new { parceiro.nome, pedido.idPedido, pedido.totalNota, tipoPedido = pedido.tipoPedido == "PV" ? "Venda" : pedido.tipoPedido == "PC" ? "Compra" : pedido.tipoPedido, pedido.status, pedido.dataVencimento, pedido.dataInsercao };

                    bsPedido.DataSource = consultaPedido.ToList();

                }
                return bsPedido;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}