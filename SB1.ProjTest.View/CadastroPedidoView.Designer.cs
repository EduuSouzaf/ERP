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
            this.btCancelarPedido = new System.Windows.Forms.Button();
            this.lbFornecedor = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.labDataAtualizacao = new System.Windows.Forms.Label();
            this.labDataInsercao = new System.Windows.Forms.Label();
            this.gbItem = new System.Windows.Forms.GroupBox();
            this.btFinalizarPedido = new System.Windows.Forms.Button();
            this.txTotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btListaItem = new System.Windows.Forms.Button();
            this.dgListaItem = new System.Windows.Forms.DataGridView();
            this.idItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btCadastrarItem = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btEcluirItem = new System.Windows.Forms.Button();
            this.programaEduardoDataSet = new SB1.ProjTest.View.ProgramaEduardoDataSet();
            this.cbEndereco = new System.Windows.Forms.ComboBox();
            this.txIdParceiro = new System.Windows.Forms.TextBox();
            this.txParceiro = new System.Windows.Forms.TextBox();
            this.txIdEndereco = new System.Windows.Forms.TextBox();
            this.DtDataVencimento = new System.Windows.Forms.DateTimePicker();
            this.btListaParceiros = new System.Windows.Forms.Button();
            this.DtDataInsercao = new System.Windows.Forms.DateTimePicker();
            this.btImprimir = new System.Windows.Forms.Button();
            this.gbItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programaEduardoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txIdPedido
            // 
            this.txIdPedido.Enabled = false;
            this.txIdPedido.Location = new System.Drawing.Point(126, 19);
            this.txIdPedido.Name = "txIdPedido";
            this.txIdPedido.ReadOnly = true;
            this.txIdPedido.Size = new System.Drawing.Size(44, 20);
            this.txIdPedido.TabIndex = 0;
            // 
            // lbIdPedido
            // 
            this.lbIdPedido.AutoSize = true;
            this.lbIdPedido.Location = new System.Drawing.Point(80, 23);
            this.lbIdPedido.Name = "lbIdPedido";
            this.lbIdPedido.Size = new System.Drawing.Size(40, 13);
            this.lbIdPedido.TabIndex = 1;
            this.lbIdPedido.Text = "Código";
            // 
            // cbTipoPedido
            // 
            this.cbTipoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPedido.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTipoPedido.FormattingEnabled = true;
            this.cbTipoPedido.Items.AddRange(new object[] {
            "Pedido de Compra",
            "Pedido de Venda"});
            this.cbTipoPedido.Location = new System.Drawing.Point(262, 19);
            this.cbTipoPedido.Name = "cbTipoPedido";
            this.cbTipoPedido.Size = new System.Drawing.Size(182, 21);
            this.cbTipoPedido.TabIndex = 2;
            // 
            // lbTipoPedido
            // 
            this.lbTipoPedido.AutoSize = true;
            this.lbTipoPedido.Location = new System.Drawing.Point(173, 23);
            this.lbTipoPedido.Name = "lbTipoPedido";
            this.lbTipoPedido.Size = new System.Drawing.Size(79, 13);
            this.lbTipoPedido.TabIndex = 3;
            this.lbTipoPedido.Text = "Tipo de Pedido";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(450, 23);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(37, 13);
            this.lbStatus.TabIndex = 5;
            this.lbStatus.Text = "Status";
            // 
            // txStatus
            // 
            this.txStatus.Location = new System.Drawing.Point(493, 19);
            this.txStatus.Name = "txStatus";
            this.txStatus.ReadOnly = true;
            this.txStatus.Size = new System.Drawing.Size(126, 20);
            this.txStatus.TabIndex = 4;
            // 
            // btCancelarPedido
            // 
            this.btCancelarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelarPedido.BackColor = System.Drawing.SystemColors.Window;
            this.btCancelarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancelarPedido.Location = new System.Drawing.Point(666, 348);
            this.btCancelarPedido.Name = "btCancelarPedido";
            this.btCancelarPedido.Size = new System.Drawing.Size(96, 24);
            this.btCancelarPedido.TabIndex = 6;
            this.btCancelarPedido.Text = "Cancelar Pedido";
            this.btCancelarPedido.UseVisualStyleBackColor = false;
            this.btCancelarPedido.Click += new System.EventHandler(this.btCancelarPedido_Click);
            // 
            // lbFornecedor
            // 
            this.lbFornecedor.AutoSize = true;
            this.lbFornecedor.Location = new System.Drawing.Point(19, 54);
            this.lbFornecedor.Name = "lbFornecedor";
            this.lbFornecedor.Size = new System.Drawing.Size(98, 13);
            this.lbFornecedor.TabIndex = 9;
            this.lbFornecedor.Text = "Cliente/Fornecedor";
            // 
            // lbEndereco
            // 
            this.lbEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(626, 53);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(53, 13);
            this.lbEndereco.TabIndex = 12;
            this.lbEndereco.Text = "Endereco";
            // 
            // labDataAtualizacao
            // 
            this.labDataAtualizacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labDataAtualizacao.AutoSize = true;
            this.labDataAtualizacao.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDataAtualizacao.Location = new System.Drawing.Point(805, 21);
            this.labDataAtualizacao.Name = "labDataAtualizacao";
            this.labDataAtualizacao.Size = new System.Drawing.Size(74, 15);
            this.labDataAtualizacao.TabIndex = 30;
            this.labDataAtualizacao.Text = "Vencimento";
            // 
            // labDataInsercao
            // 
            this.labDataInsercao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labDataInsercao.AutoSize = true;
            this.labDataInsercao.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDataInsercao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labDataInsercao.Location = new System.Drawing.Point(625, 19);
            this.labDataInsercao.Name = "labDataInsercao";
            this.labDataInsercao.Size = new System.Drawing.Size(57, 15);
            this.labDataInsercao.TabIndex = 28;
            this.labDataInsercao.Text = "Inserção";
            // 
            // gbItem
            // 
            this.gbItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbItem.Controls.Add(this.btImprimir);
            this.gbItem.Controls.Add(this.btFinalizarPedido);
            this.gbItem.Controls.Add(this.txTotal);
            this.gbItem.Controls.Add(this.lbTotal);
            this.gbItem.Controls.Add(this.btListaItem);
            this.gbItem.Controls.Add(this.dgListaItem);
            this.gbItem.Controls.Add(this.btCadastrarItem);
            this.gbItem.Controls.Add(this.btSalvar);
            this.gbItem.Controls.Add(this.btEcluirItem);
            this.gbItem.Controls.Add(this.btCancelarPedido);
            this.gbItem.Location = new System.Drawing.Point(14, 82);
            this.gbItem.Name = "gbItem";
            this.gbItem.Size = new System.Drawing.Size(969, 381);
            this.gbItem.TabIndex = 32;
            this.gbItem.TabStop = false;
            this.gbItem.Text = "Itens";
            // 
            // btFinalizarPedido
            // 
            this.btFinalizarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btFinalizarPedido.BackColor = System.Drawing.SystemColors.Window;
            this.btFinalizarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btFinalizarPedido.Location = new System.Drawing.Point(766, 348);
            this.btFinalizarPedido.Name = "btFinalizarPedido";
            this.btFinalizarPedido.Size = new System.Drawing.Size(96, 24);
            this.btFinalizarPedido.TabIndex = 38;
            this.btFinalizarPedido.Text = "Finalizar Pedido";
            this.btFinalizarPedido.UseVisualStyleBackColor = false;
            this.btFinalizarPedido.Click += new System.EventHandler(this.btFinalizarPedido_Click);
            // 
            // txTotal
            // 
            this.txTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txTotal.Location = new System.Drawing.Point(872, 322);
            this.txTotal.Name = "txTotal";
            this.txTotal.Size = new System.Drawing.Size(90, 20);
            this.txTotal.TabIndex = 37;
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(831, 325);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(37, 13);
            this.lbTotal.TabIndex = 36;
            this.lbTotal.Text = "Valor: ";
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
            this.dgListaItem.AllowDrop = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            this.dgListaItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgListaItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgListaItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idItem,
            this.nome,
            this.quantidade,
            this.valorUnitario,
            this.valorTotal,
            this.status});
            this.dgListaItem.Location = new System.Drawing.Point(8, 54);
            this.dgListaItem.Name = "dgListaItem";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dgListaItem.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgListaItem.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgListaItem.Size = new System.Drawing.Size(954, 262);
            this.dgListaItem.TabIndex = 34;
            this.dgListaItem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaItem_CellEndEdit);
            this.dgListaItem.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgListaItem_CellMouseDoubleClick);
            this.dgListaItem.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgListaItem_EditingControlShowing);
            // 
            // idItem
            // 
            this.idItem.DataPropertyName = "idItem";
            this.idItem.HeaderText = "Código";
            this.idItem.Name = "idItem";
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 491;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            // 
            // valorUnitario
            // 
            this.valorUnitario.DataPropertyName = "valorUnitario";
            this.valorUnitario.HeaderText = "Preço Unitário";
            this.valorUnitario.Name = "valorUnitario";
            this.valorUnitario.Width = 110;
            // 
            // valorTotal
            // 
            this.valorTotal.DataPropertyName = "valorTotal";
            this.valorTotal.HeaderText = "Valor Total";
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.Width = 110;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.Visible = false;
            this.status.Width = 90;
            // 
            // btCadastrarItem
            // 
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
            this.btSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSalvar.BackColor = System.Drawing.SystemColors.Window;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSalvar.Location = new System.Drawing.Point(866, 348);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(96, 24);
            this.btSalvar.TabIndex = 33;
            this.btSalvar.Text = "Gravar Pedido";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btEcluirItem
            // 
            this.btEcluirItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btEcluirItem.BackColor = System.Drawing.SystemColors.Window;
            this.btEcluirItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEcluirItem.Location = new System.Drawing.Point(6, 348);
            this.btEcluirItem.Name = "btEcluirItem";
            this.btEcluirItem.Size = new System.Drawing.Size(91, 24);
            this.btEcluirItem.TabIndex = 8;
            this.btEcluirItem.Text = "Excluir Item";
            this.btEcluirItem.UseVisualStyleBackColor = false;
            this.btEcluirItem.Click += new System.EventHandler(this.btEcluirItem_Click);
            // 
            // programaEduardoDataSet
            // 
            this.programaEduardoDataSet.DataSetName = "ProgramaEduardoDataSet";
            this.programaEduardoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbEndereco
            // 
            this.cbEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEndereco.DisplayMember = "idEndereco";
            this.cbEndereco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEndereco.FormattingEnabled = true;
            this.cbEndereco.Location = new System.Drawing.Point(685, 49);
            this.cbEndereco.Name = "cbEndereco";
            this.cbEndereco.Size = new System.Drawing.Size(298, 21);
            this.cbEndereco.TabIndex = 33;
            this.cbEndereco.ValueMember = "idEndereco";
            // 
            // txIdParceiro
            // 
            this.txIdParceiro.Location = new System.Drawing.Point(166, 50);
            this.txIdParceiro.Name = "txIdParceiro";
            this.txIdParceiro.ReadOnly = true;
            this.txIdParceiro.Size = new System.Drawing.Size(44, 20);
            this.txIdParceiro.TabIndex = 34;
            // 
            // txParceiro
            // 
            this.txParceiro.Location = new System.Drawing.Point(215, 50);
            this.txParceiro.Name = "txParceiro";
            this.txParceiro.ReadOnly = true;
            this.txParceiro.Size = new System.Drawing.Size(404, 20);
            this.txParceiro.TabIndex = 38;
            this.txParceiro.TextChanged += new System.EventHandler(this.txParceiro_TextChanged);
            // 
            // txIdEndereco
            // 
            this.txIdEndereco.Enabled = false;
            this.txIdEndereco.Location = new System.Drawing.Point(22, 19);
            this.txIdEndereco.Name = "txIdEndereco";
            this.txIdEndereco.ReadOnly = true;
            this.txIdEndereco.Size = new System.Drawing.Size(44, 20);
            this.txIdEndereco.TabIndex = 39;
            this.txIdEndereco.Visible = false;
            // 
            // DtDataVencimento
            // 
            this.DtDataVencimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DtDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtDataVencimento.Location = new System.Drawing.Point(882, 19);
            this.DtDataVencimento.Name = "DtDataVencimento";
            this.DtDataVencimento.Size = new System.Drawing.Size(101, 20);
            this.DtDataVencimento.TabIndex = 40;
            // 
            // btListaParceiros
            // 
            this.btListaParceiros.BackColor = System.Drawing.SystemColors.Window;
            this.btListaParceiros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btListaParceiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListaParceiros.Location = new System.Drawing.Point(126, 50);
            this.btListaParceiros.Name = "btListaParceiros";
            this.btListaParceiros.Size = new System.Drawing.Size(35, 20);
            this.btListaParceiros.TabIndex = 41;
            this.btListaParceiros.Text = "...";
            this.btListaParceiros.UseVisualStyleBackColor = false;
            this.btListaParceiros.Click += new System.EventHandler(this.btListaParceiros_Click);
            // 
            // DtDataInsercao
            // 
            this.DtDataInsercao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DtDataInsercao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtDataInsercao.Location = new System.Drawing.Point(685, 19);
            this.DtDataInsercao.Name = "DtDataInsercao";
            this.DtDataInsercao.Size = new System.Drawing.Size(101, 20);
            this.DtDataInsercao.TabIndex = 42;
            // 
            // btImprimir
            // 
            this.btImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btImprimir.BackColor = System.Drawing.SystemColors.Window;
            this.btImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btImprimir.Location = new System.Drawing.Point(564, 348);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(96, 24);
            this.btImprimir.TabIndex = 39;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = false;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // CadastroPedidoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(997, 475);
            this.Controls.Add(this.DtDataInsercao);
            this.Controls.Add(this.btListaParceiros);
            this.Controls.Add(this.DtDataVencimento);
            this.Controls.Add(this.txIdEndereco);
            this.Controls.Add(this.txIdParceiro);
            this.Controls.Add(this.txParceiro);
            this.Controls.Add(this.cbEndereco);
            this.Controls.Add(this.gbItem);
            this.Controls.Add(this.labDataAtualizacao);
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
        private System.Windows.Forms.Button btCancelarPedido;
        private System.Windows.Forms.Label lbFornecedor;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label labDataAtualizacao;
        private System.Windows.Forms.Label labDataInsercao;
        private System.Windows.Forms.GroupBox gbItem;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btEcluirItem;
        private System.Windows.Forms.Button btCadastrarItem;
        private System.Windows.Forms.ComboBox cbEndereco;
        private System.Windows.Forms.DataGridView dgListaItem;
        private ProgramaEduardoDataSet programaEduardoDataSet;
        private System.Windows.Forms.TextBox txIdParceiro;
        private System.Windows.Forms.Button btListaItem;
        private System.Windows.Forms.TextBox txParceiro;
        private System.Windows.Forms.TextBox txIdEndereco;
        private System.Windows.Forms.DateTimePicker DtDataVencimento;
        private System.Windows.Forms.TextBox txTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btListaParceiros;
        private System.Windows.Forms.DateTimePicker DtDataInsercao;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Button btFinalizarPedido;
        private System.Windows.Forms.Button btImprimir;
    }
}