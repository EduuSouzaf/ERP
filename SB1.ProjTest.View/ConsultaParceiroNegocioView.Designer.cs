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
            this.lbId = new System.Windows.Forms.Label();
            this.txId = new System.Windows.Forms.TextBox();
            this.txNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
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
            this.btAbrir = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btImprimir = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultaParceiro)).BeginInit();
            this.SuspendLayout();
            // 
            // lbId
            // 
            resources.ApplyResources(this.lbId, "lbId");
            this.lbId.Name = "lbId";
            // 
            // txId
            // 
            this.txId.BackColor = System.Drawing.SystemColors.Window;
            this.txId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txId, "txId");
            this.txId.Name = "txId";
            this.txId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txId_KeyPress);
            // 
            // txNome
            // 
            this.txNome.BackColor = System.Drawing.SystemColors.Window;
            this.txNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txNome, "txNome");
            this.txNome.Name = "txNome";
            this.txNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNome_KeyPress);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgConsultaParceiro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
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
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgConsultaParceiro.DefaultCellStyle = dataGridViewCellStyle10;
            resources.ApplyResources(this.dgConsultaParceiro, "dgConsultaParceiro");
            this.dgConsultaParceiro.MultiSelect = false;
            this.dgConsultaParceiro.Name = "dgConsultaParceiro";
            this.dgConsultaParceiro.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgConsultaParceiro.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgConsultaParceiro.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgConsultaParceiro.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgConsultaParceiro.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dgConsultaParceiro.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgConsultaParceiro.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.Window;
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
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // parceiroNegocio
            // 
            this.parceiroNegocio.DataPropertyName = "parceiroNegocio";
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.parceiroNegocio.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.parceiroNegocio, "parceiroNegocio");
            this.parceiroNegocio.Name = "parceiroNegocio";
            this.parceiroNegocio.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nome.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.nome, "nome");
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // documento
            // 
            this.documento.DataPropertyName = "documento";
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.documento.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(this.documento, "documento");
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.telefone.DefaultCellStyle = dataGridViewCellStyle7;
            resources.ApplyResources(this.telefone, "telefone");
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            // 
            // eMail
            // 
            this.eMail.DataPropertyName = "eMail";
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.eMail.DefaultCellStyle = dataGridViewCellStyle8;
            resources.ApplyResources(this.eMail, "eMail");
            this.eMail.Name = "eMail";
            this.eMail.ReadOnly = true;
            // 
            // dataInsercao
            // 
            this.dataInsercao.DataPropertyName = "dataInsercao";
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.dataInsercao.DefaultCellStyle = dataGridViewCellStyle9;
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
            // btAbrir
            // 
            resources.ApplyResources(this.btAbrir, "btAbrir");
            this.btAbrir.BackColor = System.Drawing.SystemColors.Window;
            this.btAbrir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAbrir.FlatAppearance.BorderSize = 0;
            this.btAbrir.ForeColor = System.Drawing.Color.Black;
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.UseVisualStyleBackColor = false;
            this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // btExcluir
            // 
            resources.ApplyResources(this.btExcluir, "btExcluir");
            this.btExcluir.BackColor = System.Drawing.SystemColors.Window;
            this.btExcluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.ForeColor = System.Drawing.Color.Black;
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btImprimir
            // 
            resources.ApplyResources(this.btImprimir, "btImprimir");
            this.btImprimir.BackColor = System.Drawing.SystemColors.Window;
            this.btImprimir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btImprimir.FlatAppearance.BorderSize = 0;
            this.btImprimir.ForeColor = System.Drawing.Color.Black;
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.UseVisualStyleBackColor = false;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // btConsultar
            // 
            resources.ApplyResources(this.btConsultar, "btConsultar");
            this.btConsultar.BackColor = System.Drawing.SystemColors.Window;
            this.btConsultar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btConsultar.FlatAppearance.BorderSize = 0;
            this.btConsultar.ForeColor = System.Drawing.Color.Black;
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.UseVisualStyleBackColor = false;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.btCancelar, "btCancelar");
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // ConsultaParceiroNegocioView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btAbrir);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.dgConsultaParceiro);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.txId);
            this.Controls.Add(this.lbId);
            this.MaximizeBox = false;
            this.Name = "ConsultaParceiroNegocioView";
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultaParceiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.TextBox txNome;
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
        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btCancelar;
    }
}