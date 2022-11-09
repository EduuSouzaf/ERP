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
    public partial class CadastroItemView : Form
    {
        //contrutor
        public CadastroItemView()
        {
            InitializeComponent();
        }
        public CadastroItemView(int id)
        {
            InitializeComponent();
            Consultar(id);

        }

        private void Consultar(int id)
        {
            try
            {
                Item item = ItemController.Consultar(id);

                txId.Text = item.id.ToString();

                txNome.Text = item.nome;

                txFornecedor.Text = item.fornecedor;

                txQuantidade.Text = item.quantidade;

                txCategoria.Text = item.categoria;

                txDescricaoItem.Text = item.descircao;

                txValorCompra.Text = item.valorCompra;

                txValorCompra.Text = item.valorMinimo;

                txValorVenda.Text = item.valorVenda;

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
                    throw new Exception("insira um nome para o item. ");
                }
                if (string.IsNullOrEmpty(txNome.Text))
                {
                    throw new Exception("insira a descrição do item. ");
                }

                Item item = new Item();

                item.id = !string.IsNullOrEmpty(txId.Text) ? Convert.ToInt32(txId) : 0;
                item.nome = txNome.Text;
                item.fornecedor = txFornecedor.Text;
                item.quantidade = txQuantidade.Text;
                item.categoria = txCategoria.Text;
                item.descircao = txDescricaoItem.Text;
                item.valorCompra = txValorCompra.Text;
                item.valorMinimo = txValorCompra.Text;
                item.valorVenda = txValorVenda.Text;
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

                item.ativo = true;

                if (ItemController.Gravar(item))
                {
                    txId.Text = item.id.ToString();

                    string mensagem = "Sucesso ao cadastrar o item: " + item.id.ToString() + " - " + item.nome;
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

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Gravar();

            ConsultaItemView consultaItem = new ConsultaItemView();

            // consultaItem.AbrirCadastro();
        }
    }
}
