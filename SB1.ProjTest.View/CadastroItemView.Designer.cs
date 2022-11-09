namespace SB1.ProjTest.View
{
    partial class CadastroItemView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroItemView));
            this.txId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbNomeItem = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.lbValorMinimo = new System.Windows.Forms.Label();
            this.lbValorVenda = new System.Windows.Forms.Label();
            this.txDescricaoItem = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txFornecedor = new System.Windows.Forms.TextBox();
            this.txCategoria = new System.Windows.Forms.TextBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.lbUnidadeMedida = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.txMarca = new System.Windows.Forms.TextBox();
            this.lbValorCompra = new System.Windows.Forms.Label();
            this.cbUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.lbDataInsercao = new System.Windows.Forms.Label();
            this.txDataInsercao = new System.Windows.Forms.MaskedTextBox();
            this.txQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.lbCusto = new System.Windows.Forms.Label();
            this.txValorCompra = new SB1.ProjTest.Model.txValor();
            this.txValorVenda = new SB1.ProjTest.Model.txValor();
            this.txValorMinimo = new SB1.ProjTest.Model.txValor();
            this.cbCusto = new System.Windows.Forms.ComboBox();
            this.btImprimir = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.gbTabelaPreco = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbPorcentagem = new System.Windows.Forms.RadioButton();
            this.rbReais = new System.Windows.Forms.RadioButton();
            this.gbTabelaPreco.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txId
            // 
            this.txId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txId.Enabled = false;
            this.txId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txId.Location = new System.Drawing.Point(101, 19);
            this.txId.Margin = new System.Windows.Forms.Padding(4);
            this.txId.Name = "txId";
            this.txId.ReadOnly = true;
            this.txId.Size = new System.Drawing.Size(58, 20);
            this.txId.TabIndex = 0;
            // 
            // lbId
            // 
            this.lbId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(53, 23);
            this.lbId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(40, 13);
            this.lbId.TabIndex = 3;
            this.lbId.Text = "Código";
            // 
            // lbNomeItem
            // 
            this.lbNomeItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNomeItem.AutoSize = true;
            this.lbNomeItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeItem.Location = new System.Drawing.Point(177, 22);
            this.lbNomeItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomeItem.Name = "lbNomeItem";
            this.lbNomeItem.Size = new System.Drawing.Size(34, 13);
            this.lbNomeItem.TabIndex = 4;
            this.lbNomeItem.Text = "Nome";
            // 
            // txNome
            // 
            this.txNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txNome.BackColor = System.Drawing.SystemColors.Window;
            this.txNome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txNome.Location = new System.Drawing.Point(215, 19);
            this.txNome.Margin = new System.Windows.Forms.Padding(4);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(321, 21);
            this.txNome.TabIndex = 1;
            // 
            // lbValorMinimo
            // 
            this.lbValorMinimo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbValorMinimo.AutoSize = true;
            this.lbValorMinimo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorMinimo.Location = new System.Drawing.Point(9, 63);
            this.lbValorMinimo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValorMinimo.Name = "lbValorMinimo";
            this.lbValorMinimo.Size = new System.Drawing.Size(66, 13);
            this.lbValorMinimo.TabIndex = 6;
            this.lbValorMinimo.Text = "Valor Mínimo";
            // 
            // lbValorVenda
            // 
            this.lbValorVenda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbValorVenda.AutoSize = true;
            this.lbValorVenda.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorVenda.Location = new System.Drawing.Point(196, 63);
            this.lbValorVenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValorVenda.Name = "lbValorVenda";
            this.lbValorVenda.Size = new System.Drawing.Size(64, 13);
            this.lbValorVenda.TabIndex = 8;
            this.lbValorVenda.Text = "Valor Venda";
            // 
            // txDescricaoItem
            // 
            this.txDescricaoItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txDescricaoItem.BackColor = System.Drawing.SystemColors.Window;
            this.txDescricaoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDescricaoItem.Location = new System.Drawing.Point(101, 105);
            this.txDescricaoItem.Margin = new System.Windows.Forms.Padding(4);
            this.txDescricaoItem.Name = "txDescricaoItem";
            this.txDescricaoItem.Size = new System.Drawing.Size(601, 20);
            this.txDescricaoItem.TabIndex = 7;
            // 
            // lbDescricao
            // 
            this.lbDescricao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricao.Location = new System.Drawing.Point(40, 110);
            this.lbDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(53, 13);
            this.lbDescricao.TabIndex = 11;
            this.lbDescricao.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fornecedor";
            // 
            // txFornecedor
            // 
            this.txFornecedor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txFornecedor.BackColor = System.Drawing.SystemColors.Window;
            this.txFornecedor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txFornecedor.Location = new System.Drawing.Point(380, 47);
            this.txFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.txFornecedor.Name = "txFornecedor";
            this.txFornecedor.Size = new System.Drawing.Size(322, 21);
            this.txFornecedor.TabIndex = 4;
            // 
            // txCategoria
            // 
            this.txCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txCategoria.BackColor = System.Drawing.SystemColors.Window;
            this.txCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCategoria.Location = new System.Drawing.Point(101, 76);
            this.txCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txCategoria.Name = "txCategoria";
            this.txCategoria.Size = new System.Drawing.Size(192, 20);
            this.txCategoria.TabIndex = 5;
            // 
            // lbCategoria
            // 
            this.lbCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(39, 80);
            this.lbCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(54, 13);
            this.lbCategoria.TabIndex = 17;
            this.lbCategoria.Text = "Categoria";
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidade.Location = new System.Drawing.Point(555, 22);
            this.lbQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(63, 13);
            this.lbQuantidade.TabIndex = 18;
            this.lbQuantidade.Text = "Quantidade";
            // 
            // lbUnidadeMedida
            // 
            this.lbUnidadeMedida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbUnidadeMedida.AutoSize = true;
            this.lbUnidadeMedida.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnidadeMedida.Location = new System.Drawing.Point(47, 51);
            this.lbUnidadeMedida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUnidadeMedida.Name = "lbUnidadeMedida";
            this.lbUnidadeMedida.Size = new System.Drawing.Size(46, 13);
            this.lbUnidadeMedida.TabIndex = 20;
            this.lbUnidadeMedida.Text = "Unidade";
            // 
            // lbMarca
            // 
            this.lbMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.Location = new System.Drawing.Point(336, 79);
            this.lbMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(36, 13);
            this.lbMarca.TabIndex = 22;
            this.lbMarca.Text = "Marca";
            // 
            // txMarca
            // 
            this.txMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txMarca.BackColor = System.Drawing.SystemColors.Window;
            this.txMarca.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMarca.Location = new System.Drawing.Point(380, 76);
            this.txMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txMarca.Name = "txMarca";
            this.txMarca.Size = new System.Drawing.Size(117, 21);
            this.txMarca.TabIndex = 6;
            // 
            // lbValorCompra
            // 
            this.lbValorCompra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbValorCompra.AutoSize = true;
            this.lbValorCompra.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorCompra.Location = new System.Drawing.Point(428, 25);
            this.lbValorCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValorCompra.Name = "lbValorCompra";
            this.lbValorCompra.Size = new System.Drawing.Size(71, 13);
            this.lbValorCompra.TabIndex = 24;
            this.lbValorCompra.Text = "Valor Compra";
            // 
            // cbUnidadeMedida
            // 
            this.cbUnidadeMedida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbUnidadeMedida.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbUnidadeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidadeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnidadeMedida.FormattingEnabled = true;
            this.cbUnidadeMedida.Items.AddRange(new object[] {
            "UNIDADE",
            "CAIXA",
            "PACOTE",
            "KIT",
            "FARDO",
            "KG"});
            this.cbUnidadeMedida.Location = new System.Drawing.Point(101, 47);
            this.cbUnidadeMedida.Margin = new System.Windows.Forms.Padding(4);
            this.cbUnidadeMedida.Name = "cbUnidadeMedida";
            this.cbUnidadeMedida.Size = new System.Drawing.Size(192, 21);
            this.cbUnidadeMedida.TabIndex = 3;
            // 
            // lbDataInsercao
            // 
            this.lbDataInsercao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDataInsercao.AutoSize = true;
            this.lbDataInsercao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataInsercao.Location = new System.Drawing.Point(504, 80);
            this.lbDataInsercao.Name = "lbDataInsercao";
            this.lbDataInsercao.Size = new System.Drawing.Size(90, 13);
            this.lbDataInsercao.TabIndex = 30;
            this.lbDataInsercao.Text = "Data de Inserção";
            // 
            // txDataInsercao
            // 
            this.txDataInsercao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txDataInsercao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txDataInsercao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDataInsercao.Location = new System.Drawing.Point(602, 76);
            this.txDataInsercao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txDataInsercao.Mask = "00/00/0000";
            this.txDataInsercao.Name = "txDataInsercao";
            this.txDataInsercao.ReadOnly = true;
            this.txDataInsercao.Size = new System.Drawing.Size(100, 21);
            this.txDataInsercao.TabIndex = 31;
            this.txDataInsercao.ValidatingType = typeof(System.DateTime);
            // 
            // txQuantidade
            // 
            this.txQuantidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txQuantidade.BackColor = System.Drawing.SystemColors.Window;
            this.txQuantidade.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txQuantidade.Location = new System.Drawing.Point(625, 18);
            this.txQuantidade.Name = "txQuantidade";
            this.txQuantidade.Size = new System.Drawing.Size(77, 21);
            this.txQuantidade.TabIndex = 2;
            this.txQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txQuantidade_KeyPress);
            // 
            // lbCusto
            // 
            this.lbCusto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCusto.AutoSize = true;
            this.lbCusto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCusto.Location = new System.Drawing.Point(17, 25);
            this.lbCusto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCusto.Name = "lbCusto";
            this.lbCusto.Size = new System.Drawing.Size(61, 13);
            this.lbCusto.TabIndex = 32;
            this.lbCusto.Text = "Custo Unit.";
            // 
            // txValorCompra
            // 
            this.txValorCompra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txValorCompra.BackColor = System.Drawing.SystemColors.Window;
            this.txValorCompra.Location = new System.Drawing.Point(506, 22);
            this.txValorCompra.Name = "txValorCompra";
            this.txValorCompra.Size = new System.Drawing.Size(164, 21);
            this.txValorCompra.TabIndex = 9;
            this.txValorCompra.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txValorCompra_MouseClick);
            this.txValorCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txValorCompra_KeyPress);
            this.txValorCompra.Leave += new System.EventHandler(this.txValorCompra_Leave);
            this.txValorCompra.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txValorCompra_MouseDoubleClick);
            // 
            // txValorVenda
            // 
            this.txValorVenda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txValorVenda.BackColor = System.Drawing.SystemColors.Window;
            this.txValorVenda.Location = new System.Drawing.Point(264, 60);
            this.txValorVenda.Name = "txValorVenda";
            this.txValorVenda.Size = new System.Drawing.Size(164, 21);
            this.txValorVenda.TabIndex = 11;
            this.txValorVenda.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txValorVenda_MouseClick);
            this.txValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txValorVenda_KeyPress);
            this.txValorVenda.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txValorVenda_MouseDoubleClick);
            // 
            // txValorMinimo
            // 
            this.txValorMinimo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txValorMinimo.BackColor = System.Drawing.SystemColors.Window;
            this.txValorMinimo.Cursor = System.Windows.Forms.Cursors.No;
            this.txValorMinimo.Location = new System.Drawing.Point(82, 60);
            this.txValorMinimo.Name = "txValorMinimo";
            this.txValorMinimo.Size = new System.Drawing.Size(110, 21);
            this.txValorMinimo.TabIndex = 10;
            this.txValorMinimo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txValorMinimo_KeyDown);
            // 
            // cbCusto
            // 
            this.cbCusto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCusto.BackColor = System.Drawing.SystemColors.Window;
            this.cbCusto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCusto.FormattingEnabled = true;
            this.cbCusto.Items.AddRange(new object[] {
            " 5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "40",
            "45",
            "50"});
            this.cbCusto.Location = new System.Drawing.Point(264, 22);
            this.cbCusto.Name = "cbCusto";
            this.cbCusto.Size = new System.Drawing.Size(110, 21);
            this.cbCusto.TabIndex = 8;
            this.cbCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCusto_KeyPress);
            // 
            // btImprimir
            // 
            this.btImprimir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btImprimir.BackColor = System.Drawing.SystemColors.Window;
            this.btImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btImprimir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btImprimir.FlatAppearance.BorderSize = 0;
            this.btImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btImprimir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImprimir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btImprimir.Location = new System.Drawing.Point(564, 330);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(66, 28);
            this.btImprimir.TabIndex = 13;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = false;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btCadastrar.BackColor = System.Drawing.SystemColors.Window;
            this.btCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCadastrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCadastrar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btCadastrar.Location = new System.Drawing.Point(636, 330);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(66, 28);
            this.btCadastrar.TabIndex = 12;
            this.btCadastrar.Text = "Gravar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btCancelar.BackColor = System.Drawing.SystemColors.Window;
            this.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancelar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(492, 330);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(66, 28);
            this.btCancelar.TabIndex = 14;
            this.btCancelar.Text = "Fechar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // gbTabelaPreco
            // 
            this.gbTabelaPreco.BackColor = System.Drawing.SystemColors.Window;
            this.gbTabelaPreco.Controls.Add(this.panel1);
            this.gbTabelaPreco.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTabelaPreco.Location = new System.Drawing.Point(12, 157);
            this.gbTabelaPreco.Name = "gbTabelaPreco";
            this.gbTabelaPreco.Size = new System.Drawing.Size(698, 157);
            this.gbTabelaPreco.TabIndex = 33;
            this.gbTabelaPreco.TabStop = false;
            this.gbTabelaPreco.Text = "Tabela de Precificação";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.rbReais);
            this.panel1.Controls.Add(this.rbPorcentagem);
            this.panel1.Controls.Add(this.txValorVenda);
            this.panel1.Controls.Add(this.cbCusto);
            this.panel1.Controls.Add(this.txValorMinimo);
            this.panel1.Controls.Add(this.lbValorCompra);
            this.panel1.Controls.Add(this.lbCusto);
            this.panel1.Controls.Add(this.lbValorMinimo);
            this.panel1.Controls.Add(this.txValorCompra);
            this.panel1.Controls.Add(this.lbValorVenda);
            this.panel1.Location = new System.Drawing.Point(7, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 121);
            this.panel1.TabIndex = 0;
            // 
            // rbPorcentagem
            // 
            this.rbPorcentagem.AutoSize = true;
            this.rbPorcentagem.Location = new System.Drawing.Point(82, 26);
            this.rbPorcentagem.Name = "rbPorcentagem";
            this.rbPorcentagem.Size = new System.Drawing.Size(88, 17);
            this.rbPorcentagem.TabIndex = 35;
            this.rbPorcentagem.TabStop = true;
            this.rbPorcentagem.Text = "Porcentagem";
            this.rbPorcentagem.UseVisualStyleBackColor = true;
            // 
            // rbReais
            // 
            this.rbReais.AutoSize = true;
            this.rbReais.Location = new System.Drawing.Point(177, 25);
            this.rbReais.Name = "rbReais";
            this.rbReais.Size = new System.Drawing.Size(51, 17);
            this.rbReais.TabIndex = 36;
            this.rbReais.TabStop = true;
            this.rbReais.Text = "Reais";
            this.rbReais.UseVisualStyleBackColor = true;
            // 
            // CadastroItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(722, 376);
            this.Controls.Add(this.gbTabelaPreco);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.txQuantidade);
            this.Controls.Add(this.txDataInsercao);
            this.Controls.Add(this.lbDataInsercao);
            this.Controls.Add(this.cbUnidadeMedida);
            this.Controls.Add(this.txMarca);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbUnidadeMedida);
            this.Controls.Add(this.lbQuantidade);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.txCategoria);
            this.Controls.Add(this.txFornecedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.txDescricaoItem);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.lbNomeItem);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.txId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroItemView";
            this.Text = "Cadastro de Item";
            this.gbTabelaPreco.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbNomeItem;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label lbValorMinimo;
        private System.Windows.Forms.Label lbValorVenda;
        private System.Windows.Forms.TextBox txDescricaoItem;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txFornecedor;
        private System.Windows.Forms.TextBox txCategoria;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.Label lbUnidadeMedida;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.TextBox txMarca;
        private System.Windows.Forms.Label lbValorCompra;
        private System.Windows.Forms.ComboBox cbUnidadeMedida;
        private System.Windows.Forms.Label lbDataInsercao;
        private System.Windows.Forms.MaskedTextBox txDataInsercao;
        private System.Windows.Forms.MaskedTextBox txQuantidade;
        private Model.txValor txValorMinimo;
        private Model.txValor txValorVenda;
        private Model.txValor txValorCompra;
        private System.Windows.Forms.Label lbCusto;
        private System.Windows.Forms.ComboBox cbCusto;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.GroupBox gbTabelaPreco;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbReais;
        private System.Windows.Forms.RadioButton rbPorcentagem;
    }
}