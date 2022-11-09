using SB1.ProjTest.Controller;
using SB1.ProjTest.Model;
using SB1.ProjTest.Relatorio;
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
    public partial class ConsultaItemView : Form
    {
        //Construtor
        #region ConsultaItemView
        public ConsultaItemView()
        {
            InitializeComponent();
            ConsultarLista();
        }
        #endregion
        //Metodos
        #region Consultar
        private void Consultar(int id, string nome)
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
                    dgConsultaItem.DataSource = bindigSourceItem;
                }
                else
                {
                    dgConsultaItem.Rows.Clear();
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
        #region ConsultarLista
        public void ConsultarLista()
        {
            try
            {
                BindingSource bindingSourceListaItem;

                bindingSourceListaItem = ItemController.ConsultarListaItem();

                dgConsultaItem.DataSource = bindingSourceListaItem;

            }
            catch { }
        }
        #endregion 
        #region AbrirCadastro
        public void AbrirCadastro()
        {
            try
            {
                int id = Convert.ToInt32(dgConsultaItem.Rows[dgConsultaItem.CurrentRow.Index].Cells["id"].Value);

                CadastroItemView cadastrarItem = new CadastroItemView(id);
                //centraliza a tela quando ela é executada
                cadastrarItem.StartPosition = FormStartPosition.CenterScreen;
                cadastrarItem.Show();
                Close();
            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao abrir o cadastro do Item. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);

            }
        }
        #endregion
        #region Excluir
        private void Excluir()
        {
            try
            {
                if (dgConsultaItem.CurrentRow != null)
                {
                    int id = Convert.ToInt32(dgConsultaItem.Rows[dgConsultaItem.CurrentRow.Index].Cells["id"].Value);
                    string nome = Convert.ToString(dgConsultaItem.Rows[dgConsultaItem.CurrentRow.Index].Cells["nome"].Value);

                    string mensagem = "Tem certeza que deseja excluir o item " + id.ToString() + " - " + nome;
                    string titulo = "Aviso.";
                    MessageBoxButtons botoes = MessageBoxButtons.YesNo;
                    MessageBoxIcon icone = MessageBoxIcon.Warning;
                    DialogResult resultado = MessageBox.Show(mensagem, titulo, botoes, icone);

                    if (resultado == DialogResult.Yes)
                    {
                        Item item = ItemController.Consultar(id);
                        if (ItemController.Excluir(item))
                        {
                            mensagem = "Parceiro de Negócio " + id.ToString() + " - " + nome + "Ecluído com sucesso";
                            titulo = "Aviso.";
                            botoes = MessageBoxButtons.OK;
                            icone = MessageBoxIcon.Information;
                            MessageBox.Show(mensagem, titulo, botoes, icone);

                            if (string.IsNullOrEmpty(txId.Text))
                            {
                                Consultar(0, txNome.Text);
                            }
                            else
                            {
                                Consultar(Convert.ToInt32(txId.Text), null);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao excluir o item. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region Imprimir
        private void Imprimir()
        {
            try
            {
                RelatorioItemGeral relatorio = new RelatorioItemGeral();

                relatorio.SetParameterValue("codigo", txId.Text);
                relatorio.SetParameterValue("nome", txNome.Text);

                rvRelatorio childForm = new rvRelatorio(relatorio);
                childForm.Show();
            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao imprimir o Item. Erro: " + ex.Message;
                string titulo = "Erro. ";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        //Eventos
        #region dgConsultaItem_CellContentClick
        private void dgConsultaItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirCadastro();
        }
        #endregion
        #region txNome_KeyPress
        private void txNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }
        #endregion
        #region txId_KeyPress
        private void txId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;

            }
        }
        #endregion
        #region btExit_Click
        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        #region btImprimir_Click
        private void btImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
        #endregion
        #region btExcluir_Click
        private void btExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }
        #endregion
        #region btAbrir_Click
        private void btAbrir_Click(object sender, EventArgs e)
        {
            AbrirCadastro();
        }
        #endregion
        #region btConsultar_Click
        private void btConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txId.Text))
                {
                    Consultar(0, txNome.Text);
                }
                else
                {
                    Consultar(Convert.ToInt32(txId.Text), null);
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
        #region btCancelar_Click
        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
