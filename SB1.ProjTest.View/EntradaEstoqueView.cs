using System;
using System.Windows.Forms;
using SB1.ProjTest.Controller;

namespace SB1.ProjTest.View
{
    public partial class EntradaEstoqueView : Form
    {
        public EntradaEstoqueView()
        {
            InitializeComponent();
        }

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


        private void btListaItem_Click(object sender, System.EventArgs e)
        {
            AdicionarItem();
        }
    }
}
