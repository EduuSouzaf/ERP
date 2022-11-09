using SB1.ProjTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SB1.ProjTest.Controller
{
    public class ParceiroNegocioController
    {
        //metodo de gravacao
        //vai fazer a garavacao do parceiro
        public static bool Gravar(ParceiroNegocio parceiro)
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
                        if (parceiro.Gravar(contexto))
                        {
                            //commit
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

        public static ParceiroNegocio Consultar(int id)
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
                        return ParceiroNegocio.Consultar(id, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public static BindingSource ConsultarLista(int? id, string nomePesquisa)
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        return ParceiroNegocio.ConsultarLista(id, nomePesquisa, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        //excluir "parceiroNegocio"
        public static bool Excluir(ParceiroNegocio parceiro)  //parceiro do tipo: ParceiroNegocio
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        if (parceiro.Excluir(contexto))
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
    }
}
