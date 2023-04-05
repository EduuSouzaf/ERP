using System;

namespace SB1.ProjTest.View
{
    partial class ConsultaPedidoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaPedidoView));
            this.gpConsulta = new System.Windows.Forms.GroupBox();
            this.btAbrirCadastro = new System.Windows.Forms.Button();
            this.btImprimir = new System.Windows.Forms.Button();
            this.dgConsultaPedido = new System.Windows.Forms.DataGridView();
            this.idPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInsercao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTipoPedido = new System.Windows.Forms.Label();
            this.cbTipoPedido = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.txIdPedido = new System.Windows.Forms.TextBox();
            this.lbParceiro = new System.Windows.Forms.Label();
            this.txIdParceiro = new System.Windows.Forms.TextBox();
            this.txNomeParceiro = new System.Windows.Forms.TextBox();
            this.btListaParceiro = new System.Windows.Forms.Button();
            this.gpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultaPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // gpConsulta
            // 
            this.gpConsulta.Controls.Add(this.btAbrirCadastro);
            this.gpConsulta.Controls.Add(this.btImprimir);
            this.gpConsulta.Controls.Add(this.dgConsultaPedido);
            this.gpConsulta.Location = new System.Drawing.Point(12, 50);
            this.gpConsulta.Name = "gpConsulta";
            this.gpConsulta.Size = new System.Drawing.Size(983, 434);
            this.gpConsulta.TabIndex = 0;
            this.gpConsulta.TabStop = false;
            this.gpConsulta.Text = "Itens";
            // 
            // btAbrirCadastro
            // 
            this.btAbrirCadastro.BackColor = System.Drawing.SystemColors.Window;
            this.btAbrirCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAbrirCadastro.Location = new System.Drawing.Point(7, 394);
            this.btAbrirCadastro.Name = "btAbrirCadastro";
            this.btAbrirCadastro.Size = new System.Drawing.Size(88, 30);
            this.btAbrirCadastro.TabIndex = 12;
            this.btAbrirCadastro.Text = "Abrir Cadastro";
            this.btAbrirCadastro.UseVisualStyleBackColor = false;
            // 
            // btImprimir
            // 
            this.btImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImprimir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImprimir.Location = new System.Drawing.Point(902, 394);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(75, 30);
            this.btImprimir.TabIndex = 11;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = true;
            // 
            // dgConsultaPedido
            // 
            this.dgConsultaPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsultaPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPedido,
            this.tipoPedido,
            this.nome,
            this.totalNota,
            this.dataInsercao,
            this.dataVencimento,
            this.status});
            this.dgConsultaPedido.Location = new System.Drawing.Point(7, 20);
            this.dgConsultaPedido.Name = "dgConsultaPedido";
            this.dgConsultaPedido.Size = new System.Drawing.Size(970, 368);
            this.dgConsultaPedido.TabIndex = 0;
            this.dgConsultaPedido.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgConsultaPedido_CellFormatting);
            this.dgConsultaPedido.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgConsultaPedido_CellMouseDoubleClick);
            // 
            // idPedido
            // 
            this.idPedido.DataPropertyName = "idPedido";
            this.idPedido.HeaderText = "Nº Pedido";
            this.idPedido.Name = "idPedido";
            this.idPedido.Width = 80;
            // 
            // tipoPedido
            // 
            this.tipoPedido.DataPropertyName = "tipoPedido";
            this.tipoPedido.HeaderText = "Tipo de Pedido";
            this.tipoPedido.Name = "tipoPedido";
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Cliente/Fornecedor";
            this.nome.Name = "nome";
            this.nome.Width = 315;
            // 
            // totalNota
            // 
            this.totalNota.DataPropertyName = "totalNota";
            this.totalNota.HeaderText = "Valor Total";
            this.totalNota.Name = "totalNota";
            this.totalNota.Width = 92;
            // 
            // dataInsercao
            // 
            this.dataInsercao.DataPropertyName = "dataInsercao";
            this.dataInsercao.HeaderText = "Data Inserção";
            this.dataInsercao.Name = "dataInsercao";
            // 
            // dataVencimento
            // 
            this.dataVencimento.DataPropertyName = "dataVencimento";
            this.dataVencimento.HeaderText = "Data Vencimento ";
            this.dataVencimento.Name = "dataVencimento";
            this.dataVencimento.Width = 120;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.Width = 120;
            // 
            // lbTipoPedido
            // 
            this.lbTipoPedido.AutoSize = true;
            this.lbTipoPedido.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoPedido.Location = new System.Drawing.Point(588, 17);
            this.lbTipoPedido.Name = "lbTipoPedido";
            this.lbTipoPedido.Size = new System.Drawing.Size(27, 13);
            this.lbTipoPedido.TabIndex = 4;
            this.lbTipoPedido.Text = "Tipo";
            // 
            // cbTipoPedido
            // 
            this.cbTipoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPedido.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoPedido.FormattingEnabled = true;
            this.cbTipoPedido.Items.AddRange(new object[] {
            "",
            "Compra",
            "Venda"});
            this.cbTipoPedido.Location = new System.Drawing.Point(621, 12);
            this.cbTipoPedido.Name = "cbTipoPedido";
            this.cbTipoPedido.Size = new System.Drawing.Size(129, 21);
            this.cbTipoPedido.TabIndex = 5;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(117, 17);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(38, 13);
            this.lbStatus.TabIndex = 6;
            this.lbStatus.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "",
            "Aberto",
            "Cancelado",
            "Parcialmente Atendido",
            "Atendido"});
            this.cbStatus.Location = new System.Drawing.Point(157, 14);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(130, 21);
            this.cbStatus.TabIndex = 7;
            // 
            // btConsultar
            // 
            this.btConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultar.Location = new System.Drawing.Point(891, 14);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(98, 30);
            this.btConsultar.TabIndex = 13;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(19, 17);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 14;
            this.lbCodigo.Text = "Código";
            // 
            // txIdPedido
            // 
            this.txIdPedido.Location = new System.Drawing.Point(61, 14);
            this.txIdPedido.Name = "txIdPedido";
            this.txIdPedido.Size = new System.Drawing.Size(40, 20);
            this.txIdPedido.TabIndex = 15;
            // 
            // lbParceiro
            // 
            this.lbParceiro.AutoSize = true;
            this.lbParceiro.Location = new System.Drawing.Point(300, 16);
            this.lbParceiro.Name = "lbParceiro";
            this.lbParceiro.Size = new System.Drawing.Size(46, 13);
            this.lbParceiro.TabIndex = 16;
            this.lbParceiro.Text = "Parceiro";
            // 
            // txIdParceiro
            // 
            this.txIdParceiro.Location = new System.Drawing.Point(538, 13);
            this.txIdParceiro.Name = "txIdParceiro";
            this.txIdParceiro.Size = new System.Drawing.Size(40, 20);
            this.txIdParceiro.TabIndex = 17;
            // 
            // txNomeParceiro
            // 
            this.txNomeParceiro.Location = new System.Drawing.Point(391, 13);
            this.txNomeParceiro.Name = "txNomeParceiro";
            this.txNomeParceiro.Size = new System.Drawing.Size(144, 20);
            this.txNomeParceiro.TabIndex = 18;
            // 
            // btListaParceiro
            // 
            this.btListaParceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btListaParceiro.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListaParceiro.Location = new System.Drawing.Point(352, 13);
            this.btListaParceiro.Name = "btListaParceiro";
            this.btListaParceiro.Size = new System.Drawing.Size(36, 20);
            this.btListaParceiro.TabIndex = 19;
            this.btListaParceiro.Text = "...";
            this.btListaParceiro.UseVisualStyleBackColor = true;
            this.btListaParceiro.Click += new System.EventHandler(this.btListaParceiro_Click);
            // 
            // ConsultaPedidoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1007, 496);
            this.Controls.Add(this.btListaParceiro);
            this.Controls.Add(this.txNomeParceiro);
            this.Controls.Add(this.txIdParceiro);
            this.Controls.Add(this.lbParceiro);
            this.Controls.Add(this.txIdPedido);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.cbTipoPedido);
            this.Controls.Add(this.lbTipoPedido);
            this.Controls.Add(this.gpConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaPedidoView";
            this.Text = "ConsultaPedido";
            this.gpConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultaPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpConsulta;
        private System.Windows.Forms.DataGridView dgConsultaPedido;
        private System.Windows.Forms.Label lbTipoPedido;
        private System.Windows.Forms.ComboBox cbTipoPedido;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btAbrirCadastro;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox txIdPedido;
        private System.Windows.Forms.Label lbParceiro;
        private System.Windows.Forms.TextBox txIdParceiro;
        private System.Windows.Forms.TextBox txNomeParceiro;
        private System.Windows.Forms.Button btListaParceiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInsercao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}