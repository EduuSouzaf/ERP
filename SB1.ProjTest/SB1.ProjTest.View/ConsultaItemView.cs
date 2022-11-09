using SB1.ProjTest.Controller;
using SB1.ProjTest.Model;
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
        public ConsultaItemView()
        {
            InitializeComponent();
        }
        private void Consultar(int id, string nome)
        {
            try
            {
                BindingSource bindinfSourceItem;
                if (id > 0)
                {
                    bindinfSourceItem = ItemController.Consultarlista(id, nome);
                }
                else
                {
                    bindinfSourceItem = ItemController.Consultarlista(id, nome);
                }
                if (bindinfSourceItem.Count != 0)
                {
                    dgConsultaItem.DataSource = bindinfSourceItem;
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
            catch { }
        }
        public void AbrirCadastro()
        {
            try
            {
                int id = Convert.ToInt32(dgConsultaItem.Rows[dgConsultaItem.CurrentRow.Index].Cells["id"].Value);

                CadastroItemView cadastrarItem = new CadastroItemView(id);
                cadastrarItem.MdiParent = ActiveForm;
                //centraliza a tela quando ela é executada
                cadastrarItem.StartPosition = FormStartPosition.CenterScreen;
                cadastrarItem.Show();
                Close();
            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao abrir o Item. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);

            }
        }

        private void btAbrir_Click(object sender, EventArgs e)
        {
            AbrirCadastro();
        }
        private void dgConsultaItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirCadastro();
        }
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

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }
    }
    
}
