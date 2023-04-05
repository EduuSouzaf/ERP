using SB1.ProjTest.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using SB1.ProjTest.Model;

namespace SB1.ProjTest.View
{
    public partial class EstoqueView : Form
    {
        public EstoqueView()
        {
            InitializeComponent();
            Consultar(null, null, null, null);
            ColunaTotal();
            ConsultarCategoria(null);
            ConsultarMarca(null);
        }
        #region Consultar
        private void Consultar(int? idItem, string nomeItem, string categoriaItem, string marca)
        {
            try
            {
                BindingSource bindigSourceItem = ItemController.ConsultarEstoque(idItem, nomeItem, categoriaItem, marca);


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
        #region categoria
        private void ConsultarCategoria(string codigo)
        {
            try
            {
                BindingSource bindingSourceCategoria = CategoriaController.Consultar(codigo);
                DataRowView row = bindingSourceCategoria.AddNew() as DataRowView;

                cbCategoria.DataSource = bindingSourceCategoria;
                cbCategoria.DisplayMember = "categoria";
                cbCategoria.ValueMember = "codigo";
            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao consultar as categorias. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region Marca
        private void ConsultarMarca(string codigo)
        {
            try
            {
                BindingSource bindingSourceMarca = MarcaController.Consultar(codigo);
                DataRowView row = bindingSourceMarca.AddNew() as DataRowView;

                cbMarca.DataSource = bindingSourceMarca;
                cbMarca.DisplayMember = "marca";
                cbMarca.ValueMember = "codigo";

            }
            catch (Exception ex)
            {
                string mensagem = "Erro ao consultar as Marcas. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region AbrirCadastro
        private void AbrirCadastro()
        {
            try
            {
                if (dgConsultaItem.CurrentRow != null)
                {
                    int idItem = Convert.ToInt32(dgConsultaItem.Rows[dgConsultaItem.CurrentRow.Index].Cells["id"].Value);

                    CadastroItemView cadastrarItem = new CadastroItemView(idItem);
                    //centraliza a tela quando ela é executada
                    cadastrarItem.StartPosition = FormStartPosition.CenterScreen;
                    cadastrarItem.Show();
                }

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
        #region ColunaTotal
        private void ColunaTotal()
        {
            double total = 0;
            double totalVenda = 0;

            foreach (DataGridViewRow row in dgConsultaItem.Rows)
            {
                // Obter o valor da coluna "valorTotal" da linha atual e adicioná-lo à variável "total"
                total += Convert.ToDouble(row.Cells["totalEstoque"].Value);

                totalVenda += Convert.ToDouble(row.Cells["totalEstoqueVenda"].Value);
            }

            txTotalEstoque.Text = total.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));

            txTotalEstoqueVenda.Text = totalVenda.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
        }
        #endregion
        //eventos
        #region txId
        private void txId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        #endregion
        #region txNome
        private void txNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }
        #endregion
        #region btConsultar
        private void btConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                //id
                if (!string.IsNullOrEmpty(txId.Text) && string.IsNullOrEmpty(txNome.Text) && string.IsNullOrEmpty(cbCategoria.Text) &&
                    string.IsNullOrEmpty(cbMarca.Text))
                {
                    Consultar(Convert.ToInt32(txId.Text), null, null, null);

                    ColunaTotal();
                }
                //nome
                else if (string.IsNullOrEmpty(txId.Text) && !string.IsNullOrEmpty(txNome.Text) && string.IsNullOrEmpty(cbCategoria.Text) &&
                         string.IsNullOrEmpty(cbMarca.Text))
                {
                    Consultar(null, txNome.Text, null, null);

                    ColunaTotal();
                }
                //categoria
                else if (string.IsNullOrEmpty(txId.Text) && string.IsNullOrEmpty(txNome.Text) && !string.IsNullOrEmpty(cbCategoria.Text) &&
                         string.IsNullOrEmpty(cbMarca.Text))
                {
                    string codCategoria = cbCategoria.SelectedValue.ToString();

                    Consultar(null, null, codCategoria, null);

                    ColunaTotal();
                }
                //marca
                else if (string.IsNullOrEmpty(txId.Text) && string.IsNullOrEmpty(txNome.Text) && string.IsNullOrEmpty(cbCategoria.Text) &&
                         !string.IsNullOrEmpty(cbMarca.Text))
                {
                    string codMarca = cbMarca.SelectedValue.ToString();

                    Consultar(null, null, null, codMarca);

                    ColunaTotal();
                }
                //nome, categoria
                else if (string.IsNullOrEmpty(txId.Text) && !string.IsNullOrEmpty(txNome.Text) && !string.IsNullOrEmpty(cbCategoria.Text) &&
                         string.IsNullOrEmpty(cbMarca.Text))
                {
                    string codCategoria = cbCategoria.SelectedValue.ToString();

                    Consultar(null, txNome.Text, codCategoria, null);

                    ColunaTotal();
                }
                //categoria, marca
                else if (string.IsNullOrEmpty(txId.Text) && string.IsNullOrEmpty(txNome.Text) && !string.IsNullOrEmpty(cbCategoria.Text) &&
                         !string.IsNullOrEmpty(cbMarca.Text))
                {
                    string codCategoria = cbCategoria.SelectedValue.ToString();
                    string codMarca = cbMarca.SelectedValue.ToString();

                    Consultar(null, null, codCategoria, codMarca);

                    ColunaTotal();
                }
                //nenhum Parâmetro
                else if (string.IsNullOrEmpty(txId.Text) && string.IsNullOrEmpty(txNome.Text) && string.IsNullOrEmpty(cbCategoria.Text) &&
                         string.IsNullOrEmpty(cbMarca.Text))
                {

                    Consultar(null, null, null, null);

                    ColunaTotal();
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

        private void dgConsultaItem_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AbrirCadastro();
        }

        private void btEntradaEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                EntradaEstoqueView estoque = new EntradaEstoqueView();
                //centraliza a tela quando ela é executada
                estoque.StartPosition = FormStartPosition.CenterScreen;
                estoque.Show();
            }
            catch (Exception ex)
            {
                //exception ao dar entrada nas informações
                string mensagem = "Erro ao abrir a tela de entrada no Estoque. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
    }
}
