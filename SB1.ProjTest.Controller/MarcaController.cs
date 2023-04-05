using SB1.ProjTest.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SB1.ProjTest.Controller
{
    public class MarcaController
    {
        #region Gravar
        public static bool Gravar(List<Marca> marca)
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
                        if (Marca.Gravar(marca, contexto))
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
                        return Marca.Consultar(codigo, contexto);
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
