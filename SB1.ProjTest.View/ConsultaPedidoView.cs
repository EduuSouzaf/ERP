using SB1.ProjTest.Controller;
using SB1.ProjTest.Relatorio;
using System;
using System.Windows.Forms;

namespace SB1.ProjTest.View
{
    public partial class ConsultaPedidoView : Form
    {
        #region ConsultaPedidoView
        public ConsultaPedidoView()
        {
            InitializeComponent();
            ConsultarLista();
        }

        #endregion
        #region Consultar
        private void Consultar(string tipoPedido, string status)
        {
            try
            {
                BindingSource bindingSourcePedido = PedidoController.ConsultarLista(tipoPedido, status);

                if (bindingSourcePedido.Count != 0)
                {
                    //Preenchendo o Data Grid com o pedido
                    dgConsultaPedido.DataSource = bindingSourcePedido;

                    //altera a visualização do pedido
                    if (dgConsultaPedido == null) return;
                }
                else
                {
                    dgConsultaPedido.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao consultar o Pedido. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region ConsultarLista

        private void ConsultarLista()
        {
            BindingSource bindingSourceListaPedido = PedidoController.ConsultarListaPedido();

            dgConsultaPedido.DataSource = bindingSourceListaPedido;
        }
        #endregion
        #region AbrirCadastro

        private void AbrirCadastro()
        {
            try
            {
                int id = Convert.ToInt32(dgConsultaPedido.Rows[dgConsultaPedido.CurrentRow.Index].Cells["idPedido"].Value);

                CadastroPedidoView cadastroPedido = new CadastroPedidoView(id);

                //centraliza a tela quando ela é executada
                cadastroPedido.StartPosition = FormStartPosition.CenterScreen;
                cadastroPedido.Show();
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
        #region ConsultarPedido
        private void ConsultarPedido(int idPedido)
        {
            try
            {
                BindingSource bsPedido = PedidoController.ConsultarPedido(idPedido);

                if (bsPedido.Count != 0)
                {
                    //Preenchendo o Data Grid com o pedido
                    dgConsultaPedido.DataSource = bsPedido;

                    //altera a visualização do pedido
                    if (dgConsultaPedido == null) return;
                }
                else
                {
                    dgConsultaPedido.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao consultar o Pedido. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region ConsultarLista
        private void ConsultarLista(string status, string tipoPedido)
        {
            try
            {
                BindingSource bsPedido = PedidoController.ConsultarLista(status, tipoPedido);

                if (bsPedido.Count != 0)
                {
                    //Preenchendo o Data Grid com o pedido
                    dgConsultaPedido.DataSource = bsPedido;

                    //altera a visualização do pedido
                    if (dgConsultaPedido == null) return;
                }
                else
                {
                    dgConsultaPedido.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao consultar o Pedido. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region ConsultarLista
        private void ConsultarListaPed(string status, string tipoPedido)
        {
            try
            {
                BindingSource bsPedido = PedidoController.ConsultarListaPed(status, tipoPedido);

                if (bsPedido.Count != 0)
                {
                    //Preenchendo o Data Grid com o pedido
                    dgConsultaPedido.DataSource = bsPedido;

                    //altera a visualização do pedido
                    if (dgConsultaPedido == null) return;
                }
                else
                {
                    dgConsultaPedido.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao consultar o Pedido. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region ConsultarPedidoParceiro
        private void ConsultarPedidoParceiro(int idParceiro, string status, string tipoPedido)
        {
            try
            {
                BindingSource bsParceiro = PedidoController.ConsultarPedidoParceiro(idParceiro, status, tipoPedido);

                if (bsParceiro.Count != 0)
                {
                    //Preenchendo o Data Grid com o pedido
                    dgConsultaPedido.DataSource = bsParceiro;

                    //altera a visualização do pedido
                    if (dgConsultaPedido == null) return;
                }
                else
                {
                    dgConsultaPedido.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao consultar o Pedido. Erro: " + ex.Message;
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
                string tipoPedido = cbTipoPedido.Text;

                if (string.IsNullOrEmpty(tipoPedido))
                {
                    throw new Exception("Selecione o tipo de pedido");
                }

                if (tipoPedido.Equals("Compra"))
                {
                    tipoPedido = "PC";
                }
                else if (tipoPedido.Equals("Venda"))
                {
                    tipoPedido = "PV";
                }

                if (tipoPedido.Equals("PC"))
                {
                    RelatorioPedidoGeral relatorio = new RelatorioPedidoGeral();

                    relatorio.SetParameterValue("tipo", tipoPedido);
                    rvRelatorio childForm = new rvRelatorio(relatorio);
                    childForm.Show();
                }
                else if (tipoPedido.Equals("PV"))
                {
                    RelatorioPedidoGeral relatorio = new RelatorioPedidoGeral();

                    relatorio.SetParameterValue("tipo", tipoPedido);
                    rvRelatorio childForm = new rvRelatorio(relatorio);
                    childForm.Show();
                }
            }
            catch (Exception ex)
            {
                string mensagem = "Erro: " + ex.Message;
                string titulo = "Erro. ";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region btConsultar_Click
        private void btConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txIdPedido.Text) && string.IsNullOrEmpty(txIdParceiro.Text) && string.IsNullOrEmpty(cbStatus.Text) && string.IsNullOrEmpty(cbTipoPedido.Text))
                {
                    ConsultarLista();
                }
                //Consulta pelo id do pedido
                if (!string.IsNullOrEmpty(txIdPedido.Text) && string.IsNullOrEmpty(txIdParceiro.Text) && string.IsNullOrEmpty(cbStatus.Text) && string.IsNullOrEmpty(cbTipoPedido.Text))
                {
                    int idPedido = Convert.ToInt32(txIdPedido.Text);

                    ConsultarPedido(idPedido);
                }
                //Consulta usando o id do Parceiro
                if (!string.IsNullOrEmpty(txIdParceiro.Text))
                {
                    int idParceiro = Convert.ToInt32(txIdParceiro.Text);

                    string tipoPedido = "";

                    if (!string.IsNullOrEmpty(cbTipoPedido.Text) && !string.IsNullOrEmpty(cbStatus.Text))
                    {
                        if (cbTipoPedido.Text.Equals("Compra"))
                        {
                            tipoPedido = "PC";
                        }
                        else if (cbTipoPedido.Text.Equals("Venda"))
                        {
                            tipoPedido = "PV";
                        }
                        else if (cbTipoPedido.Text.Equals("Devolução"))
                        {
                            tipoPedido = "PD";
                        }

                        ConsultarPedidoParceiro(idParceiro, cbStatus.Text, tipoPedido);
                    }
                    else if (string.IsNullOrEmpty(cbTipoPedido.Text) && !string.IsNullOrEmpty(cbStatus.Text))
                    {
                        if (cbTipoPedido.Text.Equals("Compra"))
                        {
                            tipoPedido = "PC";
                        }
                        else if (cbTipoPedido.Text.Equals("Venda"))
                        {
                            tipoPedido = "PV";
                        }
                        else if (cbTipoPedido.Text.Equals("Devolução"))
                        {
                            tipoPedido = "PD";
                        }

                        ConsultarPedidoParceiro(idParceiro, cbStatus.Text, null);
                    }
                    else if (!string.IsNullOrEmpty(cbTipoPedido.Text) && string.IsNullOrEmpty(cbStatus.Text))
                    {
                        if (cbTipoPedido.Text.Equals("Compra"))
                        {
                            tipoPedido = "PC";
                        }
                        else if (cbTipoPedido.Text.Equals("Venda"))
                        {
                            tipoPedido = "PV";
                        }
                        else if (cbTipoPedido.Text.Equals("Devolução"))
                        {
                            tipoPedido = "PD";
                        }

                        ConsultarPedidoParceiro(idParceiro, null, tipoPedido);
                    }
                    else
                    {
                        ConsultarPedidoParceiro(idParceiro, null, null);
                    }
                }
                // Sem o id do parceiro
                else if (string.IsNullOrEmpty(txIdParceiro.Text))
                {
                    string tipoPedido = "";

                    if (cbTipoPedido.Text.Equals("Compra"))
                    {
                        tipoPedido = "PC";
                    }
                    else if (cbTipoPedido.Text.Equals("Venda"))
                    {
                        tipoPedido = "PV";
                    }
                    else if (cbTipoPedido.Text.Equals("Devolução"))
                    {
                        tipoPedido = "PD";
                    }

                    if (!string.IsNullOrEmpty(cbTipoPedido.Text) && !string.IsNullOrEmpty(cbStatus.Text))
                    {
                        ConsultarListaPed(cbStatus.Text, tipoPedido);
                    }
                    else if (string.IsNullOrEmpty(cbTipoPedido.Text) && !string.IsNullOrEmpty(cbStatus.Text))
                    {
                        ConsultarListaPed(cbStatus.Text, null);
                    }
                    else if (!string.IsNullOrEmpty(cbTipoPedido.Text) && string.IsNullOrEmpty(cbStatus.Text))
                    {
                        ConsultarListaPed(null, tipoPedido);
                    }
                }
            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao consultar o pedido. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        // eventos
        #region dgConsultaPedido_CellFormatting
        private void dgConsultaPedido_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = string.Format("{0:C}", e.Value);
                e.FormattingApplied = true;
            }
        }
        #endregion
        #region dgConsultaPedido_CellMouseDoubleClick
        private void dgConsultaPedido_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AbrirCadastro();
        }
        #endregion
        #region btListaParceiro_Click
        private void btListaParceiro_Click(object sender, EventArgs e)
        {
            string codigoParceiro = ListaParceiroView.Exibir();

            if (!string.IsNullOrEmpty(codigoParceiro))
            {
                string parceiro = ParceiroNegocioController.RetornaParceiro(Convert.ToInt32(codigoParceiro));
                txIdParceiro.Text = codigoParceiro;
                txNomeParceiro.Text = parceiro;
            }
        }
        #endregion

        private void btImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
    }
}
