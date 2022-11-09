using SB1.ProjTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SB1.ProjTest.Controller
{
    public class ItemController
    {   
        // Metodo de gravacao
        public static bool Gravar(Item item)
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
                        if (item.Gravar(contexto))
                        {
                            //fazendo o commit
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

        //criado o metodo de consulta
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
        //excluir Item
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
    }
}
