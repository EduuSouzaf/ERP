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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btSelecionarItem = new System.Windows.Forms.Button();
            this.gpListaItens = new System.Windows.Forms.GroupBox();
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
            this.lbId = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.txId = new System.Windows.Forms.TextBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
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
            this.gpListaItens.BackColor = System.Drawing.SystemColors.Window;
            this.gpListaItens.Controls.Add(this.dgConsultaParceiro);
            this.gpListaItens.Controls.Add(this.btSelecionarItem);
            this.gpListaItens.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpListaItens.Location = new System.Drawing.Point(16, 50);
            this.gpListaItens.Name = "gpListaItens";
            this.gpListaItens.Size = new System.Drawing.Size(671, 402);
            this.gpListaItens.TabIndex = 19;
            this.gpListaItens.TabStop = false;
            this.gpListaItens.Text = "Lista de Itens";
            // 
            // dgConsultaParceiro
            // 
            this.dgConsultaParceiro.AllowUserToAddRows = false;
            this.dgConsultaParceiro.AllowUserToDeleteRows = false;
            this.dgConsultaParceiro.AllowUserToResizeColumns = false;
            this.dgConsultaParceiro.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            this.dgConsultaParceiro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgConsultaParceiro.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgConsultaParceiro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
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
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgConsultaParceiro.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgConsultaParceiro.Location = new System.Drawing.Point(6, 20);
            this.dgConsultaParceiro.MultiSelect = false;
            this.dgConsultaParceiro.Name = "dgConsultaParceiro";
            this.dgConsultaParceiro.ReadOnly = true;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgConsultaParceiro.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dgConsultaParceiro.RowsDefaultCellStyle = dataGridViewCellStyle24;
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
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.id.DefaultCellStyle = dataGridViewCellStyle15;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 62;
            // 
            // parceiroNegocio
            // 
            this.parceiroNegocio.DataPropertyName = "parceiroNegocio";
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.parceiroNegocio.DefaultCellStyle = dataGridViewCellStyle16;
            this.parceiroNegocio.HeaderText = "Tipo de Parceiro";
            this.parceiroNegocio.Name = "parceiroNegocio";
            this.parceiroNegocio.ReadOnly = true;
            this.parceiroNegocio.Visible = false;
            this.parceiroNegocio.Width = 120;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nome.DefaultCellStyle = dataGridViewCellStyle17;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 250;
            // 
            // documento
            // 
            this.documento.DataPropertyName = "documento";
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.documento.DefaultCellStyle = dataGridViewCellStyle18;
            this.documento.HeaderText = "Documento";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            this.documento.Visible = false;
            this.documento.Width = 150;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.telefone.DefaultCellStyle = dataGridViewCellStyle19;
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Width = 150;
            // 
            // eMail
            // 
            this.eMail.DataPropertyName = "eMail";
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.eMail.DefaultCellStyle = dataGridViewCellStyle20;
            this.eMail.HeaderText = "E-mail";
            this.eMail.Name = "eMail";
            this.eMail.ReadOnly = true;
            this.eMail.Visible = false;
            this.eMail.Width = 204;
            // 
            // dataInsercao
            // 
            this.dataInsercao.DataPropertyName = "dataInsercao";
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.dataInsercao.DefaultCellStyle = dataGridViewCellStyle21;
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
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(13, 24);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(40, 13);
            this.lbId.TabIndex = 16;
            this.lbId.Text = "Código";
            // 
            // txNome
            // 
            this.txNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txNome.Location = new System.Drawing.Point(159, 21);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(429, 20);
            this.txNome.TabIndex = 15;
            // 
            // txId
            // 
            this.txId.Location = new System.Drawing.Point(59, 21);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(46, 20);
            this.txId.TabIndex = 14;
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
            this.btConsultar.Location = new System.Drawing.Point(594, 17);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(84, 27);
            this.btConsultar.TabIndex = 18;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = false;
            // 
            // lbNome
            // 
            this.lbNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(118, 24);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(34, 13);
            this.lbNome.TabIndex = 17;
            this.lbNome.Text = "Nome";
            // 
            // ListaParceiroView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(704, 468);
            this.Controls.Add(this.gpListaItens);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.txId);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.lbNome);
            this.Name = "ListaParceiroView";
            this.Text = "ListaParceiro";
            this.gpListaItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultaParceiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSelecionarItem;
        private System.Windows.Forms.GroupBox gpListaItens;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Label lbNome;
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
    }
}