using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SB1.ProjTest.Model
{
    #region tabela
    [Table("MovimentoEstoque", Schema = "dbo")]
    public class MovimentoEstoque
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Column("idItem")]
        public int idItem { get; set; }

        [Column("quantidade")]
        public int quantidade { get; set; }

        [Column("totalEstoque")]
        public double totalEstoque { get; set; }

        [Column("totalEstoqueVenda")]
        public double totalEstoqueVenda { get; set; }

        [Column("LucroEstoque")]
        public double LucroEstoque { get; set; }

        [Column("unidadesVendidas")]
        public int unidadesVendidas { get; set; }

        [Column("dataInsercao")]
        public DateTime dataInsercao { get; set; }

        [Column("dataAtualizacao")]
        public DateTime dataAtualizacao { get; set; }
        #endregion
        #region Gravar
        public bool Gravar(MovimentoEstoque estoque, Contexto contexto)
        {
            try
            {
                if (estoque.id > 0)
                {
                    contexto.Entry(estoque).State = EntityState.Modified;
                    contexto.SaveChanges();
                }
                else
                {
                    int maxId;

                    maxId = estoque.id;

                    if (estoque.id > maxId)
                    {
                        maxId = estoque.id;
                    }
                    estoque.id = maxId + 1;
                    contexto.Entry(estoque).State = EntityState.Added;
                    contexto.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region GravarList
        // model 
        public static bool GravarList(MovimentoEstoque estoque, Contexto contexto)
        {
            try
            {
                if (estoque.id > 0)
                {
                    contexto.Entry(estoque).State = EntityState.Modified;
                }
                else
                {
                    var maxId = contexto.MovimentoEstoque.Any() ? contexto.MovimentoEstoque.Max(e => e.id) : 0;
                    estoque.id = maxId + 1;
                    contexto.Entry(estoque).State = EntityState.Added;
                }

                contexto.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region Consulta
        public static int ConsultarEstoque(int id, Contexto contexto)
        {
            try
            {
                //o item, instanciado acima recebe a consulta
                var estoque = contexto.MovimentoEstoque.FirstOrDefault(consultaEstoque => consultaEstoque.idItem == id)
                    .quantidade;

                //retorna a consulta que o item recebeu
                return estoque;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultarEstoque 
        public static int ConsultarUnidadesVendidas(int idItem, Contexto contexto)
        {
            try
            {
                using (contexto)
                {
                    var movimentoEstoque = Convert.ToInt32(contexto.MovimentoEstoque.FirstOrDefault(estoque => estoque.id == idItem)?.unidadesVendidas);
                    return movimentoEstoque;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region ConsultarTotalEstoqueVenda
        public static double ConsultarTotalEstoqueVenda(int id, Contexto contexto)
        {
            try
            {
                //o item, instanciado acima recebe a consulta
                var estoque = contexto.MovimentoEstoque.FirstOrDefault(consultaEstoque => consultaEstoque.idItem == id)
                    .totalEstoqueVenda;

                //retorna a consulta que o item recebeu
                return estoque;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region Consultar
        public static MovimentoEstoque Consultar(int id, Contexto contexto)
        {
            try
            {
                // o item, instanciado acima recebe a consulta
                MovimentoEstoque estoque = contexto.MovimentoEstoque.FirstOrDefault(consultaEstoque => consultaEstoque.idItem == id);

                // retorna a consulta que o item recebeu
                return estoque;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public static double ConsultarTotalEstoque(int id, Contexto contexto)
        {
            try
            {
                //o item, instanciado acima recebe a consulta
                var estoque = contexto.MovimentoEstoque.FirstOrDefault(consultaEstoque => consultaEstoque.idItem == id)
                    .totalEstoque;

                //retorna a consulta que o item recebeu
                return estoque;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultaTotalEstoque
        public static double ConsultaTotalEstoque(int id, Contexto contexto)
        {
            try
            {
                //o item, instanciado acima recebe a consulta
                var estoque = contexto.MovimentoEstoque.FirstOrDefault(consultaEstoque => consultaEstoque.idItem == id)
                    .totalEstoque;

                //retorna a consulta que o item recebeu
                return estoque;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultaId
        public int ConsultaId(int id, Contexto contexto)
        {
            try
            {
                //o item, instanciado acima recebe a consulta
                var estoque = contexto.MovimentoEstoque.FirstOrDefault(consultaEstoque => consultaEstoque.id == id).id;

                //retorna a consulta que o item recebeu
                return estoque;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region ConsultarLista
        public static BindingSource ConsultarLista(int? id, Contexto contexto)
        {
            try
            {
                //instanciando o objeto de vinculação BindingSource
                BindingSource bsEstoque = new BindingSource();
                using (contexto)
                {
                    //a variavel bindingItem recebendo a consulta
                    var bindingEstoque = from estoque in contexto.MovimentoEstoque
                                             //onde o id do item for igual ao id do parametro
                                         where (estoque.id == id || id == null)
                                         select estoque;

                    bsEstoque.DataSource = bindingEstoque.ToList();
                }
                return bsEstoque;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region Excluir
        public bool Excluir(Contexto contexto)
        {
            try
            {
                contexto.MovimentoEstoque.Add(this);
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