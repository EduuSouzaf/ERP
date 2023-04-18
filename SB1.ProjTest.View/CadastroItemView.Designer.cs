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
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.lbUnidadeMedida = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.cbUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.lbDataInsercao = new System.Windows.Forms.Label();
            this.txQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.btImprimir = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.gbTabelaPreco = new System.Windows.Forms.GroupBox();
            this.txValorVenda = new System.Windows.Forms.TextBox();
            this.lbCusto = new System.Windows.Forms.Label();
            this.txValorCompra = new System.Windows.Forms.TextBox();
            this.txLucroTotal = new System.Windows.Forms.TextBox();
            this.lbLucroTotal = new System.Windows.Forms.Label();
            this.txValorMinimo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txTotalEstoque = new System.Windows.Forms.TextBox();
            this.txTotalEstoqueVenda = new System.Windows.Forms.TextBox();
            this.lbTotalEstoque = new System.Windows.Forms.Label();
            this.txMargemLucro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btListaParceiros = new System.Windows.Forms.Button();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.dtDataInsercao = new System.Windows.Forms.DateTimePicker();
            this.dgEntradasEstoque = new System.Windows.Forms.DataGridView();
            this.gpEntradaEstoque = new System.Windows.Forms.GroupBox();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInsercao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTabelaPreco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntradasEstoque)).BeginInit();
            this.gpEntradaEstoque.SuspendLayout();
            this.SuspendLayout();
            // 
            // txId
            // 
            this.txId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txId.Enabled = false;
            this.txId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txId.Location = new System.Drawing.Point(98, 19);
            this.txId.Margin = new System.Windows.Forms.Padding(4);
            this.txId.Name = "txId";
            this.txId.ReadOnly = true;
            this.txId.Size = new System.Drawing.Size(45, 20);
            this.txId.TabIndex = 0;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(44, 22);
            this.lbId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(40, 13);
            this.lbId.TabIndex = 3;
            this.lbId.Text = "Código";
            // 
            // lbNomeItem
            // 
            this.lbNomeItem.AutoSize = true;
            this.lbNomeItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeItem.Location = new System.Drawing.Point(154, 21);
            this.lbNomeItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomeItem.Name = "lbNomeItem";
            this.lbNomeItem.Size = new System.Drawing.Size(34, 13);
            this.lbNomeItem.TabIndex = 4;
            this.lbNomeItem.Text = "Nome";
            // 
            // txNome
            // 
            this.txNome.BackColor = System.Drawing.SystemColors.Window;
            this.txNome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txNome.Location = new System.Drawing.Point(196, 19);
            this.txNome.Margin = new System.Windows.Forms.Padding(4);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(376, 21);
            this.txNome.TabIndex = 1;
            // 
            // lbValorMinimo
            // 
            this.lbValorMinimo.AutoSize = true;
            this.lbValorMinimo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorMinimo.Location = new System.Drawing.Point(282, 30);
            this.lbValorMinimo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValorMinimo.Name = "lbValorMinimo";
            this.lbValorMinimo.Size = new System.Drawing.Size(69, 13);
            this.lbValorMinimo.TabIndex = 6;
            this.lbValorMinimo.Text = "Preço Mínimo";
            // 
            // lbValorVenda
            // 
            this.lbValorVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbValorVenda.AutoSize = true;
            this.lbValorVenda.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorVenda.Location = new System.Drawing.Point(556, 30);
            this.lbValorVenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValorVenda.Name = "lbValorVenda";
            this.lbValorVenda.Size = new System.Drawing.Size(67, 13);
            this.lbValorVenda.TabIndex = 8;
            this.lbValorVenda.Text = "Preço Venda";
            // 
            // txDescricaoItem
            // 
            this.txDescricaoItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txDescricaoItem.BackColor = System.Drawing.SystemColors.Window;
            this.txDescricaoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDescricaoItem.Location = new System.Drawing.Point(98, 48);
            this.txDescricaoItem.Margin = new System.Windows.Forms.Padding(4);
            this.txDescricaoItem.Name = "txDescricaoItem";
            this.txDescricaoItem.Size = new System.Drawing.Size(717, 20);
            this.txDescricaoItem.TabIndex = 7;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricao.Location = new System.Drawing.Point(31, 52);
            this.lbDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(53, 13);
            this.lbDescricao.TabIndex = 11;
            this.lbDescricao.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fornecedor";
            // 
            // txFornecedor
            // 
            this.txFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txFornecedor.BackColor = System.Drawing.SystemColors.Window;
            this.txFornecedor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txFornecedor.Location = new System.Drawing.Point(137, 76);
            this.txFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.txFornecedor.Name = "txFornecedor";
            this.txFornecedor.Size = new System.Drawing.Size(435, 21);
            this.txFornecedor.TabIndex = 4;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(30, 110);
            this.lbCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(54, 13);
            this.lbCategoria.TabIndex = 17;
            this.lbCategoria.Text = "Categoria";
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidade.Location = new System.Drawing.Point(621, 22);
            this.lbQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(63, 13);
            this.lbQuantidade.TabIndex = 18;
            this.lbQuantidade.Text = "Quantidade";
            // 
            // lbUnidadeMedida
            // 
            this.lbUnidadeMedida.AutoSize = true;
            this.lbUnidadeMedida.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnidadeMedida.Location = new System.Drawing.Point(316, 110);
            this.lbUnidadeMedida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUnidadeMedida.Name = "lbUnidadeMedida";
            this.lbUnidadeMedida.Size = new System.Drawing.Size(46, 13);
            this.lbUnidadeMedida.TabIndex = 20;
            this.lbUnidadeMedida.Text = "Unidade";
            // 
            // lbMarca
            // 
            this.lbMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.Location = new System.Drawing.Point(607, 110);
            this.lbMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(36, 13);
            this.lbMarca.TabIndex = 22;
            this.lbMarca.Text = "Marca";
            // 
            // cbUnidadeMedida
            // 
            this.cbUnidadeMedida.BackColor = System.Drawing.SystemColors.Window;
            this.cbUnidadeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidadeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUnidadeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnidadeMedida.FormattingEnabled = true;
            this.cbUnidadeMedida.Location = new System.Drawing.Point(368, 107);
            this.cbUnidadeMedida.Margin = new System.Windows.Forms.Padding(4);
            this.cbUnidadeMedida.Name = "cbUnidadeMedida";
            this.cbUnidadeMedida.Size = new System.Drawing.Size(204, 21);
            this.cbUnidadeMedida.TabIndex = 3;
            // 
            // lbDataInsercao
            // 
            this.lbDataInsercao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDataInsercao.AutoSize = true;
            this.lbDataInsercao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataInsercao.Location = new System.Drawing.Point(614, 84);
            this.lbDataInsercao.Name = "lbDataInsercao";
            this.lbDataInsercao.Size = new System.Drawing.Size(75, 13);
            this.lbDataInsercao.TabIndex = 30;
            this.lbDataInsercao.Text = "Data Inserção";
            // 
            // txQuantidade
            // 
            this.txQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txQuantidade.BackColor = System.Drawing.SystemColors.Window;
            this.txQuantidade.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txQuantidade.Location = new System.Drawing.Point(691, 18);
            this.txQuantidade.Name = "txQuantidade";
            this.txQuantidade.Size = new System.Drawing.Size(124, 21);
            this.txQuantidade.TabIndex = 2;
            this.txQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txQuantidade_KeyPress);
            this.txQuantidade.Leave += new System.EventHandler(this.txQuantidade_Leave);
            // 
            // btImprimir
            // 
            this.btImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btImprimir.BackColor = System.Drawing.SystemColors.Window;
            this.btImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btImprimir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btImprimir.FlatAppearance.BorderSize = 0;
            this.btImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btImprimir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImprimir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btImprimir.Location = new System.Drawing.Point(677, 505);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(66, 28);
            this.btImprimir.TabIndex = 13;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = false;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCadastrar.BackColor = System.Drawing.SystemColors.Window;
            this.btCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCadastrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCadastrar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btCadastrar.Location = new System.Drawing.Point(749, 505);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(66, 28);
            this.btCadastrar.TabIndex = 12;
            this.btCadastrar.Text = "Gravar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.BackColor = System.Drawing.SystemColors.Window;
            this.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancelar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(605, 505);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(66, 28);
            this.btCancelar.TabIndex = 14;
            this.btCancelar.Text = "Fechar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // gbTabelaPreco
            // 
            this.gbTabelaPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTabelaPreco.BackColor = System.Drawing.SystemColors.Window;
            this.gbTabelaPreco.Controls.Add(this.txValorVenda);
            this.gbTabelaPreco.Controls.Add(this.lbValorVenda);
            this.gbTabelaPreco.Controls.Add(this.lbValorMinimo);
            this.gbTabelaPreco.Controls.Add(this.lbCusto);
            this.gbTabelaPreco.Controls.Add(this.txValorCompra);
            this.gbTabelaPreco.Controls.Add(this.txLucroTotal);
            this.gbTabelaPreco.Controls.Add(this.lbLucroTotal);
            this.gbTabelaPreco.Controls.Add(this.txValorMinimo);
            this.gbTabelaPreco.Controls.Add(this.label2);
            this.gbTabelaPreco.Controls.Add(this.txTotalEstoque);
            this.gbTabelaPreco.Controls.Add(this.txTotalEstoqueVenda);
            this.gbTabelaPreco.Controls.Add(this.lbTotalEstoque);
            this.gbTabelaPreco.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTabelaPreco.Location = new System.Drawing.Point(6, 137);
            this.gbTabelaPreco.Name = "gbTabelaPreco";
            this.gbTabelaPreco.Size = new System.Drawing.Size(809, 112);
            this.gbTabelaPreco.TabIndex = 33;
            this.gbTabelaPreco.TabStop = false;
            this.gbTabelaPreco.Text = "Tabela de Precificação";
            // 
            // txValorVenda
            // 
            this.txValorVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txValorVenda.Location = new System.Drawing.Point(630, 26);
            this.txValorVenda.Name = "txValorVenda";
            this.txValorVenda.Size = new System.Drawing.Size(173, 21);
            this.txValorVenda.TabIndex = 10;
            this.txValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txValorVenda_KeyPress);
            this.txValorVenda.Leave += new System.EventHandler(this.txValorVenda_Leave);
            // 
            // lbCusto
            // 
            this.lbCusto.AutoSize = true;
            this.lbCusto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCusto.Location = new System.Drawing.Point(5, 30);
            this.lbCusto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCusto.Name = "lbCusto";
            this.lbCusto.Size = new System.Drawing.Size(74, 13);
            this.lbCusto.TabIndex = 32;
            this.lbCusto.Text = "Preço Compra";
            // 
            // txValorCompra
            // 
            this.txValorCompra.Location = new System.Drawing.Point(86, 27);
            this.txValorCompra.Name = "txValorCompra";
            this.txValorCompra.Size = new System.Drawing.Size(185, 21);
            this.txValorCompra.TabIndex = 8;
            this.txValorCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txValorCompra_KeyPress);
            this.txValorCompra.Leave += new System.EventHandler(this.txValorCompra_Leave);
            // 
            // txLucroTotal
            // 
            this.txLucroTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txLucroTotal.Location = new System.Drawing.Point(630, 59);
            this.txLucroTotal.Name = "txLucroTotal";
            this.txLucroTotal.ReadOnly = true;
            this.txLucroTotal.Size = new System.Drawing.Size(173, 21);
            this.txLucroTotal.TabIndex = 17;
            // 
            // lbLucroTotal
            // 
            this.lbLucroTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLucroTotal.AutoSize = true;
            this.lbLucroTotal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbLucroTotal.Location = new System.Drawing.Point(564, 65);
            this.lbLucroTotal.Name = "lbLucroTotal";
            this.lbLucroTotal.Size = new System.Drawing.Size(60, 13);
            this.lbLucroTotal.TabIndex = 39;
            this.lbLucroTotal.Text = "Lucro Total";
            // 
            // txValorMinimo
            // 
            this.txValorMinimo.Location = new System.Drawing.Point(358, 27);
            this.txValorMinimo.Name = "txValorMinimo";
            this.txValorMinimo.Size = new System.Drawing.Size(173, 21);
            this.txValorMinimo.TabIndex = 9;
            this.txValorMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txValorMinimo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(273, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Estoque Venda";
            // 
            // txTotalEstoque
            // 
            this.txTotalEstoque.Location = new System.Drawing.Point(86, 59);
            this.txTotalEstoque.Name = "txTotalEstoque";
            this.txTotalEstoque.ReadOnly = true;
            this.txTotalEstoque.Size = new System.Drawing.Size(185, 21);
            this.txTotalEstoque.TabIndex = 15;
            // 
            // txTotalEstoqueVenda
            // 
            this.txTotalEstoqueVenda.Location = new System.Drawing.Point(358, 59);
            this.txTotalEstoqueVenda.Name = "txTotalEstoqueVenda";
            this.txTotalEstoqueVenda.ReadOnly = true;
            this.txTotalEstoqueVenda.Size = new System.Drawing.Size(173, 21);
            this.txTotalEstoqueVenda.TabIndex = 16;
            // 
            // lbTotalEstoque
            // 
            this.lbTotalEstoque.AutoSize = true;
            this.lbTotalEstoque.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbTotalEstoque.Location = new System.Drawing.Point(7, 62);
            this.lbTotalEstoque.Name = "lbTotalEstoque";
            this.lbTotalEstoque.Size = new System.Drawing.Size(73, 13);
            this.lbTotalEstoque.TabIndex = 36;
            this.lbTotalEstoque.Text = "Total Estoque";
            // 
            // txMargemLucro
            // 
            this.txMargemLucro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txMargemLucro.Location = new System.Drawing.Point(484, 508);
            this.txMargemLucro.Name = "txMargemLucro";
            this.txMargemLucro.ReadOnly = true;
            this.txMargemLucro.Size = new System.Drawing.Size(96, 22);
            this.txMargemLucro.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label3.Location = new System.Drawing.Point(409, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Margem Lucro";
            // 
            // btListaParceiros
            // 
            this.btListaParceiros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btListaParceiros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btListaParceiros.Location = new System.Drawing.Point(98, 76);
            this.btListaParceiros.Name = "btListaParceiros";
            this.btListaParceiros.Size = new System.Drawing.Size(36, 21);
            this.btListaParceiros.TabIndex = 4;
            this.btListaParceiros.Text = "...";
            this.btListaParceiros.UseVisualStyleBackColor = true;
            this.btListaParceiros.Click += new System.EventHandler(this.btListaParceiros_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.SystemColors.Window;
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(98, 107);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(208, 21);
            this.cbCategoria.TabIndex = 5;
            // 
            // cbMarca
            // 
            this.cbMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMarca.BackColor = System.Drawing.SystemColors.Window;
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(651, 107);
            this.cbMarca.Margin = new System.Windows.Forms.Padding(4);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(164, 21);
            this.cbMarca.TabIndex = 6;
            // 
            // dtDataInsercao
            // 
            this.dtDataInsercao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDataInsercao.Enabled = false;
            this.dtDataInsercao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataInsercao.Location = new System.Drawing.Point(699, 79);
            this.dtDataInsercao.Name = "dtDataInsercao";
            this.dtDataInsercao.Size = new System.Drawing.Size(116, 22);
            this.dtDataInsercao.TabIndex = 41;
            // 
            // dgEntradasEstoque
            // 
            this.dgEntradasEstoque.AllowUserToAddRows = false;
            this.dgEntradasEstoque.AllowUserToDeleteRows = false;
            this.dgEntradasEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntradasEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.quantidade,
            this.valorUnitario,
            this.dataInsercao});
            this.dgEntradasEstoque.Location = new System.Drawing.Point(6, 20);
            this.dgEntradasEstoque.Name = "dgEntradasEstoque";
            this.dgEntradasEstoque.ReadOnly = true;
            this.dgEntradasEstoque.Size = new System.Drawing.Size(797, 202);
            this.dgEntradasEstoque.TabIndex = 42;
            // 
            // gpEntradaEstoque
            // 
            this.gpEntradaEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpEntradaEstoque.BackColor = System.Drawing.SystemColors.Window;
            this.gpEntradaEstoque.Controls.Add(this.dgEntradasEstoque);
            this.gpEntradaEstoque.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpEntradaEstoque.Location = new System.Drawing.Point(6, 268);
            this.gpEntradaEstoque.Name = "gpEntradaEstoque";
            this.gpEntradaEstoque.Size = new System.Drawing.Size(809, 231);
            this.gpEntradaEstoque.TabIndex = 43;
            this.gpEntradaEstoque.TabStop = false;
            this.gpEntradaEstoque.Text = "Entrada de Estoque";
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 369;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 125;
            // 
            // valorUnitario
            // 
            this.valorUnitario.DataPropertyName = "valorUnitario";
            this.valorUnitario.HeaderText = "Valor Unitário";
            this.valorUnitario.Name = "valorUnitario";
            this.valorUnitario.ReadOnly = true;
            this.valorUnitario.Width = 130;
            // 
            // dataInsercao
            // 
            this.dataInsercao.DataPropertyName = "dataInsercao";
            this.dataInsercao.HeaderText = "Data";
            this.dataInsercao.Name = "dataInsercao";
            this.dataInsercao.ReadOnly = true;
            this.dataInsercao.Width = 130;
            // 
            // CadastroItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(825, 545);
            this.Controls.Add(this.gpEntradaEstoque);
            this.Controls.Add(this.txMargemLucro);
            this.Controls.Add(this.dtDataInsercao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.btListaParceiros);
            this.Controls.Add(this.gbTabelaPreco);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.txQuantidade);
            this.Controls.Add(this.lbDataInsercao);
            this.Controls.Add(this.cbUnidadeMedida);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbUnidadeMedida);
            this.Controls.Add(this.lbQuantidade);
            this.Controls.Add(this.lbCategoria);
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
            this.MaximizeBox = false;
            this.Name = "CadastroItemView";
            this.Text = "Cadastro de Item";
            this.gbTabelaPreco.ResumeLayout(false);
            this.gbTabelaPreco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntradasEstoque)).EndInit();
            this.gpEntradaEstoque.ResumeLayout(false);
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
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.Label lbUnidadeMedida;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.ComboBox cbUnidadeMedida;
        private System.Windows.Forms.Label lbDataInsercao;
        private System.Windows.Forms.MaskedTextBox txQuantidade;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.GroupBox gbTabelaPreco;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbCusto;
        private System.Windows.Forms.TextBox txValorVenda;
        private System.Windows.Forms.TextBox txValorMinimo;
        private System.Windows.Forms.TextBox txValorCompra;
        private System.Windows.Forms.Button btListaParceiros;
        private System.Windows.Forms.TextBox txTotalEstoque;
        private System.Windows.Forms.Label lbTotalEstoque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txTotalEstoqueVenda;
        private System.Windows.Forms.TextBox txMargemLucro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbLucroTotal;
        private System.Windows.Forms.TextBox txLucroTotal;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.DateTimePicker dtDataInsercao;
        private System.Windows.Forms.DataGridView dgEntradasEstoque;
        private System.Windows.Forms.GroupBox gpEntradaEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInsercao;
    }
}