using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;

namespace SB1.ProjTest.Model
{
    [Table("Marca", Schema = "dbo")]
    public class Marca
    {
        [Key]
        [Column("codigo")]
        public string codigo { get; set; }

        [Column("marca")]
        public string marca { get; set; }

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
        public static bool Gravar(List<Marca> marcas, Contexto contexto)
        {
            try
            {
                foreach (var marca in marcas)
                {
                    if (!contexto.Marca.Any(m => m.codigo == marca.codigo))
                    {
                        contexto.Entry(marca).State = EntityState.Added;
                    }
                    else
                    {
                        contexto.Entry(marca).State = EntityState.Modified;
                    }
                }
                contexto.SaveChanges();
                return true;
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("Erro ao salvar as alterações no banco de dados.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao gravar as categorias no banco de dados.", ex);
            }
        }
        #endregion
        #region Consultar
        public static BindingSource Consultar(string codigo, Contexto contexto)
        {
            try
            {
                BindingSource bsConsultarMarca = new BindingSource();
                using (contexto)
                {
                    var bindingMarca = from marca in contexto.Marca
                                       where ((marca.codigo == codigo) || (codigo == null))
                                       select marca;
                    bsConsultarMarca.DataSource = bindingMarca.ToList();
                }
                return bsConsultarMarca;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
