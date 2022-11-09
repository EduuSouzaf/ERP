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
    [Table("ParceiroNegocio", Schema = "dbo")]
    public class ParceiroNegocio
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Define que o campo será autoincremento.
        public int id { get; set; }

        //declaracao das variavei, criacao dos campos da tabela e metodos "Get" e "Set"
        [Column("nome")]
        public String nome { get; set; }

        [Column("tipoDocumento")]
        public String tipoDocumento { get; set;}

        [Column("documento")]
        public String documento { get; set;}

        [Column("telefone")]
        public String telefone { get; set; }

        [Column("eMail")]
        public String eMail { get; set; }

        [Column("parceiroNegocio")]
        public String parceiroNegocio { get; set; }
        
        [Column("dataInsercao")]
        public DateTime dataInsercao { get; set;}

        [Column("dataAtualizacao")]
        public DateTime dataAtualizacao { get; set; }

        [Column("ativo")]
        public bool ativo { get; set;}

        //método de gravação
        public bool Gravar (Contexto contexto)
        {
            try
            {

                contexto.ParceiroNegocio.Add(this);
                contexto.Entry(this).State = id > 0 ? EntityState.Modified : EntityState.Added; //if ternário 
                contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //mensagem de erro
                throw new Exception(ex.Message);
            }
        }

        //consulta unica
        public static ParceiroNegocio Consultar(int id, Contexto contexto)
        {
            try
            {
                //instanciando o objeto
                ParceiroNegocio parceiroNegocio = new ParceiroNegocio();

                //where = onde
                // => = onde
                //onde "id" for igual ao "id" retorna o primeiro id
                parceiroNegocio = contexto.ParceiroNegocio.Where(parcNegocio => parcNegocio.id == id).FirstOrDefault();

                //retorno
                return parceiroNegocio;
            }
            //tratamento de exeção
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //mais de uma consulta
        //int? = int que aceita o retorno de valores nulos
        public static BindingSource ConsultarLista (int? id, String nomePesquisa, Contexto contexto)

        {
            try
            {
                BindingSource bsParceiro = new BindingSource();

                using (contexto)
                {
                    //gerando a consulta
                    //var = variavel não tipada
                    var bindingParceiro = from ParceiroNegocio in contexto.ParceiroNegocio
                                              //onde ParceiroNegocio "id" for igual ao "id" ou nullo 
                                          where (ParceiroNegocio.id == id || id == null) &&
                                                //contains = contém                                 //retorna nulo
                                                //retorna o nome da pesquisa
                                                (ParceiroNegocio.nome.Contains(nomePesquisa) || String.IsNullOrEmpty(nomePesquisa))
                                          select ParceiroNegocio;
                    //retorna em uma lista
                    bsParceiro.DataSource = bindingParceiro.ToList();
                }

                return bsParceiro;
            }
            catch (Exception ex)
            {

                throw new Exception (ex.Message);
            }
        }

        public bool Excluir (Contexto contexto)
        {
            try
            {
                contexto.ParceiroNegocio.Add(this);
                contexto.Entry(this).State = EntityState.Deleted;

                return true;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
