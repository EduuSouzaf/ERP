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
using System.Web.UI.WebControls;
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
        #region Consultar
        private void Consultar(int id)
        {
            try
            {
                Item item = ItemController.Consultar(id);

                txId.Text = item.id.ToString();

                txNome.Text = item.nome;

                txFornecedor.Text = item.fornecedor;

                txQuantidade.Text = item.quantidade.ToString();

                txCategoria.Text = item.categoria;

                txDescricaoItem.Text = item.descricao;

                cbCusto.Text = item.custo.ToString();

                txValorCompra.Text = item.valorCompra.ToString();

                txValorMinimo.Text = item.valorMinimo.ToString();

                txValorVenda.Text = item.valorVenda.ToString();

                txMarca.Text = item.marca;

                cbUnidadeMedida.Text = item.unidadeMedida;

                txDataInsercao.Text = item.dataInsercao.ToString();

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
                //tratamendo de gravação de dados
                //trata para que o usuário não deixe de preencher um campo excencial

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
                if (string.IsNullOrEmpty(txCategoria.Text))
                {
                    throw new Exception("insira uma categoria para o item. ");
                }
                if (string.IsNullOrEmpty(txValorMinimo.Text))
                {
                    throw new Exception("insira um valor mínimo para o item. ");
                }
                if (string.IsNullOrEmpty(cbCusto.Text))
                {
                    throw new Exception("insira a porcentagem de custo do item. ");
                }

                Item item = new Item();

                item.id = !string.IsNullOrEmpty(txId.Text) ? Convert.ToInt32(txId.Text) : 0;
                item.nome = txNome.Text;
                item.fornecedor = txFornecedor.Text;
                item.quantidade = Convert.ToInt32(txQuantidade.Text);
                item.categoria = txCategoria.Text;
                item.descricao = txDescricaoItem.Text;
                item.custo = Convert.ToDouble(cbCusto.Text.Replace("% ", " "));
                item.valorCompra = Convert.ToDouble(txValorCompra.Text.Replace("R$ ", " "));
                var porcentagem = Convert.ToString((item.custo / 100) * item.valorCompra);
                item.valorMinimo = item.valorCompra + Convert.ToDouble(porcentagem.Replace("R$ ", " "));
                item.valorVenda = Convert.ToDouble(txValorVenda.Text.Replace("R$ ", " "));
                item.marca = txMarca.Text;
                item.dataInsercao = DateTime.Now;

                if (cbUnidadeMedida.Text == "UNIDADE")
                {
                    item.unidadeMedida = "unidade";
                }
                else if (cbUnidadeMedida.Text == "CAIXA")
                {
                    item.unidadeMedida = "caixa";
                }
                else if (cbUnidadeMedida.Text == "PACOTE")
                {
                    item.unidadeMedida = "pacote";
                }
                else if (cbUnidadeMedida.Text == "KIT")
                {
                    item.unidadeMedida = "kit";
                }
                else if (cbUnidadeMedida.Text == "FARDO")
                {
                    item.unidadeMedida = "fardo";
                }
                else if (cbUnidadeMedida.Text == "KG")
                {
                    item.unidadeMedida = "kg";
                }
                if (ItemController.Gravar(item))
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
                string mensagem = "Erro ao cadastrar o item. Erro: " + ex.Message;
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
        // Eventos
        #region txQuantidade_KeyPress
        private void txQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;

            }
        }
        #endregion
        #region txValorMinimo_KeyDown
        private void txValorMinimo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                double custo = Convert.ToDouble(cbCusto.Text.Replace("% ", " "));
                double compra = Convert.ToDouble(txValorCompra.Text.Replace("R$ ", " "));

                double resultado = Convert.ToDouble(custo + compra);
                txValorMinimo.Text = resultado.ToString();
            }
        }
        #endregion
        #region txValorCompra_Leave
        private void txValorCompra_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cbCusto.Text) && !string.IsNullOrEmpty(txValorCompra.Text))
                {
                    //double minimo = Convert.ToDouble(txValorMinimoo.Text.Replace("% ", " "));
                    double valorMin = ((Convert.ToDouble(cbCusto.Text) * Convert.ToDouble(txValorCompra.Text)) / 100) + Convert.ToDouble(txValorCompra.Text);
                    txValorMinimo.Text = Convert.ToString(valorMin);
                }
                else
                {
                    string mensagem = "Favor preencher os campos Valor Compra e Custo."; ;
                    string titulo = "Erro.";
                    MessageBoxButtons botoes = MessageBoxButtons.OK;
                    MessageBoxIcon icone = MessageBoxIcon.Error;
                    MessageBox.Show(mensagem, titulo, botoes, icone);
                }
            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao calcular o valor mínmo. Erro: " + ex.Message;
                string titulo = "Erro. ";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
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
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {

                e.Handled = true;

            }
        }
        #endregion
        #region txValorVenda_KeyPress
        private void txValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                string mensagem = "Este campo aceita somente numero e virgula."; ;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
            if ((e.KeyChar == ',') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                string mensagem = "Este campo aceita somente uma virgula."; ;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region txValorCompra_KeyPress
        private void txValorCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                string mensagem = "Este campo aceita somente numero e virgula."; ;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
            if ((e.KeyChar == ',') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                string mensagem = "Este campo aceita somente uma virgula."; ;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
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
    }
}
