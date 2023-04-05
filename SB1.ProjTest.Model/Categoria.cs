using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SB1.ProjTest.Model
{
    [Table("Categoria", Schema = "dbo")]
    public class Categoria
    {
        [Key]
        [Column("codigo")]
        public string codigo { get; set; }

        [Column("categoria")]
        public string categoria { get; set; }

        [Column("descricao")]
        public string descricao { get; set; }

        [Column("status")]
        public bool status { get; set; }

        [Column("dataInsercao")]
        public DateTime dataInsercao { get; set; }

        [Column("dataAtualizacao")]
        public DateTime dataAtualizacao { get; set; }

        // Método para gravar uma lista de objetos Categoria no banco de dados
        #region Gravar
        public static bool Gravar(List<Categoria> categorias, Contexto contexto)
        {
            try
            {
                foreach (var categoria in categorias)
                {
                    if (!contexto.Categoria.Any(c => c.codigo == categoria.codigo))
                    {
                        contexto.Entry(categoria).State = EntityState.Added;
                    }
                    else
                    {
                        contexto.Entry(categoria).State = EntityState.Modified;
                    }
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
        #region Consultar
        public static BindingSource Consultar(string codigo, Contexto contexto)
        {

            try
            {
                BindingSource bsCategoria = new BindingSource();
                using (contexto)
                {
                    var bindingCategoria = from categoria in contexto.Categoria
                        where ((categoria.codigo == codigo) || (codigo == null))
                        select categoria;
                    bsCategoria.DataSource = bindingCategoria.ToList();
                }
                return bsCategoria;
            }

            //tratamento de exeção
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
