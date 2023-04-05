using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SB1.ProjTest.Model
{
    #region Tabela
    [Table("ItemPedido", Schema = "dbo")]
    public class ItemPedido
    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idItemPedido { get; set; }

        [Column(Order = 0)]
        public int idPedido { get; set; }

        [Column(Order = 2)]
        public int idItem { get; set; }

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
                for (int i = 0; i < itemPedido.Count; i++)
                {
                    contexto.ItemPedido.Add(itemPedido[i]);

                    if (itemPedido[i].idItemPedido > 0)
                    {
                        contexto.Entry(itemPedido[i]).State = EntityState.Modified;
                        //salvando
                        contexto.SaveChanges();
                    }
                    else
                    {
                        int maxId = 0;
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
                        itemPedido[i].idItemPedido = maxId + 1;
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
        #region Consultar
        public static ItemPedido Consultar(int idItem, Contexto contexto)
        {
            try
            {
                ItemPedido itemPedido = contexto.ItemPedido.FirstOrDefault(itemPed => itemPed.idItem == idItem);

                return itemPedido;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultarListaItem
        public static BindingSource ConsultarListaItem(int idPedido, Contexto contexto)
        {
            try
            {
                BindingSource bsItem = new BindingSource();
                using (contexto)
                {
                    var consultarItem = from item in contexto.ItemPedido
                                        where (item.idPedido == idPedido)
                                        select new { item.nome, item.idItem, item.quantidade, item.valorUnitario, item.valorTotal, item.status };

                    bsItem.DataSource = consultarItem.ToList();
                }
                return bsItem;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
