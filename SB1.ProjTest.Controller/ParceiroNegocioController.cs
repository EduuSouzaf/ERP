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
        #region Gravar
        public static bool Gravar(ParceiroNegocio parceiro, List<Endereco> endereco)
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
                            for (int i = 0; i < endereco.Count; i++)
                            {
                                endereco[i].idParceiroNegocio = parceiro.id;
                            }

                            //chamando o método Gravar do endereco
                            if (Endereco.Gravar(endereco, contexto))
                            {
                                //para adicionar algo no banco é necessário fazer o commit
                                transacao.Commit();
                                return true;
                            }
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
        //método de consultar 
        #region Consultar
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
                        //retorna a consulta do método consultar no parceiro de negocio passando o id como parametro
                        return ParceiroNegocio.Consultar(id, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region RetornaParceiro
        public static string RetornaParceiro(int id)
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
                        return ParceiroNegocio.ConsultaNomeParceiro(id, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        //Consulta em lista
        #region ConsultarLista
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
                        //retorna a consulta do método consultar no parceiro de negocio passando o id como parametro
                        return ParceiroNegocio.ConsultarLista(id, nomePesquisa, contexto);
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
        public static BindingSource ConsultarLista(int? idParceiro)
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        return Endereco.ConsultarLista(idParceiro, contexto);
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
        public static BindingSource ConsultarListaParceiro()
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        return ParceiroNegocio.ConsultarListaParceiro(contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region Excluir
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
                        //fez a chamado do objeto parceiro, passado como parâmetro no método
                        if (parceiro.Excluir(contexto))
                        {
                            //salvar
                            contexto.SaveChanges();
                            //para salvar no banco é necessário commitar
                            transacao.Commit();
                            return true;
                        }
                    }
                }
                //Se der erro apaga as alterações, para não ficar informações pela metade
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

        #region ExcluirEndereco
        public static bool ExcluirEndereco(Endereco endereco)
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        if (Endereco.Excluir(endereco, contexto))
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
        #region ConsultarEndereco(int? idParceiro)
        public static BindingSource ConsultarEndereco(int? idParceiro)
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        return Endereco.ConsultarLista(idParceiro, contexto);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultarEndereco(int idEndereco, int idParceiro)
        public static Endereco ConsultarEndereco(int idEndereco, int idParceiro)
        {
            var contexto = new Contexto();
            var transacao = contexto.Database.BeginTransaction();

            try
            {
                using (contexto)
                {
                    using (transacao)
                    {
                        return Endereco.Consultar(idEndereco, idParceiro, contexto);
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
