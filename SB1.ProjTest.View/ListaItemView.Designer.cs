namespace SB1.ProjTest.View
{
    partial class ListaItemView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaItemView));
            this.gpListaItens = new System.Windows.Forms.GroupBox();
            this.btSelecionarItem = new System.Windows.Forms.Button();
            this.dgListaItens = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalEstoqueVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpListaItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaItens)).BeginInit();
            this.SuspendLayout();
            // 
            // gpListaItens
            // 
            this.gpListaItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpListaItens.BackColor = System.Drawing.SystemColors.Window;
            this.gpListaItens.Controls.Add(this.btSelecionarItem);
            this.gpListaItens.Controls.Add(this.dgListaItens);
            this.gpListaItens.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpListaItens.Location = new System.Drawing.Point(15, 7);
            this.gpListaItens.Name = "gpListaItens";
            this.gpListaItens.Size = new System.Drawing.Size(832, 402);
            this.gpListaItens.TabIndex = 13;
            this.gpListaItens.TabStop = false;
            this.gpListaItens.Text = "Lista de Itens";
            // 
            // btSelecionarItem
            // 
            this.btSelecionarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSelecionarItem.BackColor = System.Drawing.SystemColors.Window;
            this.btSelecionarItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSelecionarItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelecionarItem.Location = new System.Drawing.Point(6, 362);
            this.btSelecionarItem.Name = "btSelecionarItem";
            this.btSelecionarItem.Size = new System.Drawing.Size(98, 34);
            this.btSelecionarItem.TabIndex = 15;
            this.btSelecionarItem.Text = "Selecionar Item";
            this.btSelecionarItem.UseVisualStyleBackColor = false;
            this.btSelecionarItem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btSelecionarItem_MouseClick);
            // 
            // dgListaItens
            // 
            this.dgListaItens.AllowUserToAddRows = false;
            this.dgListaItens.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            this.dgListaItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgListaItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgListaItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.quantidade,
            this.precoVenda,
            this.categoria,
            this.totalEstoque,
            this.precoCusto,
            this.totalEstoqueVenda});
            this.dgListaItens.Location = new System.Drawing.Point(6, 24);
            this.dgListaItens.Name = "dgListaItens";
            this.dgListaItens.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dgListaItens.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgListaItens.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgListaItens.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgListaItens.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgListaItens.Size = new System.Drawing.Size(820, 332);
            this.dgListaItens.TabIndex = 14;
            this.dgListaItens.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgListaItens_CellFormatting);
            this.dgListaItens.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgListaItens_CellMouseDoubleClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Código Item";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nome.Width = 551;
            // 
            // quantidade
            // 
            this.quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.quantidade.DataPropertyName = "Quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.quantidade.Width = 125;
            // 
            // precoVenda
            // 
            this.precoVenda.DataPropertyName = "precoVenda";
            this.precoVenda.HeaderText = "precoVenda";
            this.precoVenda.Name = "precoVenda";
            this.precoVenda.ReadOnly = true;
            this.precoVenda.Visible = false;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoria";
            this.categoria.HeaderText = "categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Visible = false;
            // 
            // totalEstoque
            // 
            this.totalEstoque.DataPropertyName = "totalEstoque";
            this.totalEstoque.HeaderText = "totalEstoque";
            this.totalEstoque.Name = "totalEstoque";
            this.totalEstoque.ReadOnly = true;
            this.totalEstoque.Visible = false;
            // 
            // precoCusto
            // 
            this.precoCusto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.precoCusto.DataPropertyName = "precoCusto";
            this.precoCusto.HeaderText = "precoCusto";
            this.precoCusto.Name = "precoCusto";
            this.precoCusto.ReadOnly = true;
            this.precoCusto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precoCusto.Visible = false;
            // 
            // totalEstoqueVenda
            // 
            this.totalEstoqueVenda.DataPropertyName = "totalEstoqueVenda";
            this.totalEstoqueVenda.HeaderText = "totalEstoqueVenda";
            this.totalEstoqueVenda.Name = "totalEstoqueVenda";
            this.totalEstoqueVenda.ReadOnly = true;
            this.totalEstoqueVenda.Visible = false;
            // 
            // ListaItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(859, 420);
            this.Controls.Add(this.gpListaItens);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaItemView";
            this.Text = "Lista de Item";
            this.gpListaItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpListaItens;
        private System.Windows.Forms.Button btSelecionarItem;
        private System.Windows.Forms.DataGridView dgListaItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalEstoqueVenda;
    }
}