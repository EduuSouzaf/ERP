using SB1.ProjTest.Controller;
using SB1.ProjTest.Model;
using SB1.ProjTest.Relatorio;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace SB1.ProjTest.View
{
    public partial class CadastroItemView : Form
    {
        //construtor
        #region CadastroItemView
        public CadastroItemView()
        {
            InitializeComponent();
            ConsultarIdItem();
            ConsultarUnidadeMedida(null);
            ConsultarMarca(null);
            ConsultarCategoria(null);
        }
        #endregion
        #region CadastroItemView
        public CadastroItemView(int id)
        {
            InitializeComponent(); 
            Consultar(id);
        }
        #endregion
        //Métodos
        #region ConsultarIdItem
        public void ConsultarIdItem()
        {
            int idItem = ItemController.ConsultarIdItem();
            txId.Text = Convert.ToString(idItem);
        }
        #endregion
        #region Consultar
        private void Consultar(int id)
        {
            try
            {
                //Populando os campos de Item
                Item item = ItemController.Consultar(id);
                txId.Text = item.id.ToString();
                txNome.Text = item.nome;
                txFornecedor.Text = item.fornecedor;
                txDescricaoItem.Text = item.descricao;
                dtDataInsercao.Value = Convert.ToDateTime(item.dataInsercao);

                //Populando os campos de preco
                TabelaPreco preco = TabelaPrecoController.Consultar(id);
                txValorCompra.Text = preco.precoCusto.ToString(CultureInfo.InvariantCulture);
                txValorMinimo.Text = preco.precoMinimo.ToString(CultureInfo.InvariantCulture);
                txValorVenda.Text = preco.precoVenda.ToString(CultureInfo.InvariantCulture);
                txMargemLucro.Text = preco.margemLucro.ToString(CultureInfo.InvariantCulture);
                txLucroTotal.Text = preco.lucroTotal.ToString(CultureInfo.InvariantCulture);

                //Populando os campos de estoque
                MovimentoEstoque estoque = MovimentoEstoqueController.Consultar(id);
                txTotalEstoque.Text = estoque.totalEstoque.ToString(CultureInfo.InvariantCulture);
                txTotalEstoqueVenda.Text = estoque.totalEstoqueVenda.ToString(CultureInfo.InvariantCulture);
                double totaEstoque = MovimentoEstoqueController.ConsultarTotalEstoque(id);
                txTotalEstoque.Text = totaEstoque.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
                double totaEstoqueVenda = MovimentoEstoqueController.ConsultarTotalEstoqueVenda(id);
                txTotalEstoqueVenda.Text = totaEstoqueVenda.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
                txQuantidade.Text = Convert.ToString(MovimentoEstoqueController.ConsultarEstoque(id));

                //Populando a ComboBox de Categoria
                ConsultarCategoria(item.codCategoria);

                //Populando a ComboBox da Unidade de Medida
                ConsultarUnidadeMedida(item.unidadeMedida);

                //Populando a ComboBox da Marca
                ConsultarMarca(item.marca);

                //Definições de bloqueio de alguns campos
                txQuantidade.ReadOnly = true;
                txQuantidade.Enabled = false;
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
        #region Gravar
        private void Gravar()
        {
            try
            {

                if (string.IsNullOrEmpty(txNome.Text))
                {
                    throw new Exception("insira um nome para o item. ");
                }
                if (string.IsNullOrEmpty(txQuantidade.Text))
                {
                    throw new Exception("insira uma quantidade inicial para o item. ");
                }
                if (string.IsNullOrEmpty(txValorCompra.Text))
                {
                    throw new Exception("insira o valor de compra do item. ");
                }
                if (string.IsNullOrEmpty(txValorVenda.Text))
                {
                    throw new Exception("insira o valor de venda do item. ");
                }
                if (string.IsNullOrEmpty(txFornecedor.Text))
                {
                    throw new Exception("insira um fornecedor para o item. ");
                }
                if (string.IsNullOrEmpty(cbUnidadeMedida.Text))
                {
                    throw new Exception("insira uma unidade de medida para o item. ");
                }
                if (string.IsNullOrEmpty(txDescricaoItem.Text))
                {
                    throw new Exception("insira uma descrição para o item. ");
                }
                if (string.IsNullOrEmpty(cbCategoria.Text))
                {
                    throw new Exception("insira uma categoria para o item. ");
                }
                if (string.IsNullOrEmpty(txValorMinimo.Text))
                {
                    throw new Exception("insira um valor mínimo para o item. ");
                }

                //Gravando o Item
                Item item = new Item();

                string idItem = Convert.ToString(ItemController.VerificaIdItem(Convert.ToInt32(txId.Text)));
                item.id = !string.IsNullOrEmpty(idItem) ? Convert.ToInt32(idItem) : 0;
                item.nome = txNome.Text;
                item.fornecedor = txFornecedor.Text;
                item.descricao = txDescricaoItem.Text;

                //seleciona o valor da combo box
                string marca = cbMarca.SelectedValue.ToString();
                item.marca = marca;
                string unidMedida = cbUnidadeMedida.SelectedValue.ToString();
                item.unidadeMedida = unidMedida;
                string codCategoria = cbCategoria.SelectedValue.ToString();
                item.codCategoria = codCategoria;

                item.dataInsercao = DateTime.Now;

                //insercao Tabela Movimento de Estoque
                MovimentoEstoque estoque = new MovimentoEstoque();

                int id = Convert.ToInt32(txId.Text);
                estoque.id = ItemController.RetornaIdMovimento(id);
                estoque.idItem = id;
                estoque.quantidade = Convert.ToInt32(txQuantidade.Text);
                estoque.totalEstoque = Convert.ToDouble(txTotalEstoque.Text.Replace("R$ ", " "));
                estoque.totalEstoqueVenda = Convert.ToDouble(txTotalEstoqueVenda.Text.Replace("R$ ", " "));
                double estoqueVenda = Convert.ToDouble(txTotalEstoqueVenda.Text.Replace("R$ ", " "));
                double totalEstoque = Convert.ToDouble(txTotalEstoque.Text.Replace("R$ ", " "));

                double total = estoqueVenda - totalEstoque;
                estoque.LucroEstoque = total;
                var unidadesVendidas = MovimentoEstoqueController.ConsultarUnidadesVendidas(id);
                estoque.unidadesVendidas = unidadesVendidas;
                estoque.dataInsercao = DateTime.Now;
                estoque.dataAtualizacao = DateTime.Now;

                //Insercao Tabela de preco
                var preco = new TabelaPreco();
                int idItemPreco = Convert.ToInt32(txId.Text);
                int idPreco = TabelaPrecoController.ConsultarId(idItemPreco);
                preco.idTabelaPreco = idPreco;
                preco.idItem = idItemPreco;
                preco.precoCusto = Convert.ToDouble(txValorCompra.Text.Replace("R$ ", " "));
                preco.precoMinimo = Convert.ToDouble(txValorMinimo.Text.Replace("R$ ", " "));
                preco.precoVenda = Convert.ToDouble(txValorVenda.Text.Replace("R$ ", " "));
                preco.margemLucro = Convert.ToDouble(txMargemLucro.Text.Replace("R$ ", " "));
                preco.lucroTotal = Convert.ToDouble(txLucroTotal.Text.Replace("R$ ", " "));
                preco.dataInsercao = DateTime.Now;
                preco.dataAtualizacao = DateTime.Now;

                preco.dataInsercao = DateTime.Now;

                //Gravacao tabela de Item, estoque e preco
                if (ItemController.Gravar(item, estoque, preco))
                {
                    txId.Text = item.id.ToString();

                    string mensagem = "Sucesso ao gravar o item: " + item.id.ToString() + " - " + item.nome;
                    string titulo = "Sucesso.";
                    MessageBoxButtons botoes = MessageBoxButtons.OK;
                    MessageBoxIcon icone = MessageBoxIcon.Information;
                    MessageBox.Show(mensagem, titulo, botoes, icone);
                }
            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao gravar o item. Erro: " + ex.Message;
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
                if (!string.IsNullOrEmpty(txId.Text))
                {
                    RelatorioItem relatorio = new RelatorioItem();
                    relatorio.SetParameterValue("item", txId.Text);

                    rvRelatorio childForm = new rvRelatorio(relatorio);
                    childForm.Show();
                }
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
        #region UnidadeMedida
        private void ConsultarUnidadeMedida(string codigo)
        {
            try
            {
                BindingSource bindingSourceUnidadeMedida = UnidadeMedidaController.Consultar(codigo);

                cbUnidadeMedida.DataSource = bindingSourceUnidadeMedida;
                cbUnidadeMedida.DisplayMember = "unidadeMedida";
                cbUnidadeMedida.ValueMember = "codigo";

            }
            catch
            {
                // ignored
            }
        }
    #endregion
        #region categoria
        private void ConsultarCategoria(string codigo)
        {
            try
            {
                BindingSource bindingSourceCategoria = CategoriaController.Consultar(codigo);

                // Criar uma nova instância do ComboBox
                cbCategoria.DataSource = bindingSourceCategoria;
                cbCategoria.DisplayMember = "categoria";
                cbCategoria.ValueMember = "codigo";
            }
            catch
            {
                // ignored
            }
        }
        #endregion
        #region Marca
        private void ConsultarMarca(string codigo)
        {
            try
            {
                BindingSource bindingSourceMarca = MarcaController.Consultar(codigo);

                cbMarca.DataSource = bindingSourceMarca;
                cbMarca.DisplayMember = "marca";
                cbMarca.ValueMember = "codigo";

            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao consultar o Cadastro de Marcas. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region ApenasNumero
        private void ApenasNumero(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;
                string mensagem = "Este campo aceita apenas números.";
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
                string mensagem = "Este campo aceita apenas números e virgula.";
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
            if ((e.KeyChar == ',') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                string mensagem = "Este campo aceita somente uma vírgula.";
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region ApenasLetras
        private void ApenasLetras(KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
                string mensagem = "Este campo aceita apenas letras.";
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Warning;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        // Eventos
        #region txQuantidade_KeyPress
        private void txQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumero(sender, e);
        }
        #endregion
        #region btExit_Click
        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        #region cbCusto_KeyPress
        private void cbCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumero(sender, e);
        }
        #endregion
        #region txValorCompra_MouseClick
        private void txValorCompra_MouseClick(object sender, MouseEventArgs e)
        {
            txValorCompra.SelectAll();
        }
        #endregion
        #region txValorVenda_MouseClick
        private void txValorVenda_MouseClick(object sender, MouseEventArgs e)
        {
            txValorVenda.SelectAll();
        }
        #endregion
        #region txValorVenda_MouseDoubleClick
        private void txValorVenda_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txValorVenda.SelectAll();
        }
        #endregion
        #region txValorCompra_MouseDoubleClick
        private void txValorCompra_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txValorCompra.SelectAll();
        }
        #endregion
        #region btImprimir_Click
        private void btImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
        #endregion
        #region btCadastrar_Click
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Gravar();
        }
        #endregion
        #region btCancelar_Click
        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        #region txValorVenda_KeyPress
        private void txValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumeroVirgula(sender, e);
        }
        #endregion
        #region txValorCompra_KeyPress
        private void txValorCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumeroVirgula(sender, e);
        }
        #endregion
        #region txValorMinimo_KeyPress
        private void txValorMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumeroVirgula(sender, e);
        }
        #endregion
        #region txCategoria_KeyPress
        private void txCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasLetras(e);
        }
        #endregion
        #region txMarca_KeyPress
        private void txMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasLetras(e);
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
                    txFornecedor.Text = parceiro;
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
        #region txValorVenda
        private void txValorVenda_Leave(object sender, EventArgs e)
        {
            try
            {
                // Total margem de lucro
                double lucro = Convert.ToDouble(txValorVenda.Text) - Convert.ToDouble(txValorCompra.Text);

                txMargemLucro.Text = lucro.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));

                // Total estoque venda
                double total = Convert.ToInt32(txQuantidade.Text) * Convert.ToDouble(txValorVenda.Text);

                txTotalEstoqueVenda.Text = total.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));

                // Total lucro estoque
                double calc = Convert.ToDouble(txValorVenda.Text) - Convert.ToDouble(txValorCompra.Text);
                double lucroTotal = calc * Convert.ToInt32(txQuantidade.Text);

                txLucroTotal.Text = lucroTotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
                
            }
            catch (Exception)
            {
                //exception ao dar entrada nas informações
                string mensagem = "Preecha o campo quantidade! ";
                string titulo = "Alerta.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Warning;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region txValorCompra
        private void txValorCompra_Leave(object sender, EventArgs e)
        {
            try
            {
                // total estoque
                double total = Convert.ToInt32(txQuantidade.Text) * Convert.ToDouble(txValorCompra.Text);

                txTotalEstoque.Text = total.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
            }
            catch (Exception)
            {
                //exception ao dar entrada nas informações
                string mensagem = "Preecha o campo quantidade! ";
                string titulo = "Alerta.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Warning;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region txQuantidade
        private void txQuantidade_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txValorCompra.Text) && (!string.IsNullOrEmpty(txValorVenda.Text)))
                {
                    // total estoque
                    double total = Convert.ToInt32(txQuantidade.Text) * Convert.ToDouble(txValorCompra.Text);

                    txTotalEstoque.Text = total.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));

                    // Total estoque venda
                    double totalVenda = Convert.ToInt32(txQuantidade.Text) * Convert.ToDouble(txValorVenda.Text);

                    txTotalEstoqueVenda.Text = totalVenda.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
                }
                else if (!string.IsNullOrEmpty(txValorCompra.Text) && (string.IsNullOrEmpty(txValorVenda.Text)))
                {
                    // total estoque
                    double total = Convert.ToInt32(txQuantidade.Text) * Convert.ToDouble(txValorCompra.Text);

                    txTotalEstoque.Text = total.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
                }
                else if (string.IsNullOrEmpty(txValorCompra.Text) && (!string.IsNullOrEmpty(txValorVenda.Text)))
                {
                    // Total estoque venda
                    double totalVenda = Convert.ToInt32(txQuantidade.Text) * Convert.ToDouble(txValorVenda.Text);

                    txTotalEstoqueVenda.Text = totalVenda.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
                }
                else
                {
                    txTotalEstoque.Text = "0";
                    txTotalEstoqueVenda.Text = "0";
                }
            }
            catch (Exception ex)
            {
                //exception ao dar entrada nas informações
                string mensagem = "Erro em calcular o Estoque. Erro: " + ex.Message;
                string titulo = "Alerta.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Warning;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
    }
}
