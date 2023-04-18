namespace SB1.ProjTest.View
{
    partial class ListaParceiroView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btSelecionarItem = new System.Windows.Forms.Button();
            this.gpListaItens = new System.Windows.Forms.GroupBox();
            this.btCadastrarFornecedor = new System.Windows.Forms.Button();
            this.dgConsultaParceiro = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parceiroNegocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInsercao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAtualizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpListaItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultaParceiro)).BeginInit();
            this.SuspendLayout();
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
            // gpListaItens
            // 
            this.gpListaItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpListaItens.BackColor = System.Drawing.SystemColors.Window;
            this.gpListaItens.Controls.Add(this.btCadastrarFornecedor);
            this.gpListaItens.Controls.Add(this.dgConsultaParceiro);
            this.gpListaItens.Controls.Add(this.btSelecionarItem);
            this.gpListaItens.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpListaItens.Location = new System.Drawing.Point(16, 16);
            this.gpListaItens.Name = "gpListaItens";
            this.gpListaItens.Size = new System.Drawing.Size(671, 402);
            this.gpListaItens.TabIndex = 19;
            this.gpListaItens.TabStop = false;
            this.gpListaItens.Text = "Lista de Itens";
            // 
            // btCadastrarFornecedor
            // 
            this.btCadastrarFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCadastrarFornecedor.BackColor = System.Drawing.SystemColors.Window;
            this.btCadastrarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCadastrarFornecedor.Location = new System.Drawing.Point(110, 362);
            this.btCadastrarFornecedor.Name = "btCadastrarFornecedor";
            this.btCadastrarFornecedor.Size = new System.Drawing.Size(122, 34);
            this.btCadastrarFornecedor.TabIndex = 37;
            this.btCadastrarFornecedor.Text = "Cadastrar Parceiro";
            this.btCadastrarFornecedor.UseVisualStyleBackColor = false;
            this.btCadastrarFornecedor.Click += new System.EventHandler(this.btCadastrarFornecedor_Click);
            // 
            // dgConsultaParceiro
            // 
            this.dgConsultaParceiro.AllowUserToAddRows = false;
            this.dgConsultaParceiro.AllowUserToDeleteRows = false;
            this.dgConsultaParceiro.AllowUserToResizeColumns = false;
            this.dgConsultaParceiro.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            this.dgConsultaParceiro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgConsultaParceiro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgConsultaParceiro.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgConsultaParceiro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgConsultaParceiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsultaParceiro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.parceiroNegocio,
            this.nome,
            this.documento,
            this.telefone,
            this.eMail,
            this.dataInsercao,
            this.ativo,
            this.dataAtualizacao,
            this.tipoDocumento});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgConsultaParceiro.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgConsultaParceiro.Location = new System.Drawing.Point(6, 20);
            this.dgConsultaParceiro.MultiSelect = false;
            this.dgConsultaParceiro.Name = "dgConsultaParceiro";
            this.dgConsultaParceiro.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgConsultaParceiro.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dgConsultaParceiro.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgConsultaParceiro.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgConsultaParceiro.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgConsultaParceiro.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgConsultaParceiro.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dgConsultaParceiro.Size = new System.Drawing.Size(656, 336);
            this.dgConsultaParceiro.TabIndex = 16;
            this.dgConsultaParceiro.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgConsultaParceiro_CellMouseDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.id.DefaultCellStyle = dataGridViewCellStyle3;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 62;
            // 
            // parceiroNegocio
            // 
            this.parceiroNegocio.DataPropertyName = "parceiroNegocio";
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.parceiroNegocio.DefaultCellStyle = dataGridViewCellStyle4;
            this.parceiroNegocio.HeaderText = "Tipo de Parceiro";
            this.parceiroNegocio.Name = "parceiroNegocio";
            this.parceiroNegocio.ReadOnly = true;
            this.parceiroNegocio.Visible = false;
            this.parceiroNegocio.Width = 120;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nome.DefaultCellStyle = dataGridViewCellStyle5;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 250;
            // 
            // documento
            // 
            this.documento.DataPropertyName = "documento";
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.documento.DefaultCellStyle = dataGridViewCellStyle6;
            this.documento.HeaderText = "Documento";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            this.documento.Visible = false;
            this.documento.Width = 150;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.telefone.DefaultCellStyle = dataGridViewCellStyle7;
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Width = 150;
            // 
            // eMail
            // 
            this.eMail.DataPropertyName = "eMail";
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.eMail.DefaultCellStyle = dataGridViewCellStyle8;
            this.eMail.HeaderText = "E-mail";
            this.eMail.Name = "eMail";
            this.eMail.ReadOnly = true;
            this.eMail.Visible = false;
            this.eMail.Width = 204;
            // 
            // dataInsercao
            // 
            this.dataInsercao.DataPropertyName = "dataInsercao";
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.dataInsercao.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataInsercao.HeaderText = "Data de Inserção";
            this.dataInsercao.Name = "dataInsercao";
            this.dataInsercao.ReadOnly = true;
            this.dataInsercao.Width = 150;
            // 
            // ativo
            // 
            this.ativo.DataPropertyName = "ativo";
            this.ativo.HeaderText = "Ativo";
            this.ativo.Name = "ativo";
            this.ativo.ReadOnly = true;
            this.ativo.Visible = false;
            // 
            // dataAtualizacao
            // 
            this.dataAtualizacao.DataPropertyName = "dataAtualizacao";
            this.dataAtualizacao.HeaderText = "Data de Atualização";
            this.dataAtualizacao.Name = "dataAtualizacao";
            this.dataAtualizacao.ReadOnly = true;
            this.dataAtualizacao.Visible = false;
            // 
            // tipoDocumento
            // 
            this.tipoDocumento.DataPropertyName = "tipoDocumento";
            this.tipoDocumento.HeaderText = "Tipo de Documento";
            this.tipoDocumento.Name = "tipoDocumento";
            this.tipoDocumento.ReadOnly = true;
            this.tipoDocumento.Visible = false;
            // 
            // ListaParceiroView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(704, 433);
            this.Controls.Add(this.gpListaItens);
            this.Name = "ListaParceiroView";
            this.Text = "ListaParceiro";
            this.gpListaItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultaParceiro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSelecionarItem;
        private System.Windows.Forms.GroupBox gpListaItens;
        private System.Windows.Forms.DataGridView dgConsultaParceiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn parceiroNegocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInsercao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAtualizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumento;
        private System.Windows.Forms.Button btCadastrarFornecedor;
    }
}