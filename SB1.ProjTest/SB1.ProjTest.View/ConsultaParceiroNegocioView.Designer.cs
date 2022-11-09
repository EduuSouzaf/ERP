namespace SB1.ProjTest.View
{
    partial class ConsultaParceiroNegocioView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaParceiroNegocioView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbId = new System.Windows.Forms.Label();
            this.txId = new System.Windows.Forms.TextBox();
            this.txNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.dgConsultaParceiro = new System.Windows.Forms.DataGridView();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btAbrir = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultaParceiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbId
            // 
            resources.ApplyResources(this.lbId, "lbId");
            this.lbId.Name = "lbId";
            // 
            // txId
            // 
            this.txId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txId, "txId");
            this.txId.Name = "txId";
            // 
            // txNome
            // 
            this.txNome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txNome, "txNome");
            this.txNome.Name = "txNome";
            // 
            // lbNome
            // 
            resources.ApplyResources(this.lbNome, "lbNome");
            this.lbNome.Name = "lbNome";
            // 
            // dgConsultaParceiro
            // 
            this.dgConsultaParceiro.AllowUserToAddRows = false;
            this.dgConsultaParceiro.AllowUserToDeleteRows = false;
            this.dgConsultaParceiro.AllowUserToResizeColumns = false;
            this.dgConsultaParceiro.AllowUserToResizeRows = false;
            this.dgConsultaParceiro.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgConsultaParceiro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
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
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgConsultaParceiro.DefaultCellStyle = dataGridViewCellStyle31;
            resources.ApplyResources(this.dgConsultaParceiro, "dgConsultaParceiro");
            this.dgConsultaParceiro.MultiSelect = false;
            this.dgConsultaParceiro.Name = "dgConsultaParceiro";
            this.dgConsultaParceiro.ReadOnly = true;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgConsultaParceiro.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgConsultaParceiro.RowsDefaultCellStyle = dataGridViewCellStyle33;
            this.dgConsultaParceiro.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgConsultaParceiro_CellMouseDoubleClick);
            // 
            // btConsultar
            // 
            this.btConsultar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            resources.ApplyResources(this.btConsultar, "btConsultar");
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.UseVisualStyleBackColor = false;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btAbrir
            // 
            resources.ApplyResources(this.btAbrir, "btAbrir");
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.UseVisualStyleBackColor = true;
            this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // btExcluir
            // 
            resources.ApplyResources(this.btExcluir, "btExcluir");
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            this.id.DefaultCellStyle = dataGridViewCellStyle24;
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // parceiroNegocio
            // 
            this.parceiroNegocio.DataPropertyName = "parceiroNegocio";
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.parceiroNegocio.DefaultCellStyle = dataGridViewCellStyle25;
            resources.ApplyResources(this.parceiroNegocio, "parceiroNegocio");
            this.parceiroNegocio.Name = "parceiroNegocio";
            this.parceiroNegocio.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nome.DefaultCellStyle = dataGridViewCellStyle26;
            resources.ApplyResources(this.nome, "nome");
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // documento
            // 
            this.documento.DataPropertyName = "documento";
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.documento.DefaultCellStyle = dataGridViewCellStyle27;
            resources.ApplyResources(this.documento, "documento");
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.telefone.DefaultCellStyle = dataGridViewCellStyle28;
            resources.ApplyResources(this.telefone, "telefone");
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            // 
            // eMail
            // 
            this.eMail.DataPropertyName = "eMail";
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.eMail.DefaultCellStyle = dataGridViewCellStyle29;
            resources.ApplyResources(this.eMail, "eMail");
            this.eMail.Name = "eMail";
            this.eMail.ReadOnly = true;
            // 
            // dataInsercao
            // 
            this.dataInsercao.DataPropertyName = "dataInsercao";
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.dataInsercao.DefaultCellStyle = dataGridViewCellStyle30;
            resources.ApplyResources(this.dataInsercao, "dataInsercao");
            this.dataInsercao.Name = "dataInsercao";
            this.dataInsercao.ReadOnly = true;
            // 
            // ativo
            // 
            this.ativo.DataPropertyName = "ativo";
            resources.ApplyResources(this.ativo, "ativo");
            this.ativo.Name = "ativo";
            this.ativo.ReadOnly = true;
            // 
            // dataAtualizacao
            // 
            this.dataAtualizacao.DataPropertyName = "dataAtualizacao";
            resources.ApplyResources(this.dataAtualizacao, "dataAtualizacao");
            this.dataAtualizacao.Name = "dataAtualizacao";
            this.dataAtualizacao.ReadOnly = true;
            // 
            // tipoDocumento
            // 
            this.tipoDocumento.DataPropertyName = "tipoDocumento";
            resources.ApplyResources(this.tipoDocumento, "tipoDocumento");
            this.tipoDocumento.Name = "tipoDocumento";
            this.tipoDocumento.ReadOnly = true;
            // 
            // ConsultaParceiroNegocioView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAbrir);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.dgConsultaParceiro);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.txId);
            this.Controls.Add(this.lbId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ConsultaParceiroNegocioView";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.ConsultaParceiroNegocioView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultaParceiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.DataGridView dgConsultaParceiro;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.DataGridView dataGridView1;
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