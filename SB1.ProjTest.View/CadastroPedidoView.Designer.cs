namespace SB1.ProjTest.View
{
    partial class CadastroPedidoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPedidoView));
            this.txIdPedido = new System.Windows.Forms.TextBox();
            this.lbIdPedido = new System.Windows.Forms.Label();
            this.cbTipoPedido = new System.Windows.Forms.ComboBox();
            this.lbTipoPedido = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.txStatus = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Button();
            this.btDevolverPedido = new System.Windows.Forms.Button();
            this.lbFornecedor = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.txDataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.labDataAtualizacao = new System.Windows.Forms.Label();
            this.txDataInsercao = new System.Windows.Forms.MaskedTextBox();
            this.labDataInsercao = new System.Windows.Forms.Label();
            this.gbItem = new System.Windows.Forms.GroupBox();
            this.btListaItem = new System.Windows.Forms.Button();
            this.dgListaItem = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btCadastrarItem = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btEcluirItem = new System.Windows.Forms.Button();
            this.txIdItem = new System.Windows.Forms.TextBox();
            this.lbCodigoItem = new System.Windows.Forms.Label();
            this.btAdicionarItem = new System.Windows.Forms.Button();
            this.programaEduardoDataSet = new SB1.ProjTest.View.ProgramaEduardoDataSet();
            this.cbEndereco = new System.Windows.Forms.ComboBox();
            this.txIdParceiro = new System.Windows.Forms.TextBox();
            this.btCadastrarFornecedor = new System.Windows.Forms.Button();
            this.btListaParceiros = new System.Windows.Forms.Button();
            this.txParceiro = new System.Windows.Forms.TextBox();
            this.txIdEndereco = new System.Windows.Forms.TextBox();
            this.gbItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programaEduardoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txIdPedido
            // 
            this.txIdPedido.Enabled = false;
            this.txIdPedido.Location = new System.Drawing.Point(117, 19);
            this.txIdPedido.Name = "txIdPedido";
            this.txIdPedido.ReadOnly = true;
            this.txIdPedido.Size = new System.Drawing.Size(44, 20);
            this.txIdPedido.TabIndex = 0;
            // 
            // lbIdPedido
            // 
            this.lbIdPedido.AutoSize = true;
            this.lbIdPedido.Location = new System.Drawing.Point(74, 23);
            this.lbIdPedido.Name = "lbIdPedido";
            this.lbIdPedido.Size = new System.Drawing.Size(40, 13);
            this.lbIdPedido.TabIndex = 1;
            this.lbIdPedido.Text = "Código";
            // 
            // cbTipoPedido
            // 
            this.cbTipoPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTipoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPedido.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTipoPedido.FormattingEnabled = true;
            this.cbTipoPedido.Items.AddRange(new object[] {
            "Pedido de Compra",
            "Pedido de Venda"});
            this.cbTipoPedido.Location = new System.Drawing.Point(264, 19);
            this.cbTipoPedido.Name = "cbTipoPedido";
            this.cbTipoPedido.Size = new System.Drawing.Size(307, 21);
            this.cbTipoPedido.TabIndex = 2;
            // 
            // lbTipoPedido
            // 
            this.lbTipoPedido.AutoSize = true;
            this.lbTipoPedido.Location = new System.Drawing.Point(175, 23);
            this.lbTipoPedido.Name = "lbTipoPedido";
            this.lbTipoPedido.Size = new System.Drawing.Size(79, 13);
            this.lbTipoPedido.TabIndex = 3;
            this.lbTipoPedido.Text = "Tipo de Pedido";
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(593, 23);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(37, 13);
            this.lbStatus.TabIndex = 5;
            this.lbStatus.Text = "Status";
            // 
            // txStatus
            // 
            this.txStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txStatus.Location = new System.Drawing.Point(633, 19);
            this.txStatus.Name = "txStatus";
            this.txStatus.Size = new System.Drawing.Size(217, 20);
            this.txStatus.TabIndex = 4;
            // 
            // lb
            // 
            this.lb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb.BackColor = System.Drawing.SystemColors.Window;
            this.lb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb.Location = new System.Drawing.Point(584, 443);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(122, 28);
            this.lb.TabIndex = 6;
            this.lb.Text = "Cancelar Pedido";
            this.lb.UseVisualStyleBackColor = false;
            // 
            // btDevolverPedido
            // 
            this.btDevolverPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDevolverPedido.BackColor = System.Drawing.SystemColors.Window;
            this.btDevolverPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDevolverPedido.Location = new System.Drawing.Point(712, 443);
            this.btDevolverPedido.Name = "btDevolverPedido";
            this.btDevolverPedido.Size = new System.Drawing.Size(122, 28);
            this.btDevolverPedido.TabIndex = 7;
            this.btDevolverPedido.Text = "Devolução de Pedido";
            this.btDevolverPedido.UseVisualStyleBackColor = false;
            // 
            // lbFornecedor
            // 
            this.lbFornecedor.AutoSize = true;
            this.lbFornecedor.Location = new System.Drawing.Point(16, 54);
            this.lbFornecedor.Name = "lbFornecedor";
            this.lbFornecedor.Size = new System.Drawing.Size(98, 13);
            this.lbFornecedor.TabIndex = 9;
            this.lbFornecedor.Text = "Cliente/Fornecedor";
            // 
            // lbEndereco
            // 
            this.lbEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(578, 54);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(53, 13);
            this.lbEndereco.TabIndex = 12;
            this.lbEndereco.Text = "Endereco";
            // 
            // txDataVencimento
            // 
            this.txDataVencimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txDataVencimento.BackColor = System.Drawing.SystemColors.Window;
            this.txDataVencimento.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDataVencimento.Location = new System.Drawing.Point(117, 82);
            this.txDataVencimento.Mask = "00/00/0000 90:00";
            this.txDataVencimento.Name = "txDataVencimento";
            this.txDataVencimento.Size = new System.Drawing.Size(115, 21);
            this.txDataVencimento.TabIndex = 31;
            this.txDataVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // labDataAtualizacao
            // 
            this.labDataAtualizacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labDataAtualizacao.AutoSize = true;
            this.labDataAtualizacao.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDataAtualizacao.Location = new System.Drawing.Point(10, 85);
            this.labDataAtualizacao.Name = "labDataAtualizacao";
            this.labDataAtualizacao.Size = new System.Drawing.Size(105, 15);
            this.labDataAtualizacao.TabIndex = 30;
            this.labDataAtualizacao.Text = "Data Vencimento";
            // 
            // txDataInsercao
            // 
            this.txDataInsercao.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txDataInsercao.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDataInsercao.Location = new System.Drawing.Point(633, 79);
            this.txDataInsercao.Mask = "00/00/0000 90:00";
            this.txDataInsercao.Name = "txDataInsercao";
            this.txDataInsercao.ReadOnly = true;
            this.txDataInsercao.Size = new System.Drawing.Size(137, 21);
            this.txDataInsercao.TabIndex = 29;
            this.txDataInsercao.ValidatingType = typeof(System.DateTime);
            // 
            // labDataInsercao
            // 
            this.labDataInsercao.AutoSize = true;
            this.labDataInsercao.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDataInsercao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labDataInsercao.Location = new System.Drawing.Point(544, 82);
            this.labDataInsercao.Name = "labDataInsercao";
            this.labDataInsercao.Size = new System.Drawing.Size(86, 15);
            this.labDataInsercao.TabIndex = 28;
            this.labDataInsercao.Text = "Data inserção";
            // 
            // gbItem
            // 
            this.gbItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbItem.Controls.Add(this.btListaItem);
            this.gbItem.Controls.Add(this.dgListaItem);
            this.gbItem.Controls.Add(this.btCadastrarItem);
            this.gbItem.Controls.Add(this.btSalvar);
            this.gbItem.Controls.Add(this.btEcluirItem);
            this.gbItem.Controls.Add(this.txIdItem);
            this.gbItem.Controls.Add(this.lbCodigoItem);
            this.gbItem.Controls.Add(this.btAdicionarItem);
            this.gbItem.Controls.Add(this.lb);
            this.gbItem.Controls.Add(this.btDevolverPedido);
            this.gbItem.Location = new System.Drawing.Point(16, 112);
            this.gbItem.Name = "gbItem";
            this.gbItem.Size = new System.Drawing.Size(969, 486);
            this.gbItem.TabIndex = 32;
            this.gbItem.TabStop = false;
            this.gbItem.Text = "Itens";
            // 
            // btListaItem
            // 
            this.btListaItem.BackColor = System.Drawing.SystemColors.Window;
            this.btListaItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btListaItem.Location = new System.Drawing.Point(8, 19);
            this.btListaItem.Name = "btListaItem";
            this.btListaItem.Size = new System.Drawing.Size(90, 30);
            this.btListaItem.TabIndex = 35;
            this.btListaItem.Text = "Lista de Item";
            this.btListaItem.UseVisualStyleBackColor = false;
            this.btListaItem.Click += new System.EventHandler(this.btListaItem_Click);
            // 
            // dgListaItem
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            this.dgListaItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgListaItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.quantidade,
            this.valorVenda,
            this.valorTotal});
            this.dgListaItem.Location = new System.Drawing.Point(8, 54);
            this.dgListaItem.Name = "dgListaItem";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dgListaItem.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgListaItem.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgListaItem.Size = new System.Drawing.Size(954, 383);
            this.dgListaItem.TabIndex = 34;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Código";
            this.id.Name = "id";
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 400;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            // 
            // valorVenda
            // 
            this.valorVenda.DataPropertyName = "valorVenda";
            this.valorVenda.HeaderText = "Preço Unitário";
            this.valorVenda.Name = "valorVenda";
            this.valorVenda.Width = 150;
            // 
            // valorTotal
            // 
            this.valorTotal.DataPropertyName = "valorTotal";
            this.valorTotal.HeaderText = "Valor Total";
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.Width = 160;
            // 
            // btCadastrarItem
            // 
            this.btCadastrarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCadastrarItem.BackColor = System.Drawing.SystemColors.Window;
            this.btCadastrarItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCadastrarItem.Location = new System.Drawing.Point(105, 19);
            this.btCadastrarItem.Name = "btCadastrarItem";
            this.btCadastrarItem.Size = new System.Drawing.Size(90, 30);
            this.btCadastrarItem.TabIndex = 9;
            this.btCadastrarItem.Text = "Cadastrar Item";
            this.btCadastrarItem.UseVisualStyleBackColor = false;
            this.btCadastrarItem.Click += new System.EventHandler(this.btCadastrarNovoItem_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btSalvar.BackColor = System.Drawing.SystemColors.Window;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSalvar.Location = new System.Drawing.Point(840, 443);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(122, 28);
            this.btSalvar.TabIndex = 33;
            this.btSalvar.Text = "Gravar Pedido";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btEcluirItem
            // 
            this.btEcluirItem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btEcluirItem.BackColor = System.Drawing.SystemColors.Window;
            this.btEcluirItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEcluirItem.Location = new System.Drawing.Point(8, 443);
            this.btEcluirItem.Name = "btEcluirItem";
            this.btEcluirItem.Size = new System.Drawing.Size(75, 32);
            this.btEcluirItem.TabIndex = 8;
            this.btEcluirItem.Text = "Excluir Item";
            this.btEcluirItem.UseVisualStyleBackColor = false;
            // 
            // txIdItem
            // 
            this.txIdItem.Location = new System.Drawing.Point(821, 25);
            this.txIdItem.Name = "txIdItem";
            this.txIdItem.Size = new System.Drawing.Size(42, 20);
            this.txIdItem.TabIndex = 3;
            // 
            // lbCodigoItem
            // 
            this.lbCodigoItem.AutoSize = true;
            this.lbCodigoItem.Location = new System.Drawing.Point(755, 28);
            this.lbCodigoItem.Name = "lbCodigoItem";
            this.lbCodigoItem.Size = new System.Drawing.Size(63, 13);
            this.lbCodigoItem.TabIndex = 2;
            this.lbCodigoItem.Text = "Código Item";
            // 
            // btAdicionarItem
            // 
            this.btAdicionarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdicionarItem.BackColor = System.Drawing.SystemColors.Window;
            this.btAdicionarItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdicionarItem.Location = new System.Drawing.Point(871, 19);
            this.btAdicionarItem.Name = "btAdicionarItem";
            this.btAdicionarItem.Size = new System.Drawing.Size(90, 30);
            this.btAdicionarItem.TabIndex = 1;
            this.btAdicionarItem.Text = "Adicionar Item";
            this.btAdicionarItem.UseVisualStyleBackColor = false;
            this.btAdicionarItem.Click += new System.EventHandler(this.btAdicionarItem_Click);
            // 
            // programaEduardoDataSet
            // 
            this.programaEduardoDataSet.DataSetName = "ProgramaEduardoDataSet";
            this.programaEduardoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbEndereco
            // 
            this.cbEndereco.DisplayMember = "idEndereco";
            this.cbEndereco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEndereco.FormattingEnabled = true;
            this.cbEndereco.Location = new System.Drawing.Point(633, 49);
            this.cbEndereco.Name = "cbEndereco";
            this.cbEndereco.Size = new System.Drawing.Size(217, 21);
            this.cbEndereco.TabIndex = 33;
            this.cbEndereco.ValueMember = "idEndereco";
            this.cbEndereco.Enter += new System.EventHandler(this.cbEndereco_Enter);
            // 
            // txIdParceiro
            // 
            this.txIdParceiro.Location = new System.Drawing.Point(117, 50);
            this.txIdParceiro.Name = "txIdParceiro";
            this.txIdParceiro.ReadOnly = true;
            this.txIdParceiro.Size = new System.Drawing.Size(44, 20);
            this.txIdParceiro.TabIndex = 34;
            // 
            // btCadastrarFornecedor
            // 
            this.btCadastrarFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCadastrarFornecedor.BackColor = System.Drawing.SystemColors.Window;
            this.btCadastrarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCadastrarFornecedor.Location = new System.Drawing.Point(856, 54);
            this.btCadastrarFornecedor.Name = "btCadastrarFornecedor";
            this.btCadastrarFornecedor.Size = new System.Drawing.Size(122, 30);
            this.btCadastrarFornecedor.TabIndex = 36;
            this.btCadastrarFornecedor.Text = "Cadastrar Parceiro";
            this.btCadastrarFornecedor.UseVisualStyleBackColor = false;
            this.btCadastrarFornecedor.Click += new System.EventHandler(this.btCadastrarFornecedor_Click);
            // 
            // btListaParceiros
            // 
            this.btListaParceiros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btListaParceiros.BackColor = System.Drawing.SystemColors.Window;
            this.btListaParceiros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btListaParceiros.Location = new System.Drawing.Point(856, 19);
            this.btListaParceiros.Name = "btListaParceiros";
            this.btListaParceiros.Size = new System.Drawing.Size(122, 30);
            this.btListaParceiros.TabIndex = 37;
            this.btListaParceiros.Text = "Lista de Parceiros";
            this.btListaParceiros.UseVisualStyleBackColor = false;
            this.btListaParceiros.Click += new System.EventHandler(this.btListaParceiros_Click);
            // 
            // txParceiro
            // 
            this.txParceiro.Location = new System.Drawing.Point(168, 49);
            this.txParceiro.Name = "txParceiro";
            this.txParceiro.ReadOnly = true;
            this.txParceiro.Size = new System.Drawing.Size(403, 20);
            this.txParceiro.TabIndex = 38;
            // 
            // txIdEndereco
            // 
            this.txIdEndereco.Enabled = false;
            this.txIdEndereco.Location = new System.Drawing.Point(776, 80);
            this.txIdEndereco.Name = "txIdEndereco";
            this.txIdEndereco.ReadOnly = true;
            this.txIdEndereco.Size = new System.Drawing.Size(44, 20);
            this.txIdEndereco.TabIndex = 39;
            this.txIdEndereco.Visible = false;
            // 
            // CadastroPedidoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(997, 612);
            this.Controls.Add(this.txIdEndereco);
            this.Controls.Add(this.txParceiro);
            this.Controls.Add(this.btListaParceiros);
            this.Controls.Add(this.btCadastrarFornecedor);
            this.Controls.Add(this.txIdParceiro);
            this.Controls.Add(this.cbEndereco);
            this.Controls.Add(this.gbItem);
            this.Controls.Add(this.txDataVencimento);
            this.Controls.Add(this.labDataAtualizacao);
            this.Controls.Add(this.txDataInsercao);
            this.Controls.Add(this.labDataInsercao);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.lbFornecedor);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.txStatus);
            this.Controls.Add(this.lbTipoPedido);
            this.Controls.Add(this.cbTipoPedido);
            this.Controls.Add(this.lbIdPedido);
            this.Controls.Add(this.txIdPedido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroPedidoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pedido";
            this.gbItem.ResumeLayout(false);
            this.gbItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programaEduardoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txIdPedido;
        private System.Windows.Forms.Label lbIdPedido;
        private System.Windows.Forms.ComboBox cbTipoPedido;
        private System.Windows.Forms.Label lbTipoPedido;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox txStatus;
        private System.Windows.Forms.Button lb;
        private System.Windows.Forms.Button btDevolverPedido;
        private System.Windows.Forms.Label lbFornecedor;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.MaskedTextBox txDataVencimento;
        private System.Windows.Forms.Label labDataAtualizacao;
        private System.Windows.Forms.MaskedTextBox txDataInsercao;
        private System.Windows.Forms.Label labDataInsercao;
        private System.Windows.Forms.GroupBox gbItem;
        private System.Windows.Forms.Button btAdicionarItem;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.TextBox txIdItem;
        private System.Windows.Forms.Label lbCodigoItem;
        private System.Windows.Forms.Button btEcluirItem;
        private System.Windows.Forms.Button btCadastrarItem;
        private System.Windows.Forms.ComboBox cbEndereco;
        private System.Windows.Forms.DataGridView dgListaItem;
        private ProgramaEduardoDataSet programaEduardoDataSet;
        private System.Windows.Forms.TextBox txIdParceiro;
        private System.Windows.Forms.Button btListaItem;
        private System.Windows.Forms.Button btCadastrarFornecedor;
        private System.Windows.Forms.Button btListaParceiros;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotal;
        private System.Windows.Forms.TextBox txParceiro;
        private System.Windows.Forms.TextBox txIdEndereco;
    }
}