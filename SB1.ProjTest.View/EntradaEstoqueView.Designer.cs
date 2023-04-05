namespace SB1.ProjTest.View
{
    partial class EntradaEstoqueView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btListaItem = new System.Windows.Forms.Button();
            this.dgListaItem = new System.Windows.Forms.DataGridView();
            this.idItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btGravar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btListaItem
            // 
            this.btListaItem.BackColor = System.Drawing.SystemColors.Window;
            this.btListaItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btListaItem.Location = new System.Drawing.Point(12, 12);
            this.btListaItem.Name = "btListaItem";
            this.btListaItem.Size = new System.Drawing.Size(90, 30);
            this.btListaItem.TabIndex = 36;
            this.btListaItem.Text = "Lista de Item";
            this.btListaItem.UseVisualStyleBackColor = false;
            this.btListaItem.Click += new System.EventHandler(this.btListaItem_Click);
            // 
            // dgListaItem
            // 
            this.dgListaItem.AllowDrop = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            this.dgListaItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgListaItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgListaItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idItem,
            this.nome,
            this.quantidade,
            this.valorTotal,
            this.valorUnitario,
            this.status});
            this.dgListaItem.Location = new System.Drawing.Point(12, 48);
            this.dgListaItem.Name = "dgListaItem";
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dgListaItem.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgListaItem.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgListaItem.Size = new System.Drawing.Size(734, 290);
            this.dgListaItem.TabIndex = 37;
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
            // valorTotal
            // 
            this.valorTotal.DataPropertyName = "valorTotal";
            this.valorTotal.HeaderText = "valorTotal";
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.Visible = false;
            // 
            // valorUnitario
            // 
            this.valorUnitario.DataPropertyName = "valorUnitario";
            this.valorUnitario.HeaderText = "valorUnitario";
            this.valorUnitario.Name = "valorUnitario";
            this.valorUnitario.Visible = false;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.Visible = false;
            this.status.Width = 90;
            // 
            // btGravar
            // 
            this.btGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btGravar.BackColor = System.Drawing.SystemColors.Window;
            this.btGravar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGravar.Location = new System.Drawing.Point(650, 344);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(96, 24);
            this.btGravar.TabIndex = 38;
            this.btGravar.Text = "Gravar";
            this.btGravar.UseVisualStyleBackColor = false;
            // 
            // EntradaEstoqueView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 380);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.dgListaItem);
            this.Controls.Add(this.btListaItem);
            this.Name = "EntradaEstoqueView";
            this.Text = "EntradaEstoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgListaItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btListaItem;
        private System.Windows.Forms.DataGridView dgListaItem;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}