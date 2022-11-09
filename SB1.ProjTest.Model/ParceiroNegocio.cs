using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        //Passando como parâmetro a minha classe contexto
        #region Gravar
        public bool Gravar(Contexto contexto)
        {
            try
            {
                //Chamando o meu método Parceiro de negócio na mihna classe contexto, e adicionando ela no banco 
                contexto.ParceiroNegocio.Add(this);
                //if ternário, para adicionar ou modificar um Parceiro
                //Se o id do parceiro for maior que "0" modifica, se não adiciona
                contexto.Entry(this).State = id > 0 ? EntityState.Modified : EntityState.Added;
                //esta salvando as alterações == ctrl + S 
                contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //mensagem de erro
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
                var bindingParceiro = from ParceiroNegocio in contexto.ParceiroNegocio
                                          //  where Item.status == true 
                                      select ParceiroNegocio;

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
                ParceiroNegocio parceiroNegocio = new ParceiroNegocio();

                Endereco endereco = new Endereco();

                //where = onde
                // => = onde
                //onde "id" for igual ao "id" retorna o primeiro id
                parceiroNegocio = contexto.ParceiroNegocio.Where(parcNegocio => parcNegocio.id == id).FirstOrDefault();
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
        //mais de uma consulta
        //int? = int que aceita o retorno de valores nulos
        #region ConsultarLista
        public static BindingSource ConsultarLista(int? id, String nomePesquisa, Contexto contexto)
        //metodo de consultar uma lista de parceiros de negocio e passando como parãmetro duas variaveis e a minha classe Contexto
        {
            try
            {
                //instanciando o objeto BindingSource, que é um objeto do próprio C#
                BindingSource bsParceiro = new BindingSource();

                //usando o meu parâmetro contexto
                using (contexto)
                {
                    //gerando a consulta
                    //a minha variavel bindingParceiro está recebendo a minha consulta
                    var bindingParceiro = from ParceiroNegocio in contexto.ParceiroNegocio
                                              //onde ParceiroNegocio "id" for igual ao "id" ou nullo 
                                          where (ParceiroNegocio.id == id || id == null) &&
                                                //contains = contém                                 //retorna nulo
                                                //retorna o nome da pesquisa
                                                (ParceiroNegocio.nome.Contains(nomePesquisa) || String.IsNullOrEmpty(nomePesquisa))
                                          select ParceiroNegocio;
                    //retorna o resultado da consulta em uma lista
                    bsParceiro.DataSource = bindingParceiro.ToList();
                }
                //aqui está retornando o resultado da consulta no meu objeto bsParceiro
                return bsParceiro;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultaItemPedido
        public static string ConsultaNomeParceiro(int id, Contexto contexto)
        {
            try
            {
                //instanciando o objeto
                //Item item = new Item();

                //o item, instanciado acima recebe a consulta
                string parceiroNegocio = Convert.ToString(contexto.ParceiroNegocio.Where(parceiroPedido => parceiroPedido.id == id).FirstOrDefault().nome);

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
