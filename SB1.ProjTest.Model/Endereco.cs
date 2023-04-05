using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SB1.ProjTest.Model
{
    #region Tabela
    [Table("Endereco", Schema = "dbo")]
   
    public class Endereco
    {
        [Key] // chave primária
        [Column("idEndereco")] //define as colunas
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Define que o campo será autoincremento.
        public int idEndereco { get; set; } //gravar os dados na coluna

        [Column("idParceiroNegocio")]
        public int idParceiroNegocio { get; set; }

        [Column("logradouro")]
        public string logradouro { get; set; }

        [Column("numero")]
        public int numero { get; set; }

        [Column("bairro")]
        public string bairro { get; set; }

        [Column("cidade")]
        public string cidade { get; set; }

        [Column("estado")]
        public string estado { get; set; }

        [Column("cep")]
        public string cep { get; set; }

        [Column("complemento")]
        public string complemento { get; set; }

        [Column("dataInsercao")]
        public DateTime dataInsercao { get; set; }
        #endregion
        #region Gravar
        //método de gravação que recebe uma "List" como parâmetro
        public static bool Gravar(List<Endereco> endereco, Contexto contexto)
        {
            try
            {       
                //i se refere a linha do for no list
                for (int i = 0; i < endereco.Count; i++)
                {
                    //esta adicionando no objeto endereco da contexto
                    contexto.Endereco.Add(endereco[i]);

                    //quando o id do endereco no grid for mair que 0, vai atualizar
                    if (endereco[i].idEndereco > 0 )
                    {
                        //está atualizando os dados do objeto endereco
                        contexto.Entry(endereco[i]).State = EntityState.Modified;
                        //salvando
                        contexto.SaveChanges();
                    }
                    else
                    {
                        int maxId = 0;
                        //estrutura de repetição para a quantidade de endereços que podem ser adicionados
                        //para isso ele percorre toda a minha list de endereco
                        for (int j = 0; j < endereco.Count; j++)
                        {
                            //se for o primeiro a ser adicionado
                            if (j == 0)
                            {
                                //a minha variavel vai receber o id do endereco
                                maxId = endereco[j].idEndereco;
                            }
                            else
                            {   
                                if (endereco[j].idEndereco > maxId)
                                {
                                    //caso não seje o primeiro ele vai receber o id do endereco
                                    maxId = endereco[j].idEndereco;
                                }
                            }
                        }
                        //o meu idENdereco vai recebere o valor que o maxId recebeu + 1
                        endereco[i].idEndereco = maxId + 1;
                        //aqui estou adicioanando o endereco
                        contexto.Entry(endereco[i]).State = EntityState.Added;
                        contexto.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultarLista
        //método de consulta em lista, passando como parametro um int?, e a classe contexto
        public static BindingSource ConsultarLista(int? idParceiro, Contexto contexto)
        {
            try
            {
                //variavel BindingSource
                BindingSource bsEndereco = new BindingSource();
                using (contexto)
                {
                    //consulta para puxar todos os dados da tabela endereco
                    var bindingbsEndereco = from ender in contexto.Endereco
                                            where ender.idParceiroNegocio == idParceiro
                                            select ender;
                    bsEndereco.DataSource = bindingbsEndereco.ToList();
                    return bsEndereco;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region Consultar
        public static Endereco Consultar(int idEndereco, int idParceiro, Contexto contexto)
        {
            try
            {
                Endereco endereco = contexto.Endereco.FirstOrDefault(ender => ender.idEndereco == idEndereco && ender.idParceiroNegocio == idParceiro);

                return endereco;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region Excluir
        public static bool Excluir(Endereco endereco, Contexto contexto)
        {
            try
            {
                contexto.Endereco.Add(endereco);
                contexto.Entry(endereco).State = EntityState.Deleted;
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
