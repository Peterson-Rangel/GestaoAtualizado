namespace WindowsFormsControleFuncionários
{
    partial class Avaliacao
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
            this.lblAvaliacaoId = new System.Windows.Forms.Label();
            this.btnMaxi = new System.Windows.Forms.Button();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblAvaliacao = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbxHoraEntrada = new System.Windows.Forms.TextBox();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.tbxHoraSaida = new System.Windows.Forms.TextBox();
            this.tbxDataAumento = new System.Windows.Forms.TextBox();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.lblHoraSaida = new System.Windows.Forms.Label();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.lblHoraPausa = new System.Windows.Forms.Label();
            this.lblHoraRetorno = new System.Windows.Forms.Label();
            this.tbxHoraPausa = new System.Windows.Forms.TextBox();
            this.tbxHoraRetorno = new System.Windows.Forms.TextBox();
            this.lblDataAumento = new System.Windows.Forms.Label();
            this.rtbxComentarios = new System.Windows.Forms.RichTextBox();
            this.btnSalvarAvaliacao = new System.Windows.Forms.Button();
            this.llbDoSalario = new System.Windows.Forms.Label();
            this.lblAcompanhamento = new System.Windows.Forms.Label();
            this.pbxIrAcompanhamento = new System.Windows.Forms.PictureBox();
            this.lblRetornarPara = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIrAcompanhamento)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.pnlLeft.Controls.Add(this.lblAvaliacaoId);
            this.pnlLeft.Controls.Add(this.btnMaxi);
            this.pnlLeft.Controls.Add(this.btnMini);
            this.pnlLeft.Controls.Add(this.btnFechar);
            this.pnlLeft.Controls.Add(this.lblAvaliacao);
            this.pnlLeft.Controls.Add(this.pbxLogo);
            this.pnlLeft.Controls.Add(this.lblNomeFuncionario);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(999, 191);
            this.pnlLeft.TabIndex = 22;
            // 
            // lblAvaliacaoId
            // 
            this.lblAvaliacaoId.AutoSize = true;
            this.lblAvaliacaoId.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblAvaliacaoId.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvaliacaoId.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAvaliacaoId.Location = new System.Drawing.Point(406, 139);
            this.lblAvaliacaoId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvaliacaoId.Name = "lblAvaliacaoId";
            this.lblAvaliacaoId.Size = new System.Drawing.Size(177, 32);
            this.lblAvaliacaoId.TabIndex = 20;
            this.lblAvaliacaoId.Text = "Id funcionário";
            // 
            // btnMaxi
            // 
            this.btnMaxi.BackgroundImage = global::WindowsFormsControleFuncionários.Properties.Resources.Gestão_PRO__3___1_;
            this.btnMaxi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaxi.Location = new System.Drawing.Point(936, 4);
            this.btnMaxi.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaxi.Name = "btnMaxi";
            this.btnMaxi.Size = new System.Drawing.Size(31, 28);
            this.btnMaxi.TabIndex = 6;
            this.btnMaxi.UseVisualStyleBackColor = true;
            this.btnMaxi.Click += new System.EventHandler(this.btnMaxi_Click);
            // 
            // btnMini
            // 
            this.btnMini.BackgroundImage = global::WindowsFormsControleFuncionários.Properties.Resources.minimize_sign;
            this.btnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMini.Image = global::WindowsFormsControleFuncionários.Properties.Resources.maximize;
            this.btnMini.Location = new System.Drawing.Point(907, 4);
            this.btnMini.Margin = new System.Windows.Forms.Padding(4);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(31, 28);
            this.btnMini.TabIndex = 5;
            this.btnMini.UseVisualStyleBackColor = true;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(965, 4);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(31, 28);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblAvaliacao
            // 
            this.lblAvaliacao.AutoSize = true;
            this.lblAvaliacao.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvaliacao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAvaliacao.Location = new System.Drawing.Point(402, 22);
            this.lblAvaliacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvaliacao.Name = "lblAvaliacao";
            this.lblAvaliacao.Size = new System.Drawing.Size(236, 62);
            this.lblAvaliacao.TabIndex = 1;
            this.lblAvaliacao.Text = "Avaliação";
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::WindowsFormsControleFuncionários.Properties.Resources.Gestão_PRO;
            this.pbxLogo.Location = new System.Drawing.Point(-1, 5);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(200, 185);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(406, 97);
            this.lblNomeFuncionario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(223, 32);
            this.lblNomeFuncionario.TabIndex = 19;
            this.lblNomeFuncionario.Text = "Nome funcionário";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(844, -54);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 28);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // tbxHoraEntrada
            // 
            this.tbxHoraEntrada.BackColor = System.Drawing.SystemColors.Window;
            this.tbxHoraEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHoraEntrada.Location = new System.Drawing.Point(9, 242);
            this.tbxHoraEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.tbxHoraEntrada.Name = "tbxHoraEntrada";
            this.tbxHoraEntrada.Size = new System.Drawing.Size(206, 34);
            this.tbxHoraEntrada.TabIndex = 23;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackgroundImage = global::WindowsFormsControleFuncionários.Properties.Resources.Gestão_PRO__3___1_;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.Location = new System.Drawing.Point(815, -54);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(31, 28);
            this.btnMaximizar.TabIndex = 21;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = global::WindowsFormsControleFuncionários.Properties.Resources.minimize_sign;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.Image = global::WindowsFormsControleFuncionários.Properties.Resources.maximize;
            this.btnMinimizar.Location = new System.Drawing.Point(785, -54);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(31, 28);
            this.btnMinimizar.TabIndex = 20;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // tbxHoraSaida
            // 
            this.tbxHoraSaida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHoraSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHoraSaida.Location = new System.Drawing.Point(245, 242);
            this.tbxHoraSaida.Margin = new System.Windows.Forms.Padding(4);
            this.tbxHoraSaida.Name = "tbxHoraSaida";
            this.tbxHoraSaida.Size = new System.Drawing.Size(208, 34);
            this.tbxHoraSaida.TabIndex = 29;
            // 
            // tbxDataAumento
            // 
            this.tbxDataAumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDataAumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDataAumento.Location = new System.Drawing.Point(732, 381);
            this.tbxDataAumento.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDataAumento.Name = "tbxDataAumento";
            this.tbxDataAumento.Size = new System.Drawing.Size(206, 34);
            this.tbxDataAumento.TabIndex = 30;
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraEntrada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHoraEntrada.Location = new System.Drawing.Point(13, 206);
            this.lblHoraEntrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(204, 32);
            this.lblHoraEntrada.TabIndex = 32;
            this.lblHoraEntrada.Text = "Hora que entrou";
            // 
            // lblHoraSaida
            // 
            this.lblHoraSaida.AutoSize = true;
            this.lblHoraSaida.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraSaida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHoraSaida.Location = new System.Drawing.Point(251, 206);
            this.lblHoraSaida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraSaida.Name = "lblHoraSaida";
            this.lblHoraSaida.Size = new System.Drawing.Size(173, 32);
            this.lblHoraSaida.TabIndex = 33;
            this.lblHoraSaida.Text = "Hora que saiu";
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblComentarios.Location = new System.Drawing.Point(239, 293);
            this.lblComentarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(159, 32);
            this.lblComentarios.TabIndex = 34;
            this.lblComentarios.Text = "Comentarios";
            // 
            // lblHoraPausa
            // 
            this.lblHoraPausa.AutoSize = true;
            this.lblHoraPausa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraPausa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHoraPausa.Location = new System.Drawing.Point(493, 206);
            this.lblHoraPausa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraPausa.Name = "lblHoraPausa";
            this.lblHoraPausa.Size = new System.Drawing.Size(211, 32);
            this.lblHoraPausa.TabIndex = 35;
            this.lblHoraPausa.Text = "Hora que pausou";
            // 
            // lblHoraRetorno
            // 
            this.lblHoraRetorno.AutoSize = true;
            this.lblHoraRetorno.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraRetorno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHoraRetorno.Location = new System.Drawing.Point(727, 206);
            this.lblHoraRetorno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraRetorno.Name = "lblHoraRetorno";
            this.lblHoraRetorno.Size = new System.Drawing.Size(229, 32);
            this.lblHoraRetorno.TabIndex = 36;
            this.lblHoraRetorno.Text = "Hora que retornou";
            // 
            // tbxHoraPausa
            // 
            this.tbxHoraPausa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHoraPausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHoraPausa.Location = new System.Drawing.Point(498, 242);
            this.tbxHoraPausa.Margin = new System.Windows.Forms.Padding(4);
            this.tbxHoraPausa.Name = "tbxHoraPausa";
            this.tbxHoraPausa.Size = new System.Drawing.Size(206, 34);
            this.tbxHoraPausa.TabIndex = 37;
            // 
            // tbxHoraRetorno
            // 
            this.tbxHoraRetorno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHoraRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHoraRetorno.Location = new System.Drawing.Point(732, 242);
            this.tbxHoraRetorno.Margin = new System.Windows.Forms.Padding(4);
            this.tbxHoraRetorno.Name = "tbxHoraRetorno";
            this.tbxHoraRetorno.Size = new System.Drawing.Size(206, 34);
            this.tbxHoraRetorno.TabIndex = 38;
            // 
            // lblDataAumento
            // 
            this.lblDataAumento.AutoSize = true;
            this.lblDataAumento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAumento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDataAumento.Location = new System.Drawing.Point(727, 293);
            this.lblDataAumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataAumento.Name = "lblDataAumento";
            this.lblDataAumento.Size = new System.Drawing.Size(211, 32);
            this.lblDataAumento.TabIndex = 39;
            this.lblDataAumento.Text = "Data de aumento";
            // 
            // rtbxComentarios
            // 
            this.rtbxComentarios.Location = new System.Drawing.Point(240, 328);
            this.rtbxComentarios.Name = "rtbxComentarios";
            this.rtbxComentarios.Size = new System.Drawing.Size(464, 231);
            this.rtbxComentarios.TabIndex = 40;
            this.rtbxComentarios.Text = "";
            // 
            // btnSalvarAvaliacao
            // 
            this.btnSalvarAvaliacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvarAvaliacao.FlatAppearance.BorderSize = 0;
            this.btnSalvarAvaliacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarAvaliacao.Location = new System.Drawing.Point(240, 578);
            this.btnSalvarAvaliacao.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarAvaliacao.Name = "btnSalvarAvaliacao";
            this.btnSalvarAvaliacao.Size = new System.Drawing.Size(143, 43);
            this.btnSalvarAvaliacao.TabIndex = 41;
            this.btnSalvarAvaliacao.Text = "Salvar avaliação";
            this.btnSalvarAvaliacao.UseVisualStyleBackColor = true;
            this.btnSalvarAvaliacao.Click += new System.EventHandler(this.btnSalvarAvaliacao_Click);
            // 
            // llbDoSalario
            // 
            this.llbDoSalario.AutoSize = true;
            this.llbDoSalario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbDoSalario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.llbDoSalario.Location = new System.Drawing.Point(770, 328);
            this.llbDoSalario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbDoSalario.Name = "llbDoSalario";
            this.llbDoSalario.Size = new System.Drawing.Size(127, 32);
            this.llbDoSalario.TabIndex = 42;
            this.llbDoSalario.Text = "do salário";
            // 
            // lblAcompanhamento
            // 
            this.lblAcompanhamento.AutoSize = true;
            this.lblAcompanhamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcompanhamento.Location = new System.Drawing.Point(14, 518);
            this.lblAcompanhamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAcompanhamento.Name = "lblAcompanhamento";
            this.lblAcompanhamento.Size = new System.Drawing.Size(157, 20);
            this.lblAcompanhamento.TabIndex = 237;
            this.lblAcompanhamento.Text = "Acompanhamento";
            // 
            // pbxIrAcompanhamento
            // 
            this.pbxIrAcompanhamento.Image = global::WindowsFormsControleFuncionários.Properties.Resources.back;
            this.pbxIrAcompanhamento.Location = new System.Drawing.Point(9, 549);
            this.pbxIrAcompanhamento.Margin = new System.Windows.Forms.Padding(4);
            this.pbxIrAcompanhamento.Name = "pbxIrAcompanhamento";
            this.pbxIrAcompanhamento.Size = new System.Drawing.Size(133, 62);
            this.pbxIrAcompanhamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxIrAcompanhamento.TabIndex = 235;
            this.pbxIrAcompanhamento.TabStop = false;
            this.pbxIrAcompanhamento.Click += new System.EventHandler(this.pbxIrAcompanhamento_Click);
            // 
            // lblRetornarPara
            // 
            this.lblRetornarPara.AutoSize = true;
            this.lblRetornarPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetornarPara.Location = new System.Drawing.Point(15, 496);
            this.lblRetornarPara.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRetornarPara.Name = "lblRetornarPara";
            this.lblRetornarPara.Size = new System.Drawing.Size(131, 20);
            this.lblRetornarPara.TabIndex = 236;
            this.lblRetornarPara.Text = "Retornar  para";
            // 
            // Avaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 634);
            this.Controls.Add(this.lblAcompanhamento);
            this.Controls.Add(this.pbxIrAcompanhamento);
            this.Controls.Add(this.lblRetornarPara);
            this.Controls.Add(this.llbDoSalario);
            this.Controls.Add(this.btnSalvarAvaliacao);
            this.Controls.Add(this.rtbxComentarios);
            this.Controls.Add(this.lblDataAumento);
            this.Controls.Add(this.tbxHoraRetorno);
            this.Controls.Add(this.tbxHoraPausa);
            this.Controls.Add(this.lblHoraRetorno);
            this.Controls.Add(this.lblHoraPausa);
            this.Controls.Add(this.lblComentarios);
            this.Controls.Add(this.lblHoraSaida);
            this.Controls.Add(this.lblHoraEntrada);
            this.Controls.Add(this.tbxDataAumento);
            this.Controls.Add(this.tbxHoraSaida);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbxHoraEntrada);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.btnMinimizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Avaliacao";
            this.Text = "Avaliacao";
            this.Load += new System.EventHandler(this.Avaliacao_Load_1);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIrAcompanhamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnMaxi;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblAvaliacao;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.TextBox tbxHoraEntrada;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.TextBox tbxHoraSaida;
        private System.Windows.Forms.TextBox tbxDataAumento;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.Label lblAvaliacaoId;
        private System.Windows.Forms.Label lblHoraSaida;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.Label lblHoraPausa;
        private System.Windows.Forms.Label lblHoraRetorno;
        private System.Windows.Forms.TextBox tbxHoraPausa;
        private System.Windows.Forms.TextBox tbxHoraRetorno;
        private System.Windows.Forms.Label lblDataAumento;
        private System.Windows.Forms.RichTextBox rtbxComentarios;
        private System.Windows.Forms.Button btnSalvarAvaliacao;
        private System.Windows.Forms.Label llbDoSalario;
        private System.Windows.Forms.Label lblAcompanhamento;
        private System.Windows.Forms.PictureBox pbxIrAcompanhamento;
        private System.Windows.Forms.Label lblRetornarPara;

    }
}