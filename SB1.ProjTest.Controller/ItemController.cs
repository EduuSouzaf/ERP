using SB1.ProjTest.Model;
using System;
using System.Windows.Forms;

namespace SB1.ProjTest.Controller
{
    public class ItemController
    {
        // Metodo de gravacao
        #region Métodos Públicos

        // Grava um Item com Movimento de Estoque e Tabela de Preço no banco de dados
        public static bool Gravar(Item item, MovimentoEstoque estoque, TabelaPreco preco)
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction(); // Inicia uma transação no banco de dados

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        // Grava o Item no banco de dados
                        if (item.Gravar(contexto))
                        {
                            // Grava o Movimento de Estoque no banco de dados
                            if (estoque.Gravar(estoque, contexto))
                            {
                                // Grava a Tabela de Preço no banco de dados
                                if (preco.Gravar(preco, contexto))
                                {
                                    // Confirma as alterações no banco de dados
                                    transacao.Commit();
                                    return true;
                                }
                            }
                        }
                    }
                }

                // Faz o rollback da transação em caso de erro
                transacao.Rollback();
                return false;
            }
            catch (Exception ex)
            {
                // Faz o rollback da transação e lança uma exceção em caso de erro
                transacao.Rollback();
                throw new Exception("Erro ao gravar o Item com Movimento de Estoque e Tabela de Preço: " + ex.Message);
            }
        }

        #endregion
        #region ConsultarIdItem
        public static int ConsultarIdItem()
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
                        //retorna a "id" e o contexto
                        return Item.ConsultarIdItem(contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        //criado o metodo de consulta
        #region Consultar
        public static Item Consultar(int id)
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
                        //retorna a "id" e o contexto
                        return Item.Consultar(id, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region RetornaItem
        public static string RetornaIdItem(int id)
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
                        //retorna a "id" e o contexto
                        return Item.ConsultaNomeItemPedido(id, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region RetornaIdItem
        public static int RetornaIdMovimento(int id)
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
                        //retorna a "id" e o contexto
                        return Item.ConsultaIdItemPedido(id, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region verificaIdItem
        public static int VerificaIdItem(int id)
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
                        //retorna a "id" e o contexto
                        return Item.VerificaIdItem(id, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region RetornaPreco
        public static double RetornaPreco(int id)
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
                        //retorna a "id" e o contexto
                        return Item.ConsultaPrecoItemPedido(id, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region Consultarlista
        public static BindingSource Consultarlista(int? id, string nomePesquisa)
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        return Item.ConsultarLista(id, nomePesquisa, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region Consultarlista
        public static BindingSource ConsultarEstoque(int? id, string nomePesquisa, string categoria, string marca)
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        return Item.ConsultarEstoque(id, nomePesquisa, categoria, marca, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultarItem
        public static BindingSource ConsultarLista(int? id, string nome)
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        return Item.ConsultarLista(id, nome, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        //excluir Item
        #region Excluir
        public static bool Excluir(Item item)
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        if (item.Excluir(contexto))
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
        #endregion
    }
}
