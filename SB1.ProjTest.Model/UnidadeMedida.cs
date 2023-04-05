using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SB1.ProjTest.Model
{
    [Table("UnidadeMedida", Schema = "dbo")]
    public class UnidadeMedida
    {
        [Key]
        [Column("codigo")]
        public string codigo { get; set; }

        [Column("unidadeMedida")]
        public string unidadeMedida { get; set; }

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
        public static bool Gravar(List<UnidadeMedida> medidas, Contexto contexto)
        {
            try
            {
                foreach (var medida in medidas)
                {
                    if (!contexto.UnidadeMedida.Any(unidMedida => unidMedida.codigo == medida.codigo))
                    {
                        contexto.Entry(medida).State = EntityState.Added;
                    }
                    else
                    {
                        contexto.Entry(medida).State = EntityState.Modified;
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
                BindingSource bsConsultarUnidadeMedia = new BindingSource();
                using (contexto)
                {
                    var bindingUnidade = from medida in contexto.UnidadeMedida
                                         where ((medida.codigo == codigo) || (codigo == null))
                                         select medida;
                    bsConsultarUnidadeMedia.DataSource = bindingUnidade.ToList();
                }
                return bsConsultarUnidadeMedia;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
