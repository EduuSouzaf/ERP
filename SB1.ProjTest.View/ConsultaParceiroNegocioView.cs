using SB1.ProjTest.Controller;
using SB1.ProjTest.Model;
using SB1.ProjTest.Relatorio;
using System;
using System.Windows.Forms;

namespace SB1.ProjTest.View
{
    public partial class ConsultaParceiroNegocioView : Form
    {
        //Construtor
        #region ConsultaParceiroNegocioView
        public ConsultaParceiroNegocioView()
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
                    dgConsultaP.DataSource = bindingSourceParceiro;
                }
                else
                {
                    dgConsultaP.Rows.Clear();
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
                BindingSource bindingSourceListaParceiro;

                bindingSourceListaParceiro = ParceiroNegocioController.ConsultarListaParceiro();

                dgConsultaP.DataSource = bindingSourceListaParceiro;

            }
            catch
            {
                // ignored
            }
        }
        #endregion
        #region AbrirCadastro
        public void AbrirCadastro()
        {
            try
            {
                int id = Convert.ToInt32(dgConsultaP.Rows[dgConsultaP.CurrentRow.Index].Cells["id"].Value);

                CadastroParceiroNegocioView cadastrarParceiroNegocio = new CadastroParceiroNegocioView(id);

                //centraliza a tela quando ela é executada
                cadastrarParceiroNegocio.StartPosition = FormStartPosition.CenterScreen;
                cadastrarParceiroNegocio.Show();
                //Close();
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
        #endregion
        #region Excluir
        private void Excluir()
        {
            try
            {
                if (dgConsultaP.CurrentRow != null)
                {
                    int id = Convert.ToInt32(dgConsultaP.Rows[dgConsultaP.CurrentRow.Index].Cells["id"].Value);
                    string nome = Convert.ToString(dgConsultaP.Rows[dgConsultaP.CurrentRow.Index].Cells["nome"].Value);

                    //Verifica se o usuario deseja excluir o cadastro
                    string mensagem = "Tem certeza que deseja excluir o Parceiro de Negócio " + id.ToString() + " - " + nome;
                    string titulo = "Aviso.";
                    MessageBoxButtons botoes = MessageBoxButtons.YesNo;
                    MessageBoxIcon icone = MessageBoxIcon.Warning;
                    DialogResult resultado = MessageBox.Show(mensagem, titulo, botoes, icone);

                    Pedido pedido = PedidoController.ConsultarParceiro(id);

                    int pedidoParceiro = 0;

                    if (pedido != null)
                    {
                        pedidoParceiro = Convert.ToInt32(pedido.idParceiro);
                    }

                    if (resultado == DialogResult.Yes)
                    {
                        if (pedidoParceiro == 0)
                        {
                            ParceiroNegocio parceiroNegocio = ParceiroNegocioController.Consultar(id);
                            if (ParceiroNegocioController.Excluir(parceiroNegocio))
                            {
                                mensagem = "Parceiro de Negócio " + id.ToString() + " - " + nome + " Excluído com sucesso";
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
                        else
                        {
                            mensagem = "Não é possível excluir nenhum parceiro que esteja vinculado a um pedido. ";
                            titulo = "Alert ";
                            botoes = MessageBoxButtons.OK;
                            icone = MessageBoxIcon.Stop;
                            MessageBox.Show(mensagem, titulo, botoes, icone);
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
        #endregion
        #region Imprimir
        private void Imprimir()
        {
            try
            {
                RealtorioParceiroGeral relatorio = new RealtorioParceiroGeral();

                relatorio.SetParameterValue("codigo", txId.Text);//string.IsNullOrEmpty(txId.Text) ?  : Convert.ToInt32(txId.Text));
                relatorio.SetParameterValue("nome", txNome.Text);

                rvRelatorio childForm = new rvRelatorio(relatorio);
                childForm.Show();

            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao imprimir o Parceiro de Negócio. Erro: " + ex.Message;
                string titulo = "Erro. ";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        // Eveentos
        #region dgConsultaParceiro_CellMouseDoubleClick
        private void dgConsultaParceiro_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
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
            if (!char.IsDigit(e.KeyChar))

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
            catch { }
        }
        #endregion
        #region btAbrir_Click
        private void btAbrir_Click(object sender, EventArgs e)
        {
            AbrirCadastro();
        }
        #endregion
        #region btExcluir_Click
        private void btExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }
        #endregion
        #region btImprimir_Click
        private void btImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
        #endregion
    }
}
