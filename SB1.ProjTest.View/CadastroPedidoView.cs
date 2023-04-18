using SB1.ProjTest.Controller;
using SB1.ProjTest.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace SB1.ProjTest.View
{
    public partial class CadastroPedidoView : Form
    {
        //Construtores

        #region CadastroPedidoView

        public CadastroPedidoView()
        {
            InitializeComponent();
            PedidoAberto();
        }

        #endregion

        public CadastroPedidoView(int id)
        {
            InitializeComponent();
            VerificaStatus(id);
            Consultar(id);
        }

        //Métodos

        #region Consultar

        private void Consultar(int id)
        {
            try
            {
                Pedido pedido = PedidoController.Consultar(id);

                ParceiroNegocio parceiro = ParceiroNegocioController.Consultar(pedido.idParceiro);

                ParceiroNegocioController.ConsultarEndereco(pedido.idParceiro, pedido.idEndereco);

                BindingSource bsItem = PedidoController.ConsultaListaItem(pedido.idPedido);

                txIdPedido.Text = pedido.idPedido.ToString();

                cbTipoPedido.DisplayMember = pedido.tipoPedido;

                if (pedido.tipoPedido.Equals("PV"))
                {
                    cbTipoPedido.Text = "Pedido de Venda";
                }
                else if (pedido.tipoPedido.Equals("PC"))
                {
                    cbTipoPedido.Text = "Pedido de Compra";
                }

                txStatus.Text = pedido.status;

                txIdParceiro.Text = parceiro.id.ToString();

                txParceiro.Text = parceiro.nome;

                DtDataInsercao.Value = Convert.ToDateTime(pedido.dataInsercao);

                DtDataVencimento.Value = Convert.ToDateTime(pedido.dataVencimento);

                txTotal.Text = pedido.totalNota.ToString(CultureInfo.InvariantCulture);

                dgListaItem.DataSource = bsItem;
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

        #region Gravar

        private void Gravar()
        {
            try
            {
                //Instanciando as classes
                TabelaPreco preco = new TabelaPreco();
                List<MovimentoEstoque> movimentosEstoque = new List<MovimentoEstoque>();
                List<ItemPedido> itemPedido = new List<ItemPedido>();

                //Validações
                if (string.IsNullOrEmpty(cbTipoPedido.Text))
                {
                    throw new Exception("Selecione o tipo de pedido ");
                }

                if (string.IsNullOrEmpty(txParceiro.Text))
                {
                    throw new Exception("Insira um Cliente/Fornecedor ");
                }

                if (string.IsNullOrEmpty(cbEndereco.Text))
                {
                    throw new Exception("Selecione um Endereço ");
                }

                if (dgListaItem.SelectedRows.Count != 0)
                {
                    throw new Exception("Insira um Item ");
                }

                //Inserindo os valores na tabela Pedido
                Pedido pedido = Pedido();

                //Percorre o grid para inserir os valores na tabela ItemPedido e MovimentoEstoque
                foreach (DataGridViewRow linha in dgListaItem.Rows)
                {
                    if (linha.Cells["nome"].Value != null && !string.IsNullOrEmpty(linha.Cells["nome"].Value.ToString()))
                    {
                        //pegando os valores
                        int idItem = Convert.ToInt32(linha.Cells["idItem"].Value);
                        string nome = Convert.ToString(linha.Cells["nome"].Value);
                        int quantidadeItemPedido = Convert.ToInt32(linha.Cells["quantidade"].Value);
                        double valorUnitario = Convert.ToDouble(linha.Cells["valorUnitario"].Value);
                        double valorTotal = Convert.ToDouble(linha.Cells["valorTotal"].Value);
                        Boolean status = Convert.ToBoolean(linha.Cells["status"].Value);

                        int estoque;
                        string statusPedido = txStatus.Text;
                        int consultaEstoque = Convert.ToInt32(MovimentoEstoqueController.ConsultarEstoque(idItem));
                        int consultaIdMovimento = ItemController.RetornaIdMovimento(idItem);
                        int consultaUnidadesVendidas = MovimentoEstoqueController.ConsultarUnidadesVendidas(idItem);
                        double consultaPrecoCusto = TabelaPrecoController.ConsultarPrecoCusto(idItem);
                        double consultaPrecoVenda = TabelaPrecoController.ConsultarPrecoVenda(idItem);

                        //inserindo os dados e validando
                        itemPedido = ItemPedidoList(idItem, nome, quantidadeItemPedido, valorUnitario, valorTotal, status);

                        //movimento o estoque de acordo com o tipo de pedido
                        if (cbTipoPedido.Text == "Pedido de Compra")
                        {
                            string tipoPedido = "Pedido de Compra";

                            movimentosEstoque = MovimentoEstoqueList(tipoPedido, consultaIdMovimento, idItem, consultaUnidadesVendidas, consultaEstoque, quantidadeItemPedido, consultaPrecoCusto, consultaPrecoVenda, statusPedido);
                        }
                        else if (cbTipoPedido.Text == "Pedido de Venda")
                        {
                            string tipoPedido = "Pedido de Venda";

                            if (consultaEstoque > 0)
                            {
                                movimentosEstoque = MovimentoEstoqueList(tipoPedido, consultaIdMovimento, idItem, consultaUnidadesVendidas, consultaEstoque, quantidadeItemPedido, consultaPrecoCusto, consultaPrecoVenda, statusPedido);
                            }
                            else
                            {
                                throw new Exception("Item com estoque insuficiente: " + idItem);
                            }
                        }
                    }
                }
                if (PedidoController.Gravar(pedido, itemPedido) &&
                    MovimentoEstoqueController.GravarList(movimentosEstoque))
                {

                    txIdPedido.Text = pedido.idPedido.ToString();

                    string codigo = txIdPedido.Text;

                    string mensagem = "Sucesso ao gravar o Pedido: " + codigo;
                    string titulo = "Sucesso.";
                    MessageBoxButtons botoes = MessageBoxButtons.OK;
                    MessageBoxIcon icone = MessageBoxIcon.Information;
                    MessageBox.Show(mensagem, titulo, botoes, icone);

                    VerificaStatus(Convert.ToInt32(codigo));
                }
            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao gravar o Pedido. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Warning;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }

        #endregion
        #region Pedido
        private Pedido Pedido()
        {
            //tirando formatação de moeda do campo
            string valorFormatado = Convert.ToString(txTotal.Text);
            double valorSemFormato = double.Parse(valorFormatado, NumberStyles.Currency, new CultureInfo("pt-BR"));
            double total = valorSemFormato;
            DateTime dataVence = DtDataVencimento.Value;
            DateTime dataInser = DtDataInsercao.Value;

            var pedido = new Pedido
            {
                tipoPedido = cbTipoPedido.Text == "Pedido de Compra" ? "PC" : "PV",
                idPedido = !string.IsNullOrEmpty(txIdPedido.Text) ? Convert.ToInt32(txIdPedido.Text) : 0,
                idParceiro = Convert.ToInt32(txIdParceiro.Text),
                totalNota = total,
                status = txStatus.Text,
                dataInsercao = dataInser,
                dataVencimento = dataVence
            };
            return pedido;
        }
        #endregion
        #region ItemPedido
        private List<ItemPedido> ItemPedidoList(int idItem, string nome, int quantidade, double valorUnitario, double valorTotal, Boolean status)
        {
            List<ItemPedido> itemPedidos = new List<ItemPedido>
            {
                new ItemPedido()
                {
                    //adicionando os campos informados no grid, para os objetos
                    idItem = idItem,
                    idPedido = 0,
                    nome = nome,
                    quantidade = quantidade,
                    valorUnitario = valorUnitario,
                    valorTotal = valorTotal,
                    status = status,
                    dataInsercao = DateTime.Now,
                }
            };

            return itemPedidos;
        }
        #endregion
        #region MovimentoEstoqueList
        private List<MovimentoEstoque> MovimentoEstoqueList(string tipoPedido, int consultaIdMovimento, int idItem, int consultaUnidadesVendidas, int consultaEstoque, int quantidadeItemPedido, double consultaPrecoCusto, double consultaPrecoVenda, string statusPedido)
        {
            List<MovimentoEstoque> estoqueList = new List<MovimentoEstoque>();
            int estoque;
            //movimento o estoque de acordo com o tipo de pedido
            if (tipoPedido.Equals("Pedido de Compra"))
            {
                if (statusPedido.Equals("Cancelado"))
                {
                    estoque = consultaEstoque - quantidadeItemPedido;

                    double totalEstoque = estoque * consultaPrecoCusto;
                    double totalEstoqueVenda = estoque * consultaPrecoVenda;
                    double lucro = consultaPrecoVenda - consultaPrecoCusto;

                    estoqueList.Add(new MovimentoEstoque()
                    {
                        id = consultaIdMovimento,
                        idItem = idItem,
                        quantidade = estoque,
                        totalEstoque = totalEstoque,
                        totalEstoqueVenda = totalEstoqueVenda,
                        LucroEstoque = lucro,
                        dataAtualizacao = DateTime.Now,
                        dataInsercao = DateTime.Now,
                        unidadesVendidas = consultaUnidadesVendidas
                    });
                }
                else
                {
                    estoque = consultaEstoque + quantidadeItemPedido;

                    double totalEstoque = estoque * consultaPrecoCusto;
                    double totalEstoqueVenda = estoque * consultaPrecoVenda;
                    double lucro = consultaPrecoVenda - consultaPrecoCusto;

                    estoqueList.Add(new MovimentoEstoque()
                    {
                        id = consultaIdMovimento,
                        idItem = idItem,
                        quantidade = estoque,
                        totalEstoque = totalEstoque,
                        totalEstoqueVenda = totalEstoqueVenda,
                        LucroEstoque = lucro,
                        dataAtualizacao = DateTime.Now,
                        dataInsercao = DateTime.Now,
                        unidadesVendidas = consultaUnidadesVendidas
                    });
                }
            }
            else if (tipoPedido.Equals("Pedido de Venda"))
            {
                if (statusPedido.Equals("Cancelado"))
                {
                    estoque = consultaEstoque + quantidadeItemPedido;

                    consultaUnidadesVendidas += quantidadeItemPedido;

                    double totalEstoque = estoque * consultaPrecoCusto;
                    double totalEstoqueVenda = estoque * consultaPrecoVenda;
                    double lucro = consultaPrecoVenda - consultaPrecoCusto;

                    estoqueList.Add(new MovimentoEstoque()
                    {
                        id = consultaIdMovimento,
                        idItem = idItem,
                        quantidade = estoque,
                        totalEstoque = totalEstoque,
                        totalEstoqueVenda = totalEstoqueVenda,
                        LucroEstoque = lucro,
                        dataAtualizacao = DateTime.Now,
                        dataInsercao = DateTime.Now,
                        unidadesVendidas = consultaUnidadesVendidas
                    });
                }
                else
                {
                    estoque = consultaEstoque - quantidadeItemPedido;

                    consultaUnidadesVendidas += quantidadeItemPedido;

                    double totalEstoque = estoque * consultaPrecoCusto;
                    double totalEstoqueVenda = estoque * consultaPrecoVenda;
                    double lucro = consultaPrecoVenda - consultaPrecoCusto;

                    estoqueList.Add(new MovimentoEstoque()
                    {
                        id = consultaIdMovimento,
                        idItem = idItem,
                        quantidade = estoque,
                        totalEstoque = totalEstoque,
                        totalEstoqueVenda = totalEstoqueVenda,
                        LucroEstoque = lucro,
                        dataAtualizacao = DateTime.Now,
                        dataInsercao = DateTime.Now,
                        unidadesVendidas = consultaUnidadesVendidas
                    });
                }

            }
            return estoqueList;
        }
        #endregion
        #region VerificaStatus
        private void VerificaStatus(int id)
        {
            Pedido pedido = PedidoController.Consultar(id);

            var verifificaStatus = pedido.status;

            if (verifificaStatus == "Aberto")
            {
                btFinalizarPedido.Enabled = true;
                btCancelarPedido.Enabled = true;
            }
            else if (verifificaStatus == "Atendido")
            {
                CancelarEFinalizarPedido();
            }
            else if (verifificaStatus.Equals("Cancelado"))
            {
                CancelarEFinalizarPedido();
            }

        }
        #endregion
        #region PedidoAberto
        private void PedidoAberto()
        {
            var status = "Aberto";
            txStatus.Text = status;
            btFinalizarPedido.Enabled = false;
            btCancelarPedido.Enabled = false;
        }
        #endregion
        #region AdicionarItem
        private void AdicionarItem()
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

                    dgListaItem.Rows[dgListaItem.Rows.Count - 2].Cells["idItem"].Value = codigoItem;
                    string nomeItem = ItemController.RetornaIdItem(Convert.ToInt32(codigoItem));
                    dgListaItem.Rows[dgListaItem.Rows.Count - 2].Cells["nome"].Value = nomeItem;
                    dgListaItem.Rows[dgListaItem.Rows.Count - 2].Cells["quantidade"].Value = 01;

                    //Preco do Item
                    double precoCusto = TabelaPrecoController.ConsultarPrecoCusto(Convert.ToInt32(codigoItem));
                    double precoVenda = TabelaPrecoController.ConsultarPrecoVenda(Convert.ToInt32(codigoItem));
                    dgListaItem.Rows[dgListaItem.Rows.Count - 2].Cells["valorUnitario"].Value = precoCusto;
                    dgListaItem.Rows[dgListaItem.Rows.Count - 2].Cells["valorTotal"].Value = precoVenda;
                    dgListaItem.Rows[dgListaItem.Rows.Count - 2].Cells["status"].Value = true;
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
        #region AdicionarItemDg
        private void AdicionarItemDg(int id)
        {
            try
            {

                //Nome do item
                string nomeItem = ItemController.RetornaIdItem(Convert.ToInt32(id));
                dgListaItem.Rows[dgListaItem.Rows.Count - 2].Cells["nome"].Value = nomeItem;

                //Quantidade
                dgListaItem.Rows[dgListaItem.Rows.Count - 2].Cells["quantidade"].Value = 01;

                //Preco do Item
                double precoCusto = TabelaPrecoController.ConsultarPrecoCusto(Convert.ToInt32(id));
                double precoVenda = TabelaPrecoController.ConsultarPrecoVenda(Convert.ToInt32(id));
                dgListaItem.Rows[dgListaItem.Rows.Count - 2].Cells["valorUnitario"].Value = precoCusto;
                dgListaItem.Rows[dgListaItem.Rows.Count - 2].Cells["valorTotal"].Value = precoVenda;
                dgListaItem.Rows[dgListaItem.Rows.Count - 2].Cells["status"].Value = true;
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
        #region ColunaTotal
        private void ColunaTotal()
        {
            double total = 0;
            for (int i = 0; i < dgListaItem.Rows.Count; i++)
            {
                total += Convert.ToDouble(dgListaItem.Rows[i].Cells["valorTotal"].Value);
            }

            txTotal.Text = total.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
        }
        #endregion
        #region EnderecoParceiro
        private void ConsultarEnderecoParceiro(int id)
        {
            try
            {
                BindingSource bindingSourceParceiro = ParceiroNegocioController.ConsultarEndereco(id);

                cbEndereco.Items.Clear();
                cbEndereco.DataSource = bindingSourceParceiro;
                cbEndereco.DisplayMember = "logradouro";
                cbEndereco.ValueMember = "idEndereco";
                txIdEndereco.Text = id.ToString();
            }
            catch
            {
                // ignored
            }
        }
        #endregion
        #region ExcluirItemPedido
        public void ExcluirItemPedido()
        {
            try
            {
                if (dgListaItem.SelectedRows.Count != 0)
                {
                    int idItem = Convert.ToInt32(dgListaItem.Rows[dgListaItem.SelectedRows[0].Index].Cells["idItem"].Value);
                    int idPedido = !string.IsNullOrEmpty(txIdPedido.Text) ? Convert.ToInt32(txIdPedido.Text) : 0;

                    string mensagem = "Tem certeza que deseja excluir o item: " + idItem.ToString();
                    string titulo = "Aviso";
                    MessageBoxButtons botoes = MessageBoxButtons.YesNo;
                    MessageBoxIcon icone = MessageBoxIcon.Warning;
                    DialogResult resultado = MessageBox.Show(mensagem, titulo, botoes, icone);

                    if (resultado == DialogResult.Yes)
                    {
                        if (idItem != 0 && idPedido != 0)
                        {
                            ItemPedido itemPedido = PedidoController.ConsultarItemPedido(idItem);

                            PedidoController.ExcluirItemPedido(itemPedido);
                        }

                        dgListaItem.Rows.RemoveAt(dgListaItem.SelectedRows[0].Index);

                        mensagem = "Sucesso ao excluir o item: " + idItem;
                        titulo = "Sucesso. ";
                        botoes = MessageBoxButtons.OK;
                        icone = MessageBoxIcon.Information;
                        MessageBox.Show(mensagem, titulo, botoes, icone);
                    }
                }
                else
                {
                    string mensagem = "Selecione uma linha no grid";
                    string titulo = "Aviso. ";
                    MessageBoxButtons botoes = MessageBoxButtons.OK;
                    MessageBoxIcon icone = MessageBoxIcon.Warning;
                    MessageBox.Show(mensagem, titulo, botoes, icone);
                }
            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao excluir o Item. Erro: " + ex.Message;
                string titulo = "Erro. ";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region CancelarPedido
        private void CancelarEFinalizarPedido()
        {
            dgListaItem.ReadOnly = true;
            dgListaItem.Enabled = false;

            cbTipoPedido.Enabled = false;
            cbEndereco.Enabled = false;
            btCadastrarItem.Enabled = false;
            btListaParceiros.Enabled = false;
            btListaItem.Enabled = false;
            btEcluirItem.Enabled = false;
            btCancelarPedido.Enabled = false;
            btSalvar.Enabled = false;

            btFinalizarPedido.Enabled = false;

            txTotal.Enabled = false;
            txTotal.ReadOnly = true;

            txIdParceiro.ReadOnly = true;
            txIdParceiro.Enabled = false;

            txParceiro.ReadOnly = true;
            txParceiro.Enabled = false;

            txStatus.ReadOnly = true;
            txStatus.Enabled = false;

            DtDataInsercao.Enabled = false;
            DtDataVencimento.Enabled = false;

        }
        #endregion
        //validações
        #region ApenasNumero
        private void ApenasNumero(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            { 

                e.Handled = true;
                string mensagem = "Este campo aceita apenas números. "; ;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Warning;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region NumeroVirgula
        private void NumeroVirgula(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                string mensagem = "Este campo aceita apenas números e virgula."; ;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
            if ((e.KeyChar == ',') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                string mensagem = "Este campo aceita somente uma vírgula."; ;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region ApenasLetras
        private void ApenasLetras(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
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
        #region btAdicionarItem_Click
        private void btAdicionarItem_Click(object sender, EventArgs e)
        {
            AdicionarItem();
        }
        #endregion
        #region btListaItem_Click
        private void btListaItem_Click(object sender, EventArgs e)
        {
            AdicionarItem();
            ColunaTotal();
        }
        #endregion
        #region btSalvar_Click
        private void btSalvar_Click(object sender, EventArgs e)
        {
            Gravar();
            TelaPrincipalView telaPrincipalView = new TelaPrincipalView();
            telaPrincipalView.UnidadeVendidas();
            telaPrincipalView.MaiorLucro();
        }
        #endregion
        #region dgListaItem_CellEndEdit
        private void dgListaItem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {   
            if (e.ColumnIndex == dgListaItem.Rows[0].Cells["idItem"].ColumnIndex) 
            {
                DataGridViewCell idItemCell = dgListaItem.CurrentRow.Cells["idItem"];

                // Obtém o valor da célula "idItem"
                object valor = idItemCell.Value;

                // Converte o valor para um tipo apropriado, como um int, se necessário
                int idItem = Convert.ToInt32(valor);

                AdicionarItemDg(idItem);
            }

            int quantidade = Convert.ToInt32(dgListaItem.Rows[e.RowIndex].Cells["quantidade"].Value);
            double valorVenda = Convert.ToDouble(dgListaItem.Rows[e.RowIndex].Cells["valorUnitario"].Value);

            dgListaItem.Rows[e.RowIndex].Cells["ValorTotal"].Value = quantidade * valorVenda;

            ColunaTotal();
        }
        #endregion
        #region dgListaItem_CellMouseDoubleClick
        private void dgListaItem_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AdicionarItem();
        }
        #endregion
        #region txDataVencimento_KeyPress
        private void txDataVencimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumero(sender, e);
        }
        #endregion
        #region txIdItem_KeyPress
        private void txIdItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumero(sender, e);
        }
        #endregion
        #region dgListaItem_EditingControlShowing
        private void dgListaItem_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(ColumnsInt_KeyPress);
        }
        #endregion
        #region ColumnsInt_KeyPress
        private void ColumnsInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        #endregion
        #region btEcluirItem_Click
        private void btEcluirItem_Click(object sender, EventArgs e)
        {
            ExcluirItemPedido();
        }
        #endregion
        #region btCancelarPedido
        private void btCancelarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                string mensagem = "Deseja realmente cancelar o pedido ? ";
                string titulo = "Alerta.";
                MessageBoxButtons botoes = MessageBoxButtons.YesNo;
                MessageBoxIcon icone = MessageBoxIcon.Question;
                DialogResult resultado = MessageBox.Show(mensagem, titulo, botoes, icone);

                if (resultado == DialogResult.Yes)
                {
                    txStatus.Text = "Cancelado";

                    Gravar();
                }
            }
            catch (Exception ex)
            {
                //exception ao dar entrada nas informações
                string mensagem = "Erro ao cancelar o Pedido. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region btListaParceiros
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
        #region txParceiro
        private void txParceiro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cbEndereco.Items.Clear();

                if (string.IsNullOrEmpty(txParceiro.Text))
                {
                    ConsultarEnderecoParceiro(0);
                }
                else
                {
                    int idParceiro;
                    if (int.TryParse(txIdParceiro.Text, out idParceiro))
                    {
                        ConsultarEnderecoParceiro(idParceiro);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        #region btFinalizarPedido
        private void btFinalizarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                string mensagem = "Deseja realmente finalizar o pedido ? ";
                string titulo = "Alerta.";
                MessageBoxButtons botoes = MessageBoxButtons.YesNo;
                MessageBoxIcon icone = MessageBoxIcon.Question;
                DialogResult resultado = MessageBox.Show(mensagem, titulo, botoes, icone);

                if (resultado == DialogResult.Yes)
                {
                    txStatus.Text = "Atendido";

                    Gravar();
                }
            }
            catch (Exception ex)
            {
                //exception ao dar entrada nas informações
                string mensagem = "Erro ao finalizar o Pedido. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
    }
}
