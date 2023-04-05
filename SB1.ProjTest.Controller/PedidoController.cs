using SB1.ProjTest.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SB1.ProjTest.Controller
{
   public abstract class PedidoController
    {
        #region Gravar
        public static bool Gravar(Pedido pedido, List<ItemPedido> itemPedido)
        {
            var item = new ItemPedido();
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
                            foreach (var t in itemPedido)
                            {
                                t.idPedido = pedido.idPedido;
                            }
                            if (ItemPedido.Gravar(itemPedido, contexto))
                            {
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

        #region ConsultarListaPedido
        public static BindingSource ConsultarListaPedido()
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        return Pedido.ConsultarListaPedido(contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region Consultar
        public static Pedido Consultar(int id)
        {
            var contexto = new Contexto();
            //variavel recebendo da data base
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        return Pedido.Consultar(id, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultarItemPedido
        public static ItemPedido ConsultarItemPedido(int idItem)
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        return ItemPedido.Consultar(idItem, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultaListaItem
        public static BindingSource ConsultaListaItem(int idPedido)
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        return ItemPedido.ConsultarListaItem(idPedido, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultarPedido
        public static BindingSource ConsultarPedido(int id)
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        //retorna a consulta do método consultar no parceiro de negocio passando o id como parametro
                        return Pedido.ConsultarPedido(id, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultarPedidoParceiro
        public static BindingSource ConsultarPedidoParceiro(int idParceiro, string status, string tipoPedido)
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        //retorna a consulta do método consultar no parceiro de negocio passando o id como parametro
                        return Pedido.ConsultarPedidoParceiro(idParceiro, status, tipoPedido, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ExcluirItemPedido
        public static bool ExcluirItemPedido(ItemPedido itemPedido)
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        if (Pedido.Excluir(itemPedido, contexto))
                        {
                            contexto.SaveChanges();
                            transacao.Commit();

                            return true;
                        }
                    }
                }
                transacao.Rollback();
                return false;
            }
            catch (Exception ex)
            {
                transacao.Rollback();
                throw new Exception(ex.Message);
            }
        }

        public static Pedido ConsultarParceiro(int idParceiro)
        {
            var contexto = new Contexto();
            //variavel recebendo da data base
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        return Pedido.ConsultarParceiro(idParceiro, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultarLista
        public static BindingSource ConsultarLista(string status, string tipoPedido)
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        //retorna a consulta do método consultar no parceiro de negocio passando o id como parametro
                        return Pedido.ConsultarLista(status, tipoPedido, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultarListaPed
        public static BindingSource ConsultarListaPed(string status, string tipoPedido)
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        //retorna a consulta do método consultar no parceiro de negocio passando o id como parametro
                        return Pedido.ConsultarLista(status, tipoPedido, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
