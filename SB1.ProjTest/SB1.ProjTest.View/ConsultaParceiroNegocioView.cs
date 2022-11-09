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
    public partial class ConsultaParceiroNegocioView : Form
    {
        public ConsultaParceiroNegocioView()
        {
            InitializeComponent();
        }
        private void Consultar(int id, string nome)
        {
            try
            {
                BindingSource bindingSourceParceiro;

                if (id > 0)
                {
                    bindingSourceParceiro = ParceiroNegocioController.ConsultarLista(id, nome);
                }
                else
                {
                    bindingSourceParceiro = ParceiroNegocioController.ConsultarLista(null, nome);
                }
                if (bindingSourceParceiro.Count != 0)
                {
                    dgConsultaParceiro.DataSource = bindingSourceParceiro;
                }
                else
                {
                    dgConsultaParceiro.Rows.Clear();
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
                int id = Convert.ToInt32(dgConsultaParceiro.Rows[dgConsultaParceiro.CurrentRow.Index].Cells["id"].Value);

                CadastroParceiroNegocioView cadastrarParceiroNegocio = new CadastroParceiroNegocioView(id);
                cadastrarParceiroNegocio.MdiParent = ActiveForm;
                //centraliza a tela quando ela é executada
                cadastrarParceiroNegocio.StartPosition = FormStartPosition.CenterScreen;
                cadastrarParceiroNegocio.Show();
                Close();
            }
            catch (Exception ex)
            {

                string mensagem = "Erro ao abrir o Parceiro de Negócio. Erro: " + ex.Message;
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

        private void dgConsultaParceiro_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AbrirCadastro();
        }
        private void Excluir()
        {
            try
            {
                if (dgConsultaParceiro.CurrentRow != null)
                {
                    int id = Convert.ToInt32(dgConsultaParceiro.Rows[dgConsultaParceiro.CurrentRow.Index].Cells["id"].Value);
                    string nome = Convert.ToString(dgConsultaParceiro.Rows[dgConsultaParceiro.CurrentRow.Index].Cells["nome"].Value);

                    string mensagem = "Tem certeza que deseja excluir o Parceiro de Negócio " + id.ToString() + " - " + nome;
                    string titulo = "Aviso.";
                    MessageBoxButtons botoes = MessageBoxButtons.YesNo;
                    MessageBoxIcon icone = MessageBoxIcon.Warning;
                    DialogResult resultado = MessageBox.Show(mensagem, titulo, botoes, icone);

                    if (resultado == DialogResult.Yes)
                    {
                        ParceiroNegocio parceiroNegocio = ParceiroNegocioController.Consultar(id);
                        if (ParceiroNegocioController.Excluir(parceiroNegocio))
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
                else
                {
                    throw new Exception("Selecione uma linha");
                }
            }
            catch (Exception ex)
            {

                string mensagem = "Erro ao excluir o Parceiro de Negócio. Erro: " + ex.Message;
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

        private void ConsultaParceiroNegocioView_Load(object sender, EventArgs e)
        {

        }
    }
}
