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
    public partial class CadastroPedidoView : Form
    {
        //Construtores
        #region CadastroPedidoView
        public CadastroPedidoView()
        {
            InitializeComponent();
        }
        #endregion
        //Métodos
        #region Gravar
        private void Gravar()
        {
            try
            {
                if (string.IsNullOrEmpty(txParceiro.Text))
                {
                    throw new Exception("Insira um Cliente/Fornecedor");
                }
                if (string.IsNullOrEmpty(cbEndereco.Text))
                {
                    throw new Exception("Selecione um Endereço");
                }
                if (string.IsNullOrEmpty(txDataVencimento.Text))
                {
                    throw new Exception("Insira uma Data de Vencimento");
                }

                Pedido pedido = new Pedido();

                pedido.idPedido = !string.IsNullOrEmpty(txIdPedido.Text) ? Convert.ToInt32(txIdPedido.Text) : 0;

                pedido.idParceiro = Convert.ToInt32(txIdParceiro.Text);



                pedido.idEndereco = Convert.ToInt32(txIdEndereco.Text);

                if (cbTipoPedido.Text == "Pedido de Compra")
                {
                    pedido.tipoPedido = "PC";
                }
                else if (cbTipoPedido.Text == "Pedido de Venda")
                {
                    pedido.tipoPedido = "PV";
                }

                pedido.status = true;

                pedido.dataInsercao = (!txDataInsercao.Text.Equals("  /  /       :")) ? Convert.ToDateTime(txDataInsercao.Text) : DateTime.Now;

                pedido.dataVencimento = Convert.ToString(!txDataVencimento.Text.Equals("  /  /       :"));

                List<ItemPedido> itemPedido = new List<ItemPedido>();
                foreach (DataGridViewRow linha in dgListaItem.Rows)
                {
                    if (!string.IsNullOrEmpty(Convert.ToString(linha.Cells["nome"].Value)))
                    {
                        itemPedido.Add(new ItemPedido()
                        {
                            //adicionando os campos informados no grid, para os objetos da model
                            idItemPedido = Convert.ToInt32(linha.Cells["idItemPedido"].Value),
                            idPedido = 0,
                            nome = Convert.ToString(linha.Cells["nome"].Value),
                            quantidade = Convert.ToInt32(linha.Cells["quantidade"].Value),
                            valorUnitario = Convert.ToDouble(linha.Cells["valorUnitario"].Value),
                            valorTotal = Convert.ToDouble(linha.Cells["valorTotal"].Value),
                            status = Convert.ToBoolean(linha.Cells["status"].Value),
                            dataInsercao = DateTime.Now,
                        });
                    }
                }

                if (PedidoController.Gravar(pedido, itemPedido))
                {
                    txIdPedido.Text = pedido.idPedido.ToString();

                    string mensagem = "Sucesso ao gravar o Pedido: " + txIdPedido;
                    string titulo = "Sucesso.";
                    MessageBoxButtons botoes = MessageBoxButtons.OK;
                    MessageBoxIcon icone = MessageBoxIcon.Information;
                    MessageBox.Show(mensagem, titulo, botoes, icone);

                    Close();
                }
            }

            catch (Exception ex)
            {
                string mensagem = "Erro ao gravar o Pedido. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region AdicionarItem
        private void AdicionarItem()
        {
            try
            {
                string codigoItem = txIdItem.Text;

                if (!string.IsNullOrEmpty(codigoItem))
                {
                    if (dgListaItem.DataSource == null)
                    {
                        dgListaItem.Rows.Add();
                    }
                    else
                    {
                        ((BindingSource)(dgListaItem.DataSource)).AddNew();
                    }

                    dgListaItem.Rows[dgListaItem.Rows.Count - 2].Cells["id"].Value = codigoItem;
                    string nomeItem = ItemController.RetornaItem(Convert.ToInt32(codigoItem));
                    dgListaItem.Rows[dgListaItem.Rows.Count - 2].Cells["nome"].Value = nomeItem;
                    dgListaItem.Rows[dgListaItem.Rows.Count - 2].Cells["quantidade"].Value = 01;
                    double precoItem = ItemController.RetornaPreco(Convert.ToInt32(codigoItem));
                    dgListaItem.Rows[dgListaItem.Rows.Count - 2].Cells["valorVenda"].Value = precoItem;
                    dgListaItem.Rows[dgListaItem.Rows.Count - 2].Cells["valorTotal"].Value = precoItem;
                }
            }
            catch (Exception ex)
            {
                //exception ao dar entrada nas informações
                string mensagem = "Erro ao adicionar a lista de Item. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region EnderecoParceiro
        private void ConsultarEnderecoParceiro(int id)
        {
            try
            {
                BindingSource bindingSourceParceiro;

                bindingSourceParceiro = ParceiroNegocioController.ConsultarEndereco(id);

                cbEndereco.Items.Clear();
                cbEndereco.DataSource = bindingSourceParceiro;
                cbEndereco.DisplayMember = "logradouro";
                cbEndereco.ValueMember = "idEndereco";
                txIdEndereco.Text = id.ToString();
            }
            catch { }
        }
        #endregion
        #region Consultar
        private void Consultar(int id)
        {
            try
            {
                Item item = ItemController.Consultar(id);

                //txId.Text = item.id.ToString();

            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao consultar o Cadastro do Item. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        //Eventos
        #region btCadastrarNovoItem_Click
        private void btCadastrarNovoItem_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroItemView cadastroItem = new CadastroItemView();
                cadastroItem.StartPosition = FormStartPosition.CenterScreen;
                cadastroItem.Show();
            }
            catch (Exception ex)
            {
                //exception ao dar entrada nas informações
                string mensagem = "Erro ao abrir o cadastro do Item. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region cbEndereco_Enter
        private void cbEndereco_Enter(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txIdParceiro.Text))
                {
                    ConsultarEnderecoParceiro(0);
                }
                else
                {
                    ConsultarEnderecoParceiro(Convert.ToInt32(txIdParceiro.Text));
                }
            }
            catch { }
        }
        #endregion
        #region btAdicionarItem_Click
        private void btAdicionarItem_Click(object sender, EventArgs e)
        {
            AdicionarItem();
        }
        #endregion
        #region btListaItem_Click
        private void btListaItem_Click(object sender, EventArgs e)
        {
            try
            {
                string codigoItem = ListaItemView.Exibir();

                if (!string.IsNullOrEmpty(codigoItem))
                {
                    if (dgListaItem.DataSource == null)
                    {
                        dgListaItem.Rows.Add();
                    }
                    else
                    {
                        ((BindingSource)(dgListaItem.DataSource)).AddNew();
                    }

                    dgListaItem.Rows[dgListaItem.Rows.Count - 2].Cells["id"].Value = codigoItem;
                    string nomeItem = ItemController.RetornaItem(Convert.ToInt32(codigoItem));
                    dgListaItem.Rows[dgListaItem.Rows.Count - 2].Cells["nome"].Value = nomeItem;
                    dgListaItem.Rows[dgListaItem.Rows.Count - 2].Cells["quantidade"].Value = 01;
                    double precoItem = ItemController.RetornaPreco(Convert.ToInt32(codigoItem));
                    dgListaItem.Rows[dgListaItem.Rows.Count - 2].Cells["valorVenda"].Value = precoItem;
                    dgListaItem.Rows[dgListaItem.Rows.Count - 2].Cells["valorTotal"].Value = precoItem;
                }
            }
            catch (Exception ex)
            {
                //exception ao dar entrada nas informações
                string mensagem = "Erro ao abrir a lista de Item. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region btCadastrarFornecedor_Click
        private void btCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroParceiroNegocioView cadastroParceiro = new CadastroParceiroNegocioView();
                cadastroParceiro.StartPosition = FormStartPosition.CenterScreen;
                cadastroParceiro.Show();
            }
            catch (Exception ex)
            {
                //exception ao dar entrada nas informações
                string mensagem = "Erro ao abrir o cadastro de parceiro. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region btListaParceiros_Click
        private void btListaParceiros_Click(object sender, EventArgs e)
        {
            try
            {
                string codigoParceiro = ListaParceiroView.Exibir();

                if (!string.IsNullOrEmpty(codigoParceiro))
                {
                    string parceiro = ParceiroNegocioController.RetornaParceiro(Convert.ToInt32(codigoParceiro));
                    txIdParceiro.Text = codigoParceiro;
                    txParceiro.Text = parceiro;
                }
            }
            catch (Exception ex)
            {
                //exception ao dar entrada nas informações
                string mensagem = "Erro ao abrir a lista de Parceiros. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region btSalvar_Click
        private void btSalvar_Click(object sender, EventArgs e)
        {
            Gravar();
        }
        #endregion
    }
}
