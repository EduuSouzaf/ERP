using SB1.ProjTest.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SB1.ProjTest.Controller
{
    public class UnidadeMedidaController
    {
        #region Gravar
        public static bool Gravar(List<UnidadeMedida> medida)
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
                        if (UnidadeMedida.Gravar(medida, contexto))
                        {
                            //para adicionar algo no banco é necessário fazer o commit
                            transacao.Commit();
                            return true;
                        }
                    }
                }
                //Rollback
                transacao.Rollback();
                return true;
            }
            //exception com o Rollback
            catch (Exception ex)
            {
                transacao.Rollback();
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region Consultar
        //Retorna uma lista das categorias adicionadas
        public static BindingSource Consultar(string codigo)
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        return UnidadeMedida.Consultar(codigo, contexto);
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
