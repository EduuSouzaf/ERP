using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SB1.ProjTest.Model
{
    [Table("TabelaPreco", Schema = "dbo")]
    public class TabelaPreco
    {
        [Key] // chave primária
        [Column("idTabelaPreco")] //define as colunas
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Define que o campo será autoincremento.
        public int idTabelaPreco { get; set; } //gravar os dados na coluna

        [Column("idItem")]
        public int idItem { get; set; }

        [Column("precoCusto")]
        public double precoCusto { get; set; }

        [Column("precoMinimo")]
        public double precoMinimo { get; set; }

        [Column("precoVenda")]
        public double precoVenda { get; set; }

        [Column("margemLucro")]
        public double margemLucro { get; set; }

        [Column("lucroTotal")]
        public double lucroTotal { get; set; }

        [Column("dataAtualizacao")]
        public DateTime dataAtualizacao { get; set; }

        [Column("dataInsercao")]
        public DateTime dataInsercao { get; set; }

        #region Gravar
        //método de gravação, e usando a classe contexto como parâmetro
        public bool Gravar(TabelaPreco preco, Contexto contexto)
        {
            try
            {

                if (preco.idTabelaPreco > 0)
                {
                    contexto.Entry(preco).State = EntityState.Modified;
                    contexto.SaveChanges();
                }
                else
                {
                    int maxId;

                    maxId = preco.idTabelaPreco;

                    if (preco.idTabelaPreco > maxId)
                    {
                        maxId = preco.idTabelaPreco;
                    }
                    preco.idTabelaPreco = maxId + 1;
                    contexto.Entry(preco).State = EntityState.Added;
                    contexto.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                //mensagem de erro
                throw new Exception(ex.Message);
            }

        }
        #endregion
        #region Consultar
        public static TabelaPreco Consultar(int id, Contexto contexto)
        {
            try
            {
                //instanciando o objeto
                TabelaPreco preco = contexto.TabelaPreco.FirstOrDefault(tabelaPreco => tabelaPreco.idItem == id);

                //retorna a consulta que o item recebeu
                return preco;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region Consultar
        public static int ConsultarId(int id, Contexto contexto)
        {
            try
            {
                int preco = Convert.ToInt32(contexto.TabelaPreco.FirstOrDefault(price => price.idItem == id)?.idTabelaPreco);

                return preco;
                //retorna a consulta que o item recebeu
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region ConsultarPrecoVenda

        public static double ConsultarPrecoVenda(int id, Contexto contexto)
        {
            try
            {
                //instanciando o objeto
                double preco = contexto.TabelaPreco.FirstOrDefault(tabelaPreco => tabelaPreco.idItem == id).precoVenda;

                //retorna a consulta que o item recebeu
                return preco;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        #endregion

        public static double ConsultarPrecoCusto(int id, Contexto contexto)
        {
            try
            {
                //instanciando o objeto
                double preco = contexto.TabelaPreco.FirstOrDefault(tabelaPreco => tabelaPreco.idItem == id).precoCusto;

                //retorna a consulta que o item recebeu
                return preco;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public static List<double> ConsultarMargemLucro(Contexto contexto)
        {
            try
            {
                //instanciando o objeto
                using (contexto)
                {
                    var preco = from tabelaPreco in contexto.TabelaPreco
                                           select tabelaPreco.margemLucro;

                    return preco.ToList();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
