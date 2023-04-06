using SB1.ProjTest.Controller;
using SB1.ProjTest.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SB1.ProjTest.View
{
    public partial class TelaPrincipalView : Form
    {
        private int _childFormNumber;
        #region TelaPrincipalView
        public TelaPrincipalView()
        {
            InitializeComponent();
            UnidadeVendidas();
        }
#endregion
        #region ShowNewForm
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + _childFormNumber++;
            childForm.Show();
        }
#endregion
        #region OpenFile
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }
        #endregion
        #region SaveAsToolStripMenuItem_Click
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }
#endregion
        #region ExitToolsStripMenuItem_Click
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region CascadeToolStripMenuItem_Click
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
#endregion
        #region TileVerticalToolStripMenuItem_Click
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
#endregion
        #region TileHorizontalToolStripMenuItem_Click
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
#endregion
        #region ArrangeIconsToolStripMenuItem_Click
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
#endregion
        #region CloseAllToolStripMenuItem_Click
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
#endregion
        #region Parceiro de Negócio
        private void parceiroDeNegócioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroParceiroNegocioView cadastrarParceiroNegocio = new CadastroParceiroNegocioView();
                //centraliza a tela quando ela é executada
                cadastrarParceiroNegocio.StartPosition = FormStartPosition.CenterScreen;
                cadastrarParceiroNegocio.Show();
            }
            catch (Exception ex)
            {
                //exception ao dar entrada nas informações
                string mensagem = "Erro ao abrir o cadastro de Parceiro de Negócio. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        private void consultaParceiroDeNegócioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaParceiroNegocioView consultaParceiroNegocio = new ConsultaParceiroNegocioView();
                //centraliza a tela quando ela é executada
                consultaParceiroNegocio.StartPosition = FormStartPosition.CenterScreen;
                consultaParceiroNegocio.Show();
            }
            catch (Exception ex)
            {
                //exception ao dar entrada nas informações
                string mensagem = "Erro ao abrir a consulta do Parceiro de Negócio. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region Item
        private void cadastroDeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroItemView cadastroItemView = new CadastroItemView();
                //centraliza a tela quando ela é executada
                cadastroItemView.StartPosition = FormStartPosition.CenterScreen;
                cadastroItemView.Show();
            }
            catch (Exception ex)
            {
                //exception ao dar entrada nas informações
                string mensagem = "Erro ao abrir o cadastro do item. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        private void consultaItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaItemView consultaItem = new ConsultaItemView();
                //centraliza a tela quando ela é executada
                consultaItem.StartPosition = FormStartPosition.CenterScreen;
                consultaItem.Show();
            }
            catch (Exception ex)
            {
                //exception ao dar entrada nas informações
                string mensagem = "Erro ao abrir a consulta do Item. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
#endregion
        #region btExit_Click
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region Pedido
        private void cadastrarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroPedidoView cadastroPedido = new CadastroPedidoView();
                //centraliza a tela quando ela é executada
                cadastroPedido.StartPosition = FormStartPosition.CenterScreen;
                cadastroPedido.Show();
            }
            catch (Exception ex)
            {
                //exception ao dar entrada nas informações
                string mensagem = "Erro ao abrir o cadastro de Pedido. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        private void consultarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaPedidoView consultaPedido = new ConsultaPedidoView();
                //centraliza a tela quando ela é executada
                consultaPedido.StartPosition = FormStartPosition.CenterScreen;
                consultaPedido.Show();
            }
            catch (Exception ex)
            {
                //exception ao dar entrada nas informações
                string mensagem = "Erro ao abrir a Consulta de Pedido. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region estoque
        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                EstoqueView estoque = new EstoqueView();
                //centraliza a tela quando ela é executada
                estoque.StartPosition = FormStartPosition.CenterScreen;
                estoque.Show();
            }
            catch (Exception ex)
            {
                //exception ao dar entrada nas informações
                string mensagem = "Erro ao abrir o estoque. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region Categoria
        private void cadastroDeCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroCategoriaView cadastroCategoria = new CadastroCategoriaView();
                //centraliza a tela quando ela é executada
                cadastroCategoria.StartPosition = FormStartPosition.CenterScreen;
                cadastroCategoria.Show();
            }
            catch (Exception ex)
            {
                //exception ao dar entrada nas informações
                string mensagem = "Erro ao abrir o cadastro de Categoria. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region Unidade de Medida
        private void cadastrarUnidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroUnidadeMedidaView cadastroUnidade = new CadastroUnidadeMedidaView();
                //centraliza a tela quando ela é executada
                cadastroUnidade.StartPosition = FormStartPosition.CenterScreen;
                cadastroUnidade.Show();
            }
            catch (Exception ex)
            {
                //exception ao dar entrada nas informações
                string mensagem = "Erro ao abrir o cadastro de Categoria. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region Marca
        private void cadastrarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroMarcaView cadastroMarca = new CadastroMarcaView();
                //centraliza a tela quando ela é executada
                cadastroMarca.StartPosition = FormStartPosition.CenterScreen;
                cadastroMarca.Show();
            }
            catch (Exception ex)
            {
                //exception ao dar entrada nas informações
                string mensagem = "Erro ao abrir o cadastro de Categoria. Erro: " + ex.Message;
                string titulo = "Erro.";
                MessageBoxButtons botoes = MessageBoxButtons.OK;
                MessageBoxIcon icone = MessageBoxIcon.Error;
                MessageBox.Show(mensagem, titulo, botoes, icone);
            }
        }
        #endregion
        #region UnidadeVendidas
        public void UnidadeVendidas()
        {
            Title title = new Title();
            title.Font = new Font("Arial", 14, FontStyle.Bold);
            title.ForeColor = Color.Black;
            title.Text = "Itens mais vendidos";
            ctUnidadesVendidas.Titles.Add(title);
            
            List<int> unidadesVendidas = MovimentoEstoqueController.ConsultarUnidadesVendidasNome();
            List<string> itens = ItemController.ConsultarItem();
            ctUnidadesVendidas.Series.Add("unidades");
            ctUnidadesVendidas.Series["unidades"].LegendText = "unidades";

            ctUnidadesVendidas.Series["unidades"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            ctUnidadesVendidas.Series["unidades"].BorderWidth = 4;

            var unidadesPorItem = unidadesVendidas.Zip(itens, (unidades, item) => new { Unidades = unidades, Item = item })
                                                  .GroupBy(x => x.Item)
                                                  .Select(g => new { Item = g.Key, TotalUnidades = g.Sum(x => x.Unidades) });

            var top5Itens = unidadesPorItem.OrderByDescending(x => x.TotalUnidades).Take(5);

            foreach (var item in top5Itens)
            {
                ctUnidadesVendidas.Series["unidades"].Points.AddXY(item.Item, item.TotalUnidades);
            }
        }
        #endregion
    }
}
