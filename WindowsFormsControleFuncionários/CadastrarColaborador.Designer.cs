namespace WindowsFormsControleFuncionários
{
    partial class CadastrarColaborador
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNovoColaborador = new System.Windows.Forms.Label();
            this.lblCadastroDo = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.tbxNomeColab = new System.Windows.Forms.TextBox();
            this.tbxCpfColab = new System.Windows.Forms.TextBox();
            this.lblCpfColab = new System.Windows.Forms.Label();
            this.lblPeriodoColab = new System.Windows.Forms.Label();
            this.tbxPeriodo = new System.Windows.Forms.TextBox();
            this.tbxPausas = new System.Windows.Forms.TextBox();
            this.lblHoraPausas = new System.Windows.Forms.Label();
            this.tbxWhatsApp = new System.Windows.Forms.TextBox();
            this.lblWhatsAppColab = new System.Windows.Forms.Label();
            this.tbxInicioContrato = new System.Windows.Forms.TextBox();
            this.lblInicioContrato = new System.Windows.Forms.Label();
            this.tbxEmailColab = new System.Windows.Forms.TextBox();
            this.lblEmailColab = new System.Windows.Forms.Label();
            this.tbxStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbxCargoAtual = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.tbxObservacao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.tbxSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.tbxEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.tbxCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.tbxBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.tbxLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.tbxCep = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.tbxNumResidencia = new System.Windows.Forms.TextBox();
            this.lblNumResidencia = new System.Windows.Forms.Label();
            this.tbxComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.btnCadastroColab = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.pnlLeft.Controls.Add(this.btnMaximizar);
            this.pnlLeft.Controls.Add(this.btnMinimizar);
            this.pnlLeft.Controls.Add(this.btnClose);
            this.pnlLeft.Controls.Add(this.lblNovoColaborador);
            this.pnlLeft.Controls.Add(this.lblCadastroDo);
            this.pnlLeft.Controls.Add(this.pbxLogo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(750, 151);
            this.pnlLeft.TabIndex = 17;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackgroundImage = global::WindowsFormsControleFuncionários.Properties.Resources.Gestão_PRO__3___1_;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.Location = new System.Drawing.Point(701, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(23, 23);
            this.btnMaximizar.TabIndex = 6;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = global::WindowsFormsControleFuncionários.Properties.Resources.minimize_sign;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.Image = global::WindowsFormsControleFuncionários.Properties.Resources.maximize;
            this.btnMinimizar.Location = new System.Drawing.Point(679, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(23, 23);
            this.btnMinimizar.TabIndex = 5;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(723, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblNovoColaborador
            // 
            this.lblNovoColaborador.AutoSize = true;
            this.lblNovoColaborador.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoColaborador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNovoColaborador.Location = new System.Drawing.Point(172, 107);
            this.lblNovoColaborador.Name = "lblNovoColaborador";
            this.lblNovoColaborador.Size = new System.Drawing.Size(226, 32);
            this.lblNovoColaborador.TabIndex = 3;
            this.lblNovoColaborador.Text = "Novo Colaborador";
            // 
            // lblCadastroDo
            // 
            this.lblCadastroDo.AutoSize = true;
            this.lblCadastroDo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroDo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCadastroDo.Location = new System.Drawing.Point(171, 67);
            this.lblCadastroDo.Name = "lblCadastroDo";
            this.lblCadastroDo.Size = new System.Drawing.Size(152, 32);
            this.lblCadastroDo.TabIndex = 2;
            this.lblCadastroDo.Text = "Cadastro do";
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::WindowsFormsControleFuncionários.Properties.Resources.Gestão_PRO;
            this.pbxLogo.Location = new System.Drawing.Point(34, 23);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(121, 117);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCompleto.Location = new System.Drawing.Point(41, 177);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(118, 16);
            this.lblNomeCompleto.TabIndex = 18;
            this.lblNomeCompleto.Text = "Nome Completo";
            // 
            // tbxNomeColab
            // 
            this.tbxNomeColab.Location = new System.Drawing.Point(44, 196);
            this.tbxNomeColab.Name = "tbxNomeColab";
            this.tbxNomeColab.Size = new System.Drawing.Size(347, 20);
            this.tbxNomeColab.TabIndex = 19;
            // 
            // tbxCpfColab
            // 
            this.tbxCpfColab.Location = new System.Drawing.Point(44, 248);
            this.tbxCpfColab.Name = "tbxCpfColab";
            this.tbxCpfColab.Size = new System.Drawing.Size(152, 20);
            this.tbxCpfColab.TabIndex = 21;
            // 
            // lblCpfColab
            // 
            this.lblCpfColab.AutoSize = true;
            this.lblCpfColab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfColab.Location = new System.Drawing.Point(47, 229);
            this.lblCpfColab.Name = "lblCpfColab";
            this.lblCpfColab.Size = new System.Drawing.Size(36, 16);
            this.lblCpfColab.TabIndex = 20;
            this.lblCpfColab.Text = "CPF";
            // 
            // lblPeriodoColab
            // 
            this.lblPeriodoColab.AutoSize = true;
            this.lblPeriodoColab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodoColab.Location = new System.Drawing.Point(243, 229);
            this.lblPeriodoColab.Name = "lblPeriodoColab";
            this.lblPeriodoColab.Size = new System.Drawing.Size(62, 16);
            this.lblPeriodoColab.TabIndex = 22;
            this.lblPeriodoColab.Text = "Período";
            // 
            // tbxPeriodo
            // 
            this.tbxPeriodo.Location = new System.Drawing.Point(239, 248);
            this.tbxPeriodo.Name = "tbxPeriodo";
            this.tbxPeriodo.Size = new System.Drawing.Size(152, 20);
            this.tbxPeriodo.TabIndex = 23;
            // 
            // tbxPausas
            // 
            this.tbxPausas.Location = new System.Drawing.Point(241, 303);
            this.tbxPausas.Name = "tbxPausas";
            this.tbxPausas.Size = new System.Drawing.Size(152, 20);
            this.tbxPausas.TabIndex = 27;
            // 
            // lblHoraPausas
            // 
            this.lblHoraPausas.AutoSize = true;
            this.lblHoraPausas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraPausas.Location = new System.Drawing.Point(245, 284);
            this.lblHoraPausas.Name = "lblHoraPausas";
            this.lblHoraPausas.Size = new System.Drawing.Size(59, 16);
            this.lblHoraPausas.TabIndex = 26;
            this.lblHoraPausas.Text = "Pausas";
            // 
            // tbxWhatsApp
            // 
            this.tbxWhatsApp.Location = new System.Drawing.Point(46, 303);
            this.tbxWhatsApp.Name = "tbxWhatsApp";
            this.tbxWhatsApp.Size = new System.Drawing.Size(152, 20);
            this.tbxWhatsApp.TabIndex = 25;
            // 
            // lblWhatsAppColab
            // 
            this.lblWhatsAppColab.AutoSize = true;
            this.lblWhatsAppColab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhatsAppColab.Location = new System.Drawing.Point(49, 284);
            this.lblWhatsAppColab.Name = "lblWhatsAppColab";
            this.lblWhatsAppColab.Size = new System.Drawing.Size(78, 16);
            this.lblWhatsAppColab.TabIndex = 24;
            this.lblWhatsAppColab.Text = "WhatsApp";
            // 
            // tbxInicioContrato
            // 
            this.tbxInicioContrato.Location = new System.Drawing.Point(241, 358);
            this.tbxInicioContrato.Name = "tbxInicioContrato";
            this.tbxInicioContrato.Size = new System.Drawing.Size(152, 20);
            this.tbxInicioContrato.TabIndex = 31;
            // 
            // lblInicioContrato
            // 
            this.lblInicioContrato.AutoSize = true;
            this.lblInicioContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioContrato.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblInicioContrato.Location = new System.Drawing.Point(245, 339);
            this.lblInicioContrato.Name = "lblInicioContrato";
            this.lblInicioContrato.Size = new System.Drawing.Size(106, 16);
            this.lblInicioContrato.TabIndex = 30;
            this.lblInicioContrato.Text = "Início Contrato";
            // 
            // tbxEmailColab
            // 
            this.tbxEmailColab.Location = new System.Drawing.Point(46, 358);
            this.tbxEmailColab.Name = "tbxEmailColab";
            this.tbxEmailColab.Size = new System.Drawing.Size(152, 20);
            this.tbxEmailColab.TabIndex = 29;
            // 
            // lblEmailColab
            // 
            this.lblEmailColab.AutoSize = true;
            this.lblEmailColab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailColab.Location = new System.Drawing.Point(49, 339);
            this.lblEmailColab.Name = "lblEmailColab";
            this.lblEmailColab.Size = new System.Drawing.Size(51, 16);
            this.lblEmailColab.TabIndex = 28;
            this.lblEmailColab.Text = "E-Mail";
            // 
            // tbxStatus
            // 
            this.tbxStatus.Location = new System.Drawing.Point(241, 411);
            this.tbxStatus.Name = "tbxStatus";
            this.tbxStatus.Size = new System.Drawing.Size(152, 20);
            this.tbxStatus.TabIndex = 35;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(245, 392);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 16);
            this.lblStatus.TabIndex = 34;
            this.lblStatus.Text = "Status";
            // 
            // tbxCargoAtual
            // 
            this.tbxCargoAtual.Location = new System.Drawing.Point(46, 411);
            this.tbxCargoAtual.Name = "tbxCargoAtual";
            this.tbxCargoAtual.Size = new System.Drawing.Size(152, 20);
            this.tbxCargoAtual.TabIndex = 33;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(49, 392);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(88, 16);
            this.lblCargo.TabIndex = 32;
            this.lblCargo.Text = "Cargo Atual";
            // 
            // tbxObservacao
            // 
            this.tbxObservacao.Location = new System.Drawing.Point(241, 465);
            this.tbxObservacao.Name = "tbxObservacao";
            this.tbxObservacao.Size = new System.Drawing.Size(152, 20);
            this.tbxObservacao.TabIndex = 39;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(245, 446);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(100, 16);
            this.lblObservacao.TabIndex = 38;
            this.lblObservacao.Text = "Observações";
            // 
            // tbxSalario
            // 
            this.tbxSalario.Location = new System.Drawing.Point(46, 465);
            this.tbxSalario.Name = "tbxSalario";
            this.tbxSalario.Size = new System.Drawing.Size(152, 20);
            this.tbxSalario.TabIndex = 37;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(49, 446);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(96, 16);
            this.lblSalario.TabIndex = 36;
            this.lblSalario.Text = "Salário Atual";
            // 
            // tbxEstado
            // 
            this.tbxEstado.Location = new System.Drawing.Point(608, 411);
            this.tbxEstado.Name = "tbxEstado";
            this.tbxEstado.Size = new System.Drawing.Size(90, 20);
            this.tbxEstado.TabIndex = 49;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(613, 392);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 16);
            this.lblEstado.TabIndex = 48;
            this.lblEstado.Text = "Estado";
            // 
            // tbxCidade
            // 
            this.tbxCidade.Location = new System.Drawing.Point(450, 411);
            this.tbxCidade.Name = "tbxCidade";
            this.tbxCidade.Size = new System.Drawing.Size(152, 20);
            this.tbxCidade.TabIndex = 47;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(454, 392);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(57, 16);
            this.lblCidade.TabIndex = 46;
            this.lblCidade.Text = "Cidade";
            // 
            // tbxBairro
            // 
            this.tbxBairro.Location = new System.Drawing.Point(450, 358);
            this.tbxBairro.Name = "tbxBairro";
            this.tbxBairro.Size = new System.Drawing.Size(152, 20);
            this.tbxBairro.TabIndex = 45;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBairro.Location = new System.Drawing.Point(454, 339);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(49, 16);
            this.lblBairro.TabIndex = 44;
            this.lblBairro.Text = "Bairro";
            // 
            // tbxLogradouro
            // 
            this.tbxLogradouro.Location = new System.Drawing.Point(450, 303);
            this.tbxLogradouro.Name = "tbxLogradouro";
            this.tbxLogradouro.Size = new System.Drawing.Size(152, 20);
            this.tbxLogradouro.TabIndex = 43;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouro.Location = new System.Drawing.Point(454, 284);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(87, 16);
            this.lblLogradouro.TabIndex = 42;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // tbxCep
            // 
            this.tbxCep.Location = new System.Drawing.Point(448, 248);
            this.tbxCep.Name = "tbxCep";
            this.tbxCep.Size = new System.Drawing.Size(152, 20);
            this.tbxCep.TabIndex = 41;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(452, 229);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(37, 16);
            this.lblCep.TabIndex = 40;
            this.lblCep.Text = "CEP";
            // 
            // tbxNumResidencia
            // 
            this.tbxNumResidencia.Location = new System.Drawing.Point(609, 303);
            this.tbxNumResidencia.Name = "tbxNumResidencia";
            this.tbxNumResidencia.Size = new System.Drawing.Size(89, 20);
            this.tbxNumResidencia.TabIndex = 50;
            // 
            // lblNumResidencia
            // 
            this.lblNumResidencia.AutoSize = true;
            this.lblNumResidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumResidencia.Location = new System.Drawing.Point(613, 284);
            this.lblNumResidencia.Name = "lblNumResidencia";
            this.lblNumResidencia.Size = new System.Drawing.Size(24, 16);
            this.lblNumResidencia.TabIndex = 51;
            this.lblNumResidencia.Text = "Nº";
            // 
            // tbxComplemento
            // 
            this.tbxComplemento.Location = new System.Drawing.Point(450, 465);
            this.tbxComplemento.Name = "tbxComplemento";
            this.tbxComplemento.Size = new System.Drawing.Size(152, 20);
            this.tbxComplemento.TabIndex = 53;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(454, 446);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(102, 16);
            this.lblComplemento.TabIndex = 52;
            this.lblComplemento.Text = "Complemento";
            // 
            // btnCadastroColab
            // 
            this.btnCadastroColab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastroColab.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastroColab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroColab.Location = new System.Drawing.Point(591, 499);
            this.btnCadastroColab.Name = "btnCadastroColab";
            this.btnCadastroColab.Size = new System.Drawing.Size(133, 29);
            this.btnCadastroColab.TabIndex = 54;
            this.btnCadastroColab.Text = "Salvar Cadastro";
            this.btnCadastroColab.UseVisualStyleBackColor = true;
            this.btnCadastroColab.Click += new System.EventHandler(this.btnCadastroColab_Click);
            // 
            // CadastrarColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.btnCadastroColab);
            this.Controls.Add(this.tbxComplemento);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblNumResidencia);
            this.Controls.Add(this.tbxNumResidencia);
            this.Controls.Add(this.tbxEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.tbxCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.tbxBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.tbxLogradouro);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.tbxCep);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.tbxObservacao);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.tbxSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.tbxStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tbxCargoAtual);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.tbxInicioContrato);
            this.Controls.Add(this.lblInicioContrato);
            this.Controls.Add(this.tbxEmailColab);
            this.Controls.Add(this.lblEmailColab);
            this.Controls.Add(this.tbxPausas);
            this.Controls.Add(this.lblHoraPausas);
            this.Controls.Add(this.tbxWhatsApp);
            this.Controls.Add(this.lblWhatsAppColab);
            this.Controls.Add(this.tbxPeriodo);
            this.Controls.Add(this.lblPeriodoColab);
            this.Controls.Add(this.tbxCpfColab);
            this.Controls.Add(this.lblCpfColab);
            this.Controls.Add(this.tbxNomeColab);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastrarColaborador";
            this.Text = "CadastrarColaborador";
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNovoColaborador;
        private System.Windows.Forms.Label lblCadastroDo;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.TextBox tbxNomeColab;
        private System.Windows.Forms.TextBox tbxCpfColab;
        private System.Windows.Forms.Label lblCpfColab;
        private System.Windows.Forms.Label lblPeriodoColab;
        private System.Windows.Forms.TextBox tbxPeriodo;
        private System.Windows.Forms.TextBox tbxPausas;
        private System.Windows.Forms.Label lblHoraPausas;
        private System.Windows.Forms.TextBox tbxWhatsApp;
        private System.Windows.Forms.Label lblWhatsAppColab;
        private System.Windows.Forms.TextBox tbxInicioContrato;
        private System.Windows.Forms.Label lblInicioContrato;
        private System.Windows.Forms.TextBox tbxEmailColab;
        private System.Windows.Forms.Label lblEmailColab;
        private System.Windows.Forms.TextBox tbxStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox tbxCargoAtual;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox tbxObservacao;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox tbxSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox tbxEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox tbxCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox tbxBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox tbxLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox tbxCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox tbxNumResidencia;
        private System.Windows.Forms.Label lblNumResidencia;
        private System.Windows.Forms.TextBox tbxComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Button btnCadastroColab;
    }
}