using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SB1.ProjTest.View
{
    public partial class rvRelatorio : Form
    {
        public rvRelatorio()
        {
            InitializeComponent();
        }
        public rvRelatorio(ReportClass relatorio)
        {
            InitializeComponent();
            Configurar(relatorio);
        }
        private SqlConnectionStringBuilder coneccao = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["SqlSereverConecction"].ConnectionString);

            private void Configurar(ReportClass relatorio)
        {
            try
            {
                relatorio.SetDatabaseLogon(coneccao.UserID, coneccao.Password, coneccao.DataSource, coneccao.InitialCatalog);

                crvRelatorio.ReportSource = relatorio;
            }
            catch (Exception ex)
            {

                string mensagem = "Erro ao abrir o relatorio. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        } 
    }
}
