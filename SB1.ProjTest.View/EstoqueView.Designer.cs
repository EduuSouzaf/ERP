namespace SB1.ProjTest.View
{
    partial class EstoqueView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txTotalEstoque = new System.Windows.Forms.TextBox();
            this.lbTotalEstoque = new System.Windows.Forms.Label();
            this.btConsultar = new System.Windows.Forms.Button();
            this.txNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbTotalEstoqueVenda = new System.Windows.Forms.Label();
            this.txTotalEstoqueVenda = new System.Windows.Forms.TextBox();
            this.dgConsultaItem = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadesVendidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalEstoqueVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.btEntradaEstoque = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultaItem)).BeginInit();
            this.SuspendLayout();
            // 
            // txTotalEstoque
            // 
            this.txTotalEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txTotalEstoque.Enabled = false;
            this.txTotalEstoque.Location = new System.Drawing.Point(602, 441);
            this.txTotalEstoque.Name = "txTotalEstoque";
            this.txTotalEstoque.ReadOnly = true;
            this.txTotalEstoque.Size = new System.Drawing.Size(100, 20);
            this.txTotalEstoque.TabIndex = 19;
            // 
            // lbTotalEstoque
            // 
            this.lbTotalEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalEstoque.AutoSize = true;
            this.lbTotalEstoque.Location = new System.Drawing.Point(527, 445);
            this.lbTotalEstoque.Name = "lbTotalEstoque";
            this.lbTotalEstoque.Size = new System.Drawing.Size(73, 13);
            this.lbTotalEstoque.TabIndex = 20;
            this.lbTotalEstoque.Text = "Total Estoque";
            // 
            // btConsultar
            // 
            this.btConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btConsultar.BackColor = System.Drawing.SystemColors.Window;
            this.btConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConsultar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btConsultar.FlatAppearance.BorderSize = 0;
            this.btConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btConsultar.ForeColor = System.Drawing.Color.Black;
            this.btConsultar.Location = new System.Drawing.Point(988, 19);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(65, 27);
            this.btConsultar.TabIndex = 23;
            this.btConsultar.Text = "Buscar";
            this.btConsultar.UseVisualStyleBackColor = false;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // txNome
            // 
            this.txNome.BackColor = System.Drawing.SystemColors.Window;
            this.txNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(169, 22);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(217, 20);
            this.txNome.TabIndex = 22;
            this.txNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNome_KeyPress);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(125, 26);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 25;
            this.lbNome.Text = "Nome";
            // 
            // txId
            // 
            this.txId.BackColor = System.Drawing.SystemColors.Window;
            this.txId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txId.Location = new System.Drawing.Point(66, 22);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(52, 20);
            this.txId.TabIndex = 21;
            this.txId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txId_KeyPress);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(14, 25);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(46, 15);
            this.lbId.TabIndex = 24;
            this.lbId.Text = "Código";
            // 
            // lbTotalEstoqueVenda
            // 
            this.lbTotalEstoqueVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalEstoqueVenda.AutoSize = true;
            this.lbTotalEstoqueVenda.Location = new System.Drawing.Point(711, 445);
            this.lbTotalEstoqueVenda.Name = "lbTotalEstoqueVenda";
            this.lbTotalEstoqueVenda.Size = new System.Drawing.Size(107, 13);
            this.lbTotalEstoqueVenda.TabIndex = 27;
            this.lbTotalEstoqueVenda.Text = "Total Estoque Venda";
            // 
            // txTotalEstoqueVenda
            // 
            this.txTotalEstoqueVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txTotalEstoqueVenda.Enabled = false;
            this.txTotalEstoqueVenda.Location = new System.Drawing.Point(822, 441);
            this.txTotalEstoqueVenda.Name = "txTotalEstoqueVenda";
            this.txTotalEstoqueVenda.ReadOnly = true;
            this.txTotalEstoqueVenda.Size = new System.Drawing.Size(100, 20);
            this.txTotalEstoqueVenda.TabIndex = 26;
            // 
            // dgConsultaItem
            // 
            this.dgConsultaItem.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            this.dgConsultaItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgConsultaItem.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgConsultaItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsultaItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.quantidade,
            this.categoria,
            this.unidadesVendidas,
            this.marca,
            this.precoVenda,
            this.totalEstoqueVenda,
            this.totalEstoque,
            this.precoCusto,
            this.fornecedor});
            this.dgConsultaItem.Location = new System.Drawing.Point(12, 58);
            this.dgConsultaItem.Name = "dgConsultaItem";
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgConsultaItem.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgConsultaItem.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgConsultaItem.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgConsultaItem.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dgConsultaItem.Size = new System.Drawing.Size(1041, 372);
            this.dgConsultaItem.TabIndex = 28;
            this.dgConsultaItem.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgConsultaItem_CellMouseDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Width = 64;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 300;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.Width = 70;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoria";
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.Width = 130;
            // 
            // unidadesVendidas
            // 
            this.unidadesVendidas.DataPropertyName = "unidadesVendidas";
            this.unidadesVendidas.HeaderText = "Unidades Vendidas";
            this.unidadesVendidas.Name = "unidadesVendidas";
            // 
            // marca
            // 
            this.marca.DataPropertyName = "marca";
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.Width = 130;
            // 
            // precoVenda
            // 
            this.precoVenda.DataPropertyName = "precoVenda";
            this.precoVenda.HeaderText = "Preço Unitário";
            this.precoVenda.Name = "precoVenda";
            this.precoVenda.Width = 104;
            // 
            // totalEstoqueVenda
            // 
            this.totalEstoqueVenda.DataPropertyName = "totalEstoqueVenda";
            this.totalEstoqueVenda.HeaderText = "Total Estoque";
            this.totalEstoqueVenda.Name = "totalEstoqueVenda";
            // 
            // totalEstoque
            // 
            this.totalEstoque.DataPropertyName = "totalEstoque";
            this.totalEstoque.HeaderText = "Total";
            this.totalEstoque.Name = "totalEstoque";
            this.totalEstoque.Visible = false;
            // 
            // precoCusto
            // 
            this.precoCusto.DataPropertyName = "precoCusto";
            this.precoCusto.HeaderText = "Valor de Compra";
            this.precoCusto.Name = "precoCusto";
            this.precoCusto.Visible = false;
            // 
            // fornecedor
            // 
            this.fornecedor.DataPropertyName = "fornecedor";
            this.fornecedor.HeaderText = "Fornecedor";
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.Visible = false;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(453, 22);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(176, 21);
            this.cbCategoria.TabIndex = 29;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(392, 26);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(52, 13);
            this.lbCategoria.TabIndex = 30;
            this.lbCategoria.Text = "Categoria";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(635, 25);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(37, 13);
            this.lbMarca.TabIndex = 32;
            this.lbMarca.Text = "Marca";
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(675, 21);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(196, 21);
            this.cbMarca.TabIndex = 31;
            // 
            // btEntradaEstoque
            // 
            this.btEntradaEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEntradaEstoque.BackColor = System.Drawing.SystemColors.Window;
            this.btEntradaEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEntradaEstoque.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btEntradaEstoque.FlatAppearance.BorderSize = 0;
            this.btEntradaEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEntradaEstoque.ForeColor = System.Drawing.Color.Black;
            this.btEntradaEstoque.Location = new System.Drawing.Point(948, 437);
            this.btEntradaEstoque.Name = "btEntradaEstoque";
            this.btEntradaEstoque.Size = new System.Drawing.Size(105, 27);
            this.btEntradaEstoque.TabIndex = 33;
            this.btEntradaEstoque.Text = "Entrada Estoque";
            this.btEntradaEstoque.UseVisualStyleBackColor = false;
            this.btEntradaEstoque.Click += new System.EventHandler(this.btEntradaEstoque_Click);
            // 
            // EstoqueView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 473);
            this.Controls.Add(this.btEntradaEstoque);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.dgConsultaItem);
            this.Controls.Add(this.lbTotalEstoqueVenda);
            this.Controls.Add(this.txTotalEstoqueVenda);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbTotalEstoque);
            this.Controls.Add(this.txTotalEstoque);
            this.Name = "EstoqueView";
            this.Text = "EstoqueView";
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultaItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txTotalEstoque;
        private System.Windows.Forms.Label lbTotalEstoque;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbTotalEstoqueVenda;
        private System.Windows.Forms.TextBox txTotalEstoqueVenda;
        private System.Windows.Forms.DataGridView dgConsultaItem;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadesVendidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalEstoqueVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
        private System.Windows.Forms.Button btEntradaEstoque;
    }
}