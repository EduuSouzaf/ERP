using SB1.ProjTest.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SB1.ProjTest.Controller
{
    public class MovimentoEstoqueController
    {
        #region Gravar
        public static bool Gravar(MovimentoEstoque estoque)
        {
            var contexto = new Contexto();
            //"BeginTransaction" método para inserir no banco
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        if (estoque.Gravar(estoque, contexto))
                        {
                            transacao.Commit();
                            return true;
                        }
                    }
                }
                //faz o "RollBack"
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
        // controller
        #region Gravar
        public static bool GravarList(List<MovimentoEstoque> estoques)
        {
            var contexto = new Contexto();
            //"BeginTransaction" método para inserir no banco
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        foreach (var estoque in estoques)
                        {
                            if (MovimentoEstoque.GravarList(estoque, contexto))
                            {
                                // transação deve ser commitada fora do loop
                            }
                        }

                        // commit após o término da iteração
                        transacao.Commit();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                transacao.Rollback();
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultarEstoque
        public static MovimentoEstoque Consultar(int id)
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
                        return MovimentoEstoque.Consultar(id, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region ConsultarTotalEstoqueVenda
        public static Double ConsultarTotalEstoqueVenda(int id)
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
                        return MovimentoEstoque.ConsultarTotalEstoqueVenda(id, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultarTotalEstoque
        public static double ConsultarTotalEstoque(int id)
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
                        return MovimentoEstoque.ConsultarTotalEstoque(id, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultaEstoque
        public static int ConsultarEstoque(int idItem)
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        return MovimentoEstoque.ConsultarEstoque(idItem, contexto);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultaEstoque
        public static int ConsultarUnidadesVendidas(int idItem)
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        return MovimentoEstoque.ConsultarUnidadesVendidas(idItem, contexto);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultarQuantidadeEstoqe
        public static BindingSource ConsultarQuantidadeEstoque(int? id)
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        return MovimentoEstoque.ConsultarLista(id, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        //excluir
        #region ExcluirQuantidade
        public static bool ExcluirQuantidade(MovimentoEstoque movimentoEstoque)
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        if (movimentoEstoque.Excluir(contexto))
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
