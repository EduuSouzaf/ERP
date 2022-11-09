using SB1.ProjTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB1.ProjTest.Controller
{
   public class PedidoController
    {
        #region Gravar
        public static bool Gravar(Pedido pedido, List<ItemPedido> itemPedido)
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        if (pedido.Gravar(contexto))
                        {
                            for (int i = 0; i < itemPedido.Count; i++)
                            {
                                itemPedido[i].idPedido = pedido.idItem;
                            }

                            //chamando o método Gravar do endereco
                            if (ItemPedido.Gravar(itemPedido, contexto))
                            {
                                //para adicionar algo no banco é necessário fazer o commit
                                transacao.Commit();
                                return true;
                            }
                        }
                    }
                }
                transacao.Rollback();
                return true;
            }
            catch (Exception ex)
            {
                transacao.Rollback();
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
