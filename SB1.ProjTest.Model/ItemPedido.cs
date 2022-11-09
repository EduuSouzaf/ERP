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
    #region Tabela
    [Table("ItemPedido", Schema = "dbo")]
    public class ItemPedido
    {
        [Key]
        [Column("idItemPedido")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idItemPedido { get; set; }

        [Column("idPedido")]
        public int idPedido { get; set; }

        [Column("nome")]
        public string nome { get; set; }

        [Column("quantidade")]
        public int quantidade { get; set; }

        [Column("valorUnitario")]
        public double valorUnitario { get; set; }

        [Column("valorTotal")]
        public double valorTotal { get; set; }

        [Column("status")]
        public bool status { get; set; }

        [Column("dataInsercao")]
        public DateTime dataInsercao { get; set; }
        #endregion
        #region Gravar
        public static bool Gravar(List<ItemPedido> itemPedido, Contexto contexto)
        {
            try
            {
                //i se refere a linha do for no list
                for (int i = 0; i < itemPedido.Count; i++)
                {
                    //esta adicionando no objeto endereco da contexto
                    contexto.ItemPedido.Add(itemPedido[i]);

                    //quando o id do endereco no grid for mair que 0, vai atualizar
                    if (itemPedido[i].idItemPedido > 0)
                    {
                        //está atualizando os dados do objeto endereco
                        contexto.Entry(itemPedido[i]).State = EntityState.Modified;
                        //salvando
                        contexto.SaveChanges();
                    }
                    else
                    {
                        int maxId = 0;
                        //estrutura de repetição para a quantidade de endereços que podem ser adicionados
                        //para isso ele percorre toda a minha list de endereco
                        for (int j = 0; j < itemPedido.Count; j++)
                        {
                            //se for o primeiro a ser adicionado
                            if (j == 0)
                            {
                                //a minha variavel vai receber o id do endereco
                                maxId = itemPedido[j].idItemPedido;
                            }
                            else
                            {
                                if (itemPedido[j].idItemPedido > maxId)
                                {
                                    //caso não seje o primeiro ele vai receber o id do endereco
                                    maxId = itemPedido[j].idItemPedido;
                                }
                            }
                        }
                        //o meu idENdereco vai recebere o valor que o maxId recebeu + 1
                        itemPedido[i].idItemPedido = maxId + 1;
                        //aqui estou adicioanando o endereco
                        contexto.Entry(itemPedido[i]).State = EntityState.Added;
                        contexto.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultarLista
        //método de consulta em lista, passando como parametro um int?, e a classe contexto
        //public static BindingSource ConsultarLista(int? idPedido, Contexto contexto)
        //{
        //    try
        //    {
        //        //variavel BindingSource
        //        BindingSource bdItemPedido = new BindingSource();
        //        using (contexto)
        //        //{
        //        //    //consulta para puxar todos os dados da tabela endereco
        //        //    var bindingBsItemPedido = from ender in contexto.Endereco
        //        //                            where ender.idParceiroNegocio == idParceiro
        //        //                            select ender;
        //        //    bsEndereco.DataSource = bindingbsEndereco.ToList();
        //        //    return bsEndereco;
        //        //}
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        #endregion
    }
}
