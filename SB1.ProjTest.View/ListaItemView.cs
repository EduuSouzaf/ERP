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
    public partial class ListaItemView : Form
    {
        private string codigoItem { get; set; }

        //Construtor
        #region ListaItemView
        public ListaItemView()
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
                BindingSource bindingSourceListaItem;

                bindingSourceListaItem = ItemController.ConsultarListaItem();

                dgListaItens.DataSource = bindingSourceListaItem;

            }
            catch { }
        }
        #endregion 
        #region ConsultarLista
        private void ConsultarListaItens(int id, string nome)
        {
            try
            {
                BindingSource bindigSourceItem;
                if (id > 0)
                {
                    bindigSourceItem = ItemController.Consultarlista(id, nome);
                }
                else
                {
                    bindigSourceItem = ItemController.Consultarlista(null, nome);
                }
                if (bindigSourceItem.Count != 0)
                {
                    dgListaItens.DataSource = bindigSourceItem;
                }
                else
                {
                    dgListaItens.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao consultar. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region Exibir
        public static string Exibir()
        {
            try
            {
                ListaItemView listaItem = new ListaItemView();
                listaItem.StartPosition = FormStartPosition.CenterScreen;
                listaItem.ShowDialog();

                return listaItem.codigoItem;

            }
            catch { return null; }
        }
        #endregion
        #region ExibirItemConsulta
        public static string ExibirItemConsulta()
        {
            try
            {
                ListaItemView listaItem = new ListaItemView();

                return listaItem.codigoItem;

            }
            catch { return null; }
        }
        #endregion
        #region Selecionar
        public void Selecionar()
        {
            codigoItem = Convert.ToString(dgListaItens.Rows[dgListaItens.CurrentRow.Index].Cells["id"].Value);
            Close();
        }
        #endregion
        //Eventos
        #region btConsultar_Click
        private void btConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txId.Text))
                {
                    ConsultarListaItens(0, txNome.Text);
                }
                else
                {
                    ConsultarListaItens(Convert.ToInt32(txId.Text), null);
                }
            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao abrir a consulta. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region dgListaItens_CellMouseDoubleClick
        private void dgListaItens_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Selecionar();
            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao Selecionar o Item. Erro: " + ex.Message;
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
                string mensagem = "Erro ao Selecionar o Item. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
    }
}
