namespace SB1.ProjTest.View
{
    partial class CadastroMarcaView
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
            this.dgMarca = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAtualizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInsercao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // btGravar
            // 
            this.btGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGravar.Location = new System.Drawing.Point(495, 307);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(75, 23);
            this.btGravar.TabIndex = 15;
            this.btGravar.Text = "Gravar";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // dgMarca
            // 
            this.dgMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMarca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.marca,
            this.descricao,
            this.status,
            this.dataAtualizacao,
            this.dataInsercao});
            this.dgMarca.Location = new System.Drawing.Point(17, 11);
            this.dgMarca.Name = "dgMarca";
            this.dgMarca.Size = new System.Drawing.Size(553, 290);
            this.dgMarca.TabIndex = 14;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.Width = 80;
            // 
            // marca
            // 
            this.marca.DataPropertyName = "marca";
            this.marca.HeaderText = "Nome";
            this.marca.Name = "marca";
            this.marca.Width = 130;
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
            // CadastroMarcaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 340);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.dgMarca);
            this.Name = "CadastroMarcaView";
            this.Text = "CadastroMarcaView";
            ((System.ComponentModel.ISupportInitialize)(this.dgMarca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.DataGridView dgMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAtualizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInsercao;
    }
}