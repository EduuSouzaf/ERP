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
            this.lbNome = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.txId = new System.Windows.Forms.TextBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.gpListaItens = new System.Windows.Forms.GroupBox();
            this.btSelecionarItem = new System.Windows.Forms.Button();
            this.dgListaItens = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInsercao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpListaItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaItens)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(136, 26);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(34, 13);
            this.lbNome.TabIndex = 11;
            this.lbNome.Text = "Nome";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(12, 26);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(40, 13);
            this.lbId.TabIndex = 10;
            this.lbId.Text = "Código";
            // 
            // txNome
            // 
            this.txNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txNome.Location = new System.Drawing.Point(177, 23);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(479, 20);
            this.txNome.TabIndex = 9;
            // 
            // txId
            // 
            this.txId.Location = new System.Drawing.Point(58, 23);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(72, 20);
            this.txId.TabIndex = 8;
            // 
            // btConsultar
            // 
            this.btConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btConsultar.BackColor = System.Drawing.SystemColors.Window;
            this.btConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConsultar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btConsultar.FlatAppearance.BorderSize = 0;
            this.btConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btConsultar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultar.ForeColor = System.Drawing.Color.Black;
            this.btConsultar.Location = new System.Drawing.Point(675, 19);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(84, 27);
            this.btConsultar.TabIndex = 12;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = false;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // gpListaItens
            // 
            this.gpListaItens.BackColor = System.Drawing.SystemColors.Window;
            this.gpListaItens.Controls.Add(this.btSelecionarItem);
            this.gpListaItens.Controls.Add(this.dgListaItens);
            this.gpListaItens.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpListaItens.Location = new System.Drawing.Point(15, 52);
            this.gpListaItens.Name = "gpListaItens";
            this.gpListaItens.Size = new System.Drawing.Size(744, 402);
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
            this.valorVenda,
            this.dataInsercao,
            this.valorMinimo,
            this.custo,
            this.marca,
            this.unidadeMedida,
            this.categoria,
            this.fornecedor,
            this.status,
            this.descricao,
            this.valorCompra});
            this.dgListaItens.Location = new System.Drawing.Point(6, 24);
            this.dgListaItens.Name = "dgListaItens";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dgListaItens.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgListaItens.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgListaItens.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgListaItens.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgListaItens.Size = new System.Drawing.Size(732, 332);
            this.dgListaItens.TabIndex = 14;
            this.dgListaItens.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgListaItens_CellMouseDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Código Item";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 402;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "Quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 87;
            // 
            // valorVenda
            // 
            this.valorVenda.DataPropertyName = "valorVenda";
            this.valorVenda.HeaderText = "Valor Venda";
            this.valorVenda.Name = "valorVenda";
            this.valorVenda.ReadOnly = true;
            // 
            // dataInsercao
            // 
            this.dataInsercao.DataPropertyName = "dataInsercao";
            this.dataInsercao.HeaderText = "dataInsercao";
            this.dataInsercao.Name = "dataInsercao";
            this.dataInsercao.ReadOnly = true;
            this.dataInsercao.Visible = false;
            // 
            // valorMinimo
            // 
            this.valorMinimo.DataPropertyName = "valorMinimo";
            this.valorMinimo.HeaderText = "Valor Mínimo";
            this.valorMinimo.Name = "valorMinimo";
            this.valorMinimo.ReadOnly = true;
            this.valorMinimo.Visible = false;
            // 
            // custo
            // 
            this.custo.DataPropertyName = "custo";
            this.custo.HeaderText = "Custo Unit.";
            this.custo.Name = "custo";
            this.custo.ReadOnly = true;
            this.custo.Visible = false;
            // 
            // marca
            // 
            this.marca.DataPropertyName = "marca";
            this.marca.HeaderText = "marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            this.marca.Visible = false;
            // 
            // unidadeMedida
            // 
            this.unidadeMedida.DataPropertyName = "unidadeMedida";
            this.unidadeMedida.HeaderText = "unidadeMedida";
            this.unidadeMedida.Name = "unidadeMedida";
            this.unidadeMedida.ReadOnly = true;
            this.unidadeMedida.Visible = false;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoria";
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Visible = false;
            // 
            // fornecedor
            // 
            this.fornecedor.DataPropertyName = "fornecedor";
            this.fornecedor.HeaderText = "Fornecedor";
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.ReadOnly = true;
            this.fornecedor.Visible = false;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Visible = false;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Visible = false;
            // 
            // valorCompra
            // 
            this.valorCompra.DataPropertyName = "valorCompra";
            this.valorCompra.HeaderText = "Valor Compra";
            this.valorCompra.Name = "valorCompra";
            this.valorCompra.ReadOnly = true;
            this.valorCompra.Visible = false;
            // 
            // ListaItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(772, 468);
            this.Controls.Add(this.gpListaItens);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.txId);
            this.Controls.Add(this.btConsultar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaItemView";
            this.Text = "Lista de Item";
            this.gpListaItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.GroupBox gpListaItens;
        private System.Windows.Forms.Button btSelecionarItem;
        private System.Windows.Forms.DataGridView dgListaItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInsercao;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn custo;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCompra;
    }
}