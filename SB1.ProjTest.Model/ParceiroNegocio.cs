using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SB1.ProjTest.Model
{
    #region Tabela
    //criando a minha tabela de Parceiro
    [Table("ParceiroNegocio", Schema = "dbo")]

    public class ParceiroNegocio
    {
        //Criando as minhas variaveis, definindo os meus métodos Getters e Setters
        // e definindo que o meu id é uma chave primaria, atravé do me´todo "[Key]"
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Define que o campo será autoincremento.
        public int id { get; set; }

        //declaracao das variavel, criacao dos campos da tabela e metodos "Get" e "Set"
        [Column("nome")]
        public String nome { get; set; }

        [Column("tipoDocumento")]
        public String tipoDocumento { get; set; }

        [Column("documento")]
        public String documento { get; set; }

        [Column("telefone")]
        public String telefone { get; set; }

        [Column("eMail")]
        public String eMail { get; set; }

        [Column("parceiroNegocio")]
        public String parceiroNegocio { get; set; }

        //Criando variáveis do tipo "DataTime"
        [Column("dataInsercao")]
        public DateTime dataInsercao { get; set; }

        [Column("dataAtualizacao")]
        public DateTime dataAtualizacao { get; set; }

        [Column("ativo")]
        public bool ativo { get; set; }
        #endregion

        //método de gravação
        #region Gravar
        public bool Gravar(Contexto contexto)
        {
            try
            {
                contexto.ParceiroNegocio.Add(this);

                contexto.Entry(this).State = id > 0 ? EntityState.Modified : EntityState.Added;
                contexto.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion
    #region ConsultarListaParceiro
    public static BindingSource ConsultarListaParceiro(Contexto contexto)
        {
            BindingSource bsConsultarListaParceiro = new BindingSource();
            using (contexto)
            {
                var bindingParceiro = from parceiro in contexto.ParceiroNegocio
                                          //  where Item.status == true 
                                      select parceiro;

                bsConsultarListaParceiro.DataSource = bindingParceiro.ToList();
            }
            return bsConsultarListaParceiro;
        }
        #endregion
        //método de consulta unica
        //e estou passando como parâmetro a minha classe Contexto e um int nomeado com "id"
        #region Consultar
        public static ParceiroNegocio Consultar(int id, Contexto contexto)
        {
            try
            {
                //instanciando o objeto
                ParceiroNegocio parceiroNegocio =  contexto.ParceiroNegocio.FirstOrDefault(parcNegocio => parcNegocio.id == id);
                //parceiro de negocio esta recebendo uma consulta 
                return parceiroNegocio;
            }
            //tratamento de exeção
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultarLista
        //metodo de consultar uma lista de parceiros de negocio e passando como parãmetro duas variaveis
        public static BindingSource ConsultarLista(int? id, string nomePesquisa, Contexto contexto)
        {
            try
            {
                BindingSource bsParceiro = new BindingSource();


                using (contexto)
                {
                    var bindingParceiro = from parceiro in contexto.ParceiroNegocio
                                              //onde ParceiroNegocio "id" for igual ao "id" ou nullo 
                                          where (parceiro.id == id || id == null) &&

                                                (parceiro.nome.Contains(nomePesquisa) || string.IsNullOrEmpty(nomePesquisa))
                                          select parceiro;

                    bsParceiro.DataSource = bindingParceiro.ToList();
                }
                return bsParceiro;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultaNomeParceiro
        public static string ConsultaNomeParceiro(int id, Contexto contexto)
        {
            try
            {
                //instanciando o objeto
                //Item item = new Item();

                //o item, instanciado acima recebe a consulta
                string parceiroNegocio = Convert.ToString(contexto.ParceiroNegocio.FirstOrDefault(parceiroPedido => parceiroPedido.id == id)?.nome);

                //retorna a consulta que o item recebeu
                return parceiroNegocio;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        //método de excluir cadastro, passando como parâmetro a minha classe Contexto
        #region Excluir
        public bool Excluir(Contexto contexto)
        {
            try
            {
                //aqui estou chamando o meu parceiro de negocio, da minha classe contexto
                contexto.ParceiroNegocio.Add(this);
                //esta chamando o método Deleted do Entity e excluindo o Cadastro selecionado acima 
                contexto.Entry(this).State = EntityState.Deleted;

                return true;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
