namespace SB1.ProjTest.View
{
    partial class CadastroParceiroNegocioView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroParceiroNegocioView));
            this.lbNome = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.labDataInsercao = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.labId = new System.Windows.Forms.Label();
            this.txID = new System.Windows.Forms.TextBox();
            this.lbTipoParceiro = new System.Windows.Forms.Label();
            this.cbParceiro = new System.Windows.Forms.ComboBox();
            this.labDataAtualizacao = new System.Windows.Forms.Label();
            this.lbTipoDocumento = new System.Windows.Forms.Label();
            this.dgEndereco = new System.Windows.Forms.DataGridView();
            this.logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idParceiroNegocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInsercao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbTipoDocuemento = new System.Windows.Forms.ComboBox();
            this.txDocumento = new System.Windows.Forms.MaskedTextBox();
            this.txTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.gpEndereco = new System.Windows.Forms.GroupBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btExcluirEndereco = new System.Windows.Forms.Button();
            this.btImprimir = new System.Windows.Forms.Button();
            this.txNome = new System.Windows.Forms.MaskedTextBox();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.dtDataInsercao = new System.Windows.Forms.DateTimePicker();
            this.dtDataAtualizacao = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgEndereco)).BeginInit();
            this.gpEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNome.Location = new System.Drawing.Point(45, 50);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(34, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome";
            // 
            // lbTelefone
            // 
            this.lbTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTelefone.Location = new System.Drawing.Point(536, 26);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(49, 13);
            this.lbTelefone.TabIndex = 4;
            this.lbTelefone.Text = "Telefone";
            // 
            // labDataInsercao
            // 
            this.labDataInsercao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labDataInsercao.AutoSize = true;
            this.labDataInsercao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDataInsercao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labDataInsercao.Location = new System.Drawing.Point(614, 76);
            this.labDataInsercao.Name = "labDataInsercao";
            this.labDataInsercao.Size = new System.Drawing.Size(73, 13);
            this.labDataInsercao.TabIndex = 7;
            this.labDataInsercao.Text = "Data inserção";
            // 
            // lbMail
            // 
            this.lbMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.Location = new System.Drawing.Point(550, 49);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(35, 13);
            this.lbMail.TabIndex = 10;
            this.lbMail.Text = "E-mail";
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labId.Location = new System.Drawing.Point(39, 27);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(40, 13);
            this.labId.TabIndex = 19;
            this.labId.Text = "Código";
            // 
            // txID
            // 
            this.txID.AllowDrop = true;
            this.txID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txID.Location = new System.Drawing.Point(85, 23);
            this.txID.Name = "txID";
            this.txID.ReadOnly = true;
            this.txID.Size = new System.Drawing.Size(59, 21);
            this.txID.TabIndex = 20;
            // 
            // lbTipoParceiro
            // 
            this.lbTipoParceiro.AutoSize = true;
            this.lbTipoParceiro.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoParceiro.Location = new System.Drawing.Point(148, 27);
            this.lbTipoParceiro.Name = "lbTipoParceiro";
            this.lbTipoParceiro.Size = new System.Drawing.Size(46, 13);
            this.lbTipoParceiro.TabIndex = 22;
            this.lbTipoParceiro.Text = "Parceiro";
            // 
            // cbParceiro
            // 
            this.cbParceiro.BackColor = System.Drawing.SystemColors.Window;
            this.cbParceiro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParceiro.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParceiro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbParceiro.FormattingEnabled = true;
            this.cbParceiro.Items.AddRange(new object[] {
            "CLIENTE",
            "FORNECEDOR",
            "CLIENTE/FORNECEDOR"});
            this.cbParceiro.Location = new System.Drawing.Point(211, 22);
            this.cbParceiro.Name = "cbParceiro";
            this.cbParceiro.Size = new System.Drawing.Size(320, 21);
            this.cbParceiro.TabIndex = 1;
            // 
            // labDataAtualizacao
            // 
            this.labDataAtualizacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labDataAtualizacao.AutoSize = true;
            this.labDataAtualizacao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDataAtualizacao.Location = new System.Drawing.Point(604, 99);
            this.labDataAtualizacao.Name = "labDataAtualizacao";
            this.labDataAtualizacao.Size = new System.Drawing.Size(83, 13);
            this.labDataAtualizacao.TabIndex = 26;
            this.labDataAtualizacao.Text = "Data aualização";
            // 
            // lbTipoDocumento
            // 
            this.lbTipoDocumento.AutoSize = true;
            this.lbTipoDocumento.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoDocumento.Location = new System.Drawing.Point(21, 75);
            this.lbTipoDocumento.Name = "lbTipoDocumento";
            this.lbTipoDocumento.Size = new System.Drawing.Size(61, 13);
            this.lbTipoDocumento.TabIndex = 30;
            this.lbTipoDocumento.Text = "Documento";
            // 
            // dgEndereco
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            this.dgEndereco.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEndereco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logradouro,
            this.idEndereco,
            this.idParceiroNegocio,
            this.numero,
            this.bairro,
            this.cidade,
            this.estado,
            this.cep,
            this.complemento,
            this.dataInsercao});
            this.dgEndereco.Location = new System.Drawing.Point(7, 17);
            this.dgEndereco.Name = "dgEndereco";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dgEndereco.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgEndereco.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgEndereco.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgEndereco.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgEndereco.Size = new System.Drawing.Size(770, 210);
            this.dgEndereco.TabIndex = 7;
            // 
            // logradouro
            // 
            this.logradouro.DataPropertyName = "logradouro";
            this.logradouro.HeaderText = "Logradouro";
            this.logradouro.Name = "logradouro";
            this.logradouro.Width = 211;
            // 
            // idEndereco
            // 
            this.idEndereco.DataPropertyName = "idEndereco";
            this.idEndereco.HeaderText = "idEndereco";
            this.idEndereco.Name = "idEndereco";
            this.idEndereco.Visible = false;
            // 
            // idParceiroNegocio
            // 
            this.idParceiroNegocio.DataPropertyName = "idParceiroNegocio";
            this.idParceiroNegocio.HeaderText = "idParceiroNegocio";
            this.idParceiroNegocio.Name = "idParceiroNegocio";
            this.idParceiroNegocio.Visible = false;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "Nº";
            this.numero.Name = "numero";
            this.numero.Width = 70;
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "bairro";
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            this.bairro.Width = 123;
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "cidade";
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.Width = 120;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // cep
            // 
            this.cep.DataPropertyName = "cep";
            this.cep.HeaderText = "Cep";
            this.cep.Name = "cep";
            this.cep.Width = 103;
            // 
            // complemento
            // 
            this.complemento.DataPropertyName = "complemento";
            this.complemento.HeaderText = "Complemento";
            this.complemento.Name = "complemento";
            this.complemento.Visible = false;
            this.complemento.Width = 120;
            // 
            // dataInsercao
            // 
            this.dataInsercao.DataPropertyName = "dataInsercao";
            this.dataInsercao.HeaderText = "Data de Inserção";
            this.dataInsercao.Name = "dataInsercao";
            this.dataInsercao.Visible = false;
            // 
            // cbTipoDocuemento
            // 
            this.cbTipoDocuemento.BackColor = System.Drawing.SystemColors.Window;
            this.cbTipoDocuemento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDocuemento.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoDocuemento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbTipoDocuemento.FormattingEnabled = true;
            this.cbTipoDocuemento.Items.AddRange(new object[] {
            "CPF",
            "CNPJ"});
            this.cbTipoDocuemento.Location = new System.Drawing.Point(85, 71);
            this.cbTipoDocuemento.Name = "cbTipoDocuemento";
            this.cbTipoDocuemento.Size = new System.Drawing.Size(53, 21);
            this.cbTipoDocuemento.TabIndex = 3;
            this.cbTipoDocuemento.Leave += new System.EventHandler(this.cbTipoDocuemento_Leave);
            // 
            // txDocumento
            // 
            this.txDocumento.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDocumento.Location = new System.Drawing.Point(148, 72);
            this.txDocumento.Name = "txDocumento";
            this.txDocumento.Size = new System.Drawing.Size(383, 21);
            this.txDocumento.TabIndex = 4;
            this.txDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txDocumento_KeyPress);
            // 
            // txTelefone
            // 
            this.txTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txTelefone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTelefone.Location = new System.Drawing.Point(589, 22);
            this.txTelefone.Mask = "(00)0,0000-0000";
            this.txTelefone.Name = "txTelefone";
            this.txTelefone.Size = new System.Drawing.Size(197, 21);
            this.txTelefone.TabIndex = 5;
            this.txTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txTelefone_KeyPress);
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.BackColor = System.Drawing.SystemColors.Window;
            this.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancelar.Location = new System.Drawing.Point(575, 233);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(63, 24);
            this.btCancelar.TabIndex = 9;
            this.btCancelar.Text = "Fechar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // gpEndereco
            // 
            this.gpEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpEndereco.BackColor = System.Drawing.SystemColors.Window;
            this.gpEndereco.Controls.Add(this.btCadastrar);
            this.gpEndereco.Controls.Add(this.btExcluirEndereco);
            this.gpEndereco.Controls.Add(this.btImprimir);
            this.gpEndereco.Controls.Add(this.dgEndereco);
            this.gpEndereco.Controls.Add(this.btCancelar);
            this.gpEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpEndereco.Location = new System.Drawing.Point(10, 127);
            this.gpEndereco.Name = "gpEndereco";
            this.gpEndereco.Size = new System.Drawing.Size(785, 268);
            this.gpEndereco.TabIndex = 39;
            this.gpEndereco.TabStop = false;
            this.gpEndereco.Text = "Endereço";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCadastrar.BackColor = System.Drawing.SystemColors.Window;
            this.btCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadastrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btCadastrar.Location = new System.Drawing.Point(644, 233);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(63, 24);
            this.btCadastrar.TabIndex = 8;
            this.btCadastrar.Text = "Gravar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btExcluirEndereco
            // 
            this.btExcluirEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btExcluirEndereco.BackColor = System.Drawing.SystemColors.Window;
            this.btExcluirEndereco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExcluirEndereco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExcluirEndereco.FlatAppearance.BorderSize = 0;
            this.btExcluirEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btExcluirEndereco.Location = new System.Drawing.Point(7, 233);
            this.btExcluirEndereco.Name = "btExcluirEndereco";
            this.btExcluirEndereco.Size = new System.Drawing.Size(66, 27);
            this.btExcluirEndereco.TabIndex = 11;
            this.btExcluirEndereco.Text = "Excluir";
            this.btExcluirEndereco.UseVisualStyleBackColor = false;
            this.btExcluirEndereco.Click += new System.EventHandler(this.btExcluirEndereco_Click);
            // 
            // btImprimir
            // 
            this.btImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btImprimir.BackColor = System.Drawing.SystemColors.Window;
            this.btImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImprimir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btImprimir.FlatAppearance.BorderSize = 0;
            this.btImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btImprimir.ForeColor = System.Drawing.Color.Black;
            this.btImprimir.Location = new System.Drawing.Point(713, 233);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(63, 24);
            this.btImprimir.TabIndex = 10;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = false;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // txNome
            // 
            this.txNome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(85, 47);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(446, 21);
            this.txNome.TabIndex = 2;
            this.txNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNome_KeyPress);
            // 
            // txEmail
            // 
            this.txEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txEmail.Location = new System.Drawing.Point(589, 46);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(197, 21);
            this.txEmail.TabIndex = 6;
            // 
            // dtDataInsercao
            // 
            this.dtDataInsercao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDataInsercao.Enabled = false;
            this.dtDataInsercao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataInsercao.Location = new System.Drawing.Point(691, 72);
            this.dtDataInsercao.Name = "dtDataInsercao";
            this.dtDataInsercao.Size = new System.Drawing.Size(95, 21);
            this.dtDataInsercao.TabIndex = 40;
            // 
            // dtDataAtualizacao
            // 
            this.dtDataAtualizacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDataAtualizacao.Enabled = false;
            this.dtDataAtualizacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataAtualizacao.Location = new System.Drawing.Point(691, 96);
            this.dtDataAtualizacao.Name = "dtDataAtualizacao";
            this.dtDataAtualizacao.Size = new System.Drawing.Size(96, 21);
            this.dtDataAtualizacao.TabIndex = 12;
            // 
            // CadastroParceiroNegocioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(805, 409);
            this.Controls.Add(this.dtDataAtualizacao);
            this.Controls.Add(this.dtDataInsercao);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.gpEndereco);
            this.Controls.Add(this.txTelefone);
            this.Controls.Add(this.txDocumento);
            this.Controls.Add(this.lbTipoDocumento);
            this.Controls.Add(this.labDataAtualizacao);
            this.Controls.Add(this.cbParceiro);
            this.Controls.Add(this.lbTipoParceiro);
            this.Controls.Add(this.txID);
            this.Controls.Add(this.labId);
            this.Controls.Add(this.cbTipoDocuemento);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.lbMail);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.labDataInsercao);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastroParceiroNegocioView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Parceiro de Negócio";
            this.TransparencyKey = System.Drawing.SystemColors.Menu;
            ((System.ComponentModel.ISupportInitialize)(this.dgEndereco)).EndInit();
            this.gpEndereco.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label labDataInsercao;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.TextBox txID;
        private System.Windows.Forms.Label lbTipoParceiro;
        private System.Windows.Forms.ComboBox cbParceiro;
        private System.Windows.Forms.Label labDataAtualizacao;
        private System.Windows.Forms.Label lbTipoDocumento;
        private System.Windows.Forms.DataGridView dgEndereco;
        private System.Windows.Forms.ComboBox cbTipoDocuemento;
        private System.Windows.Forms.MaskedTextBox txDocumento;
        private System.Windows.Forms.MaskedTextBox txTelefone;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.GroupBox gpEndereco;
        private System.Windows.Forms.Button btExcluirEndereco;
        private System.Windows.Forms.MaskedTextBox txNome;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn idParceiroNegocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInsercao;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.DateTimePicker dtDataInsercao;
        private System.Windows.Forms.DateTimePicker dtDataAtualizacao;
    }
}