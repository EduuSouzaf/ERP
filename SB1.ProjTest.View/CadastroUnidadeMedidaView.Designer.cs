namespace SB1.ProjTest.View
{
    partial class CadastroUnidadeMedidaView
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
            this.btGravar = new System.Windows.Forms.Button();
            this.dgUnidadeMedida = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAtualizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInsercao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgUnidadeMedida)).BeginInit();
            this.SuspendLayout();
            // 
            // btGravar
            // 
            this.btGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGravar.Location = new System.Drawing.Point(490, 308);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(75, 23);
            this.btGravar.TabIndex = 13;
            this.btGravar.Text = "Gravar";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // dgUnidadeMedida
            // 
            this.dgUnidadeMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgUnidadeMedida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUnidadeMedida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.unidadeMedida,
            this.descricao,
            this.status,
            this.dataAtualizacao,
            this.dataInsercao});
            this.dgUnidadeMedida.Location = new System.Drawing.Point(12, 12);
            this.dgUnidadeMedida.Name = "dgUnidadeMedida";
            this.dgUnidadeMedida.Size = new System.Drawing.Size(553, 290);
            this.dgUnidadeMedida.TabIndex = 12;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.Width = 80;
            // 
            // unidadeMedida
            // 
            this.unidadeMedida.DataPropertyName = "unidadeMedida";
            this.unidadeMedida.HeaderText = "Nome";
            this.unidadeMedida.Name = "unidadeMedida";
            this.unidadeMedida.Width = 130;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.Width = 200;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // dataAtualizacao
            // 
            this.dataAtualizacao.DataPropertyName = "dataAtualizacao";
            this.dataAtualizacao.HeaderText = "dataAtualizacao";
            this.dataAtualizacao.Name = "dataAtualizacao";
            this.dataAtualizacao.Visible = false;
            // 
            // dataInsercao
            // 
            this.dataInsercao.DataPropertyName = "dataInsercao";
            this.dataInsercao.HeaderText = "dataInsercao";
            this.dataInsercao.Name = "dataInsercao";
            this.dataInsercao.Visible = false;
            // 
            // CadastroUnidadeMedidaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 346);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.dgUnidadeMedida);
            this.Name = "CadastroUnidadeMedidaView";
            this.Text = "CadastroUnidadeMedida";
            ((System.ComponentModel.ISupportInitialize)(this.dgUnidadeMedida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.DataGridView dgUnidadeMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAtualizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInsercao;
    }
}