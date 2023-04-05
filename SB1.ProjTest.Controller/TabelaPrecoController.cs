using SB1.ProjTest.Model;
using System;
using System.Data.Entity;

namespace SB1.ProjTest.Controller
{
    public class TabelaPrecoController
    {
        public static bool Gravar(TabelaPreco preco)
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
                        if (preco.Gravar(preco, contexto))
                        {
                            transacao.Commit();
                            return true;
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
                throw new Exception( ex.Message);
            }
        }
        #region Consultar
        public static TabelaPreco Consultar(int id)
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
                        return TabelaPreco.Consultar(id, contexto);
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
        public static int ConsultarId(int id)
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
                        return TabelaPreco.ConsultarId(id, contexto);
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
        public static double ConsultarPrecoCusto(int id)
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
                        return TabelaPreco.ConsultarPrecoCusto(id, contexto);
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
        public static double ConsultarPrecoVenda(int id)
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
                        return TabelaPreco.ConsultarPrecoVenda(id, contexto);
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
