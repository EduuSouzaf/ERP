namespace SB1.ProjTest.View
{
    partial class ConsultaItemView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaItemView));
            this.lbId = new System.Windows.Forms.Label();
            this.txId = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.dgConsultaItem = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInsercao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btImprimir = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAbrir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultaItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(15, 29);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(46, 15);
            this.lbId.TabIndex = 12;
            this.lbId.Text = "Código";
            // 
            // txId
            // 
            this.txId.BackColor = System.Drawing.SystemColors.Window;
            this.txId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txId.Location = new System.Drawing.Point(70, 26);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(76, 20);
            this.txId.TabIndex = 1;
            this.txId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txId_KeyPress);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(155, 30);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 14;
            this.lbNome.Text = "Nome";
            // 
            // txNome
            // 
            this.txNome.BackColor = System.Drawing.SystemColors.Window;
            this.txNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(199, 26);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(407, 20);
            this.txNome.TabIndex = 2;
            this.txNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNome_KeyPress);
            // 
            // dgConsultaItem
            // 
            this.dgConsultaItem.AllowUserToAddRows = false;
            this.dgConsultaItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            this.dgConsultaItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgConsultaItem.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgConsultaItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsultaItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.fornecedor,
            this.quantidade,
            this.categoria,
            this.descricao,
            this.valorCompra,
            this.valorMinimo,
            this.valorVenda,
            this.dataInsercao,
            this.ativo,
            this.unidadeMedida});
            this.dgConsultaItem.Location = new System.Drawing.Point(11, 55);
            this.dgConsultaItem.Name = "dgConsultaItem";
            this.dgConsultaItem.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgConsultaItem.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgConsultaItem.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgConsultaItem.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgConsultaItem.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dgConsultaItem.Size = new System.Drawing.Size(669, 253);
            this.dgConsultaItem.TabIndex = 17;
            this.dgConsultaItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgConsultaItem_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 63;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 151;
            // 
            // fornecedor
            // 
            this.fornecedor.DataPropertyName = "fornecedor";
            this.fornecedor.HeaderText = "Fornecedor";
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.ReadOnly = true;
            this.fornecedor.Visible = false;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Visible = false;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoria";
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 110;
            // 
            // valorCompra
            // 
            this.valorCompra.DataPropertyName = "valorCompra";
            this.valorCompra.HeaderText = "Valor de Compra";
            this.valorCompra.Name = "valorCompra";
            this.valorCompra.ReadOnly = true;
            // 
            // valorMinimo
            // 
            this.valorMinimo.DataPropertyName = "valorMinimo";
            this.valorMinimo.HeaderText = "Valor Mínimo";
            this.valorMinimo.Name = "valorMinimo";
            this.valorMinimo.ReadOnly = true;
            this.valorMinimo.Visible = false;
            this.valorMinimo.Width = 103;
            // 
            // valorVenda
            // 
            this.valorVenda.DataPropertyName = "valorVenda";
            this.valorVenda.HeaderText = "Valor de Venda";
            this.valorVenda.Name = "valorVenda";
            this.valorVenda.ReadOnly = true;
            this.valorVenda.Width = 104;
            // 
            // dataInsercao
            // 
            this.dataInsercao.DataPropertyName = "dataInsercao";
            this.dataInsercao.HeaderText = "Data de Inserção";
            this.dataInsercao.Name = "dataInsercao";
            this.dataInsercao.ReadOnly = true;
            this.dataInsercao.Visible = false;
            // 
            // ativo
            // 
            this.ativo.DataPropertyName = "ativo";
            this.ativo.HeaderText = "Ativo";
            this.ativo.Name = "ativo";
            this.ativo.ReadOnly = true;
            this.ativo.Visible = false;
            // 
            // unidadeMedida
            // 
            this.unidadeMedida.DataPropertyName = "unidadeMedida";
            this.unidadeMedida.HeaderText = "Unidade de Medida";
            this.unidadeMedida.Name = "unidadeMedida";
            this.unidadeMedida.ReadOnly = true;
            this.unidadeMedida.Visible = false;
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
            this.btConsultar.Location = new System.Drawing.Point(615, 22);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(65, 27);
            this.btConsultar.TabIndex = 3;
            this.btConsultar.Text = "Buscar";
            this.btConsultar.UseVisualStyleBackColor = false;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btImprimir
            // 
            this.btImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btImprimir.BackColor = System.Drawing.SystemColors.Window;
            this.btImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btImprimir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btImprimir.FlatAppearance.BorderSize = 0;
            this.btImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btImprimir.ForeColor = System.Drawing.Color.Black;
            this.btImprimir.Location = new System.Drawing.Point(619, 314);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(61, 28);
            this.btImprimir.TabIndex = 17;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = false;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExcluir.BackColor = System.Drawing.SystemColors.Window;
            this.btExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExcluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btExcluir.ForeColor = System.Drawing.Color.Black;
            this.btExcluir.Location = new System.Drawing.Point(169, 313);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(61, 28);
            this.btExcluir.TabIndex = 16;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAbrir
            // 
            this.btAbrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAbrir.BackColor = System.Drawing.SystemColors.Window;
            this.btAbrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAbrir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAbrir.FlatAppearance.BorderSize = 0;
            this.btAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAbrir.ForeColor = System.Drawing.Color.Black;
            this.btAbrir.Location = new System.Drawing.Point(78, 313);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(85, 28);
            this.btAbrir.TabIndex = 15;
            this.btAbrir.Text = "Abrir Cadastro";
            this.btAbrir.UseVisualStyleBackColor = false;
            this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.Window;
            this.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancelar.Location = new System.Drawing.Point(11, 314);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(61, 28);
            this.btCancelar.TabIndex = 14;
            this.btCancelar.Text = "Fechar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // ConsultaItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(691, 353);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAbrir);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.dgConsultaItem);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txId);
            this.Controls.Add(this.lbId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultaItemView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Item";
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultaItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.DataGridView dgConsultaItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInsercao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeMedida;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.Button btCancelar;
    }
}