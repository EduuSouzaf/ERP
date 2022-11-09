using SB1.ProjTest.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SB1.ProjTest.View
{
    public partial class ListaParceiroView : Form
    {
        private string codigoParceiro { get; set; }
        //Construtor
        #region ListaParceiroView
        public ListaParceiroView()
        {
            InitializeComponent();
            ConsultarLista();
        }
        #endregion
        //Metodos
        #region ConsultarLista
        public void ConsultarLista()
        {
            try
            {
                BindingSource bindingSourceListaParceiro;

                bindingSourceListaParceiro = ParceiroNegocioController.ConsultarListaParceiro();

                dgConsultaParceiro.DataSource = bindingSourceListaParceiro;

            }
            catch { }
        }
        #endregion 
        #region Exibir
        public static string Exibir()
        {
            try
            {
                ListaParceiroView listaParceiro = new ListaParceiroView();
                listaParceiro.StartPosition = FormStartPosition.CenterScreen;
                listaParceiro.ShowDialog();

                return listaParceiro.codigoParceiro;

            }
            catch { return null; }
        }
        #endregion
        #region Selecionar
        public void Selecionar()
        {
            codigoParceiro = Convert.ToString(dgConsultaParceiro.Rows[dgConsultaParceiro.CurrentRow.Index].Cells["id"].Value);
            Close();
        }
        #endregion
        //Eventos
        #region dgConsultaParceiro_CellMouseDoubleClick
        private void dgConsultaParceiro_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Selecionar();
            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao Selecionar o Parceiro. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region btSelecionarItem_MouseClick
        private void btSelecionarItem_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Selecionar();
            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao Selecionar o Parceiro. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
    }
}
