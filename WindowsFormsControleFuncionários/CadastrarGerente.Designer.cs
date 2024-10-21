namespace WindowsFormsControleFuncionários
{
    partial class CadastrarGerente
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
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLogin3 = new System.Windows.Forms.Label();
            this.lblLogin2 = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lblLogin1 = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnCriar = new System.Windows.Forms.Button();
            this.tbxConfirmar = new System.Windows.Forms.TextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.lclCPF = new System.Windows.Forms.Label();
            this.btnOlhoConfirmar = new System.Windows.Forms.Button();
            this.btnOlhoSenha = new System.Windows.Forms.Button();
            this.mtbxCPF = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackgroundImage = global::WindowsFormsControleFuncionários.Properties.Resources.Gestão_PRO__3___1_;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.Location = new System.Drawing.Point(935, 4);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(31, 28);
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
            this.btnMinimizar.Location = new System.Drawing.Point(905, 4);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(31, 28);
            this.btnMinimizar.TabIndex = 5;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(964, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 28);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLogin3
            // 
            this.lblLogin3.AutoSize = true;
            this.lblLogin3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLogin3.Location = new System.Drawing.Point(276, 127);
            this.lblLogin3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin3.Name = "lblLogin3";
            this.lblLogin3.Size = new System.Drawing.Size(214, 41);
            this.lblLogin3.TabIndex = 3;
            this.lblLogin3.Text = "Carga Horária";
            // 
            // lblLogin2
            // 
            this.lblLogin2.AutoSize = true;
            this.lblLogin2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLogin2.Location = new System.Drawing.Point(275, 78);
            this.lblLogin2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin2.Name = "lblLogin2";
            this.lblLogin2.Size = new System.Drawing.Size(350, 41);
            this.lblLogin2.TabIndex = 2;
            this.lblLogin2.Text = "Sistema Gerenciador de";
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::WindowsFormsControleFuncionários.Properties.Resources.Gestão_PRO;
            this.pbxLogo.Location = new System.Drawing.Point(45, 28);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(161, 144);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // lblLogin1
            // 
            this.lblLogin1.AutoSize = true;
            this.lblLogin1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLogin1.Location = new System.Drawing.Point(276, 28);
            this.lblLogin1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin1.Name = "lblLogin1";
            this.lblLogin1.Size = new System.Drawing.Size(214, 41);
            this.lblLogin1.TabIndex = 1;
            this.lblLogin1.Text = "Bem Vindo ao";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.pnlLeft.Controls.Add(this.btnMaximizar);
            this.pnlLeft.Controls.Add(this.btnMinimizar);
            this.pnlLeft.Controls.Add(this.btnClose);
            this.pnlLeft.Controls.Add(this.lblLogin3);
            this.pnlLeft.Controls.Add(this.lblLogin2);
            this.pnlLeft.Controls.Add(this.lblLogin1);
            this.pnlLeft.Controls.Add(this.pbxLogo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(1000, 197);
            this.pnlLeft.TabIndex = 5;
            this.pnlLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLeft_Paint);
            // 
            // btnCriar
            // 
            this.btnCriar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCriar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.Location = new System.Drawing.Point(356, 554);
            this.btnCriar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(297, 49);
            this.btnCriar.TabIndex = 20;
            this.btnCriar.Text = "Criar acesso";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // tbxConfirmar
            // 
            this.tbxConfirmar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxConfirmar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConfirmar.Location = new System.Drawing.Point(520, 350);
            this.tbxConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.tbxConfirmar.Name = "tbxConfirmar";
            this.tbxConfirmar.Size = new System.Drawing.Size(313, 39);
            this.tbxConfirmar.TabIndex = 19;
            this.tbxConfirmar.UseSystemPasswordChar = true;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmar.Location = new System.Drawing.Point(513, 310);
            this.lblConfirmar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(228, 37);
            this.lblConfirmar.TabIndex = 18;
            this.lblConfirmar.Text = "Confirmar senha";
            // 
            // tbxSenha
            // 
            this.tbxSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSenha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSenha.Location = new System.Drawing.Point(520, 241);
            this.tbxSenha.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Size = new System.Drawing.Size(313, 39);
            this.tbxSenha.TabIndex = 17;
            this.tbxSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(513, 201);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(94, 37);
            this.lblSenha.TabIndex = 16;
            this.lblSenha.Text = "Senha";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(61, 345);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(313, 39);
            this.tbxEmail.TabIndex = 15;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(55, 304);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(87, 37);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(55, 212);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(225, 37);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome completo";
            // 
            // tbxNome
            // 
            this.tbxNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxNome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNome.Location = new System.Drawing.Point(61, 252);
            this.tbxNome.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(313, 39);
            this.tbxNome.TabIndex = 12;
            // 
            // lclCPF
            // 
            this.lclCPF.AutoSize = true;
            this.lclCPF.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lclCPF.Location = new System.Drawing.Point(64, 414);
            this.lclCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lclCPF.Name = "lclCPF";
            this.lclCPF.Size = new System.Drawing.Size(65, 37);
            this.lclCPF.TabIndex = 23;
            this.lclCPF.Text = "CPF";
            // 
            // btnOlhoConfirmar
            // 
            this.btnOlhoConfirmar.BackgroundImage = global::WindowsFormsControleFuncionários.Properties.Resources.eye__1_;
            this.btnOlhoConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOlhoConfirmar.FlatAppearance.BorderSize = 0;
            this.btnOlhoConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOlhoConfirmar.Location = new System.Drawing.Point(837, 352);
            this.btnOlhoConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnOlhoConfirmar.Name = "btnOlhoConfirmar";
            this.btnOlhoConfirmar.Size = new System.Drawing.Size(41, 38);
            this.btnOlhoConfirmar.TabIndex = 25;
            this.btnOlhoConfirmar.UseVisualStyleBackColor = true;
            this.btnOlhoConfirmar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnOlhoConfirmar_MouseDown);
            this.btnOlhoConfirmar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnOlhoConfirmar_MouseUp);
            // 
            // btnOlhoSenha
            // 
            this.btnOlhoSenha.BackgroundImage = global::WindowsFormsControleFuncionários.Properties.Resources.eye__1_;
            this.btnOlhoSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOlhoSenha.FlatAppearance.BorderSize = 0;
            this.btnOlhoSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOlhoSenha.Location = new System.Drawing.Point(837, 242);
            this.btnOlhoSenha.Margin = new System.Windows.Forms.Padding(4);
            this.btnOlhoSenha.Name = "btnOlhoSenha";
            this.btnOlhoSenha.Size = new System.Drawing.Size(41, 38);
            this.btnOlhoSenha.TabIndex = 26;
            this.btnOlhoSenha.UseVisualStyleBackColor = true;
            this.btnOlhoSenha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnOlhoSenha_MouseDown);
            this.btnOlhoSenha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnOlhoSenha_MouseUp);
            // 
            // mtbxCPF
            // 
            this.mtbxCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbxCPF.Location = new System.Drawing.Point(61, 457);
            this.mtbxCPF.Mask = "000.000.000-00";
            this.mtbxCPF.Name = "mtbxCPF";
            this.mtbxCPF.Size = new System.Drawing.Size(313, 34);
            this.mtbxCPF.TabIndex = 27;
            // 
            // CadastrarGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 677);
            this.Controls.Add(this.mtbxCPF);
            this.Controls.Add(this.btnOlhoSenha);
            this.Controls.Add(this.btnOlhoConfirmar);
            this.Controls.Add(this.lclCPF);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.tbxConfirmar);
            this.Controls.Add(this.lblConfirmar);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastrarGerente";
            this.Text = "CadastrarGerente";
            this.Load += new System.EventHandler(this.CadastrarGerente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLogin3;
        private System.Windows.Forms.Label lblLogin2;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblLogin1;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.TextBox tbxConfirmar;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label lclCPF;
        private System.Windows.Forms.Button btnOlhoConfirmar;
        private System.Windows.Forms.Button btnOlhoSenha;
        private System.Windows.Forms.MaskedTextBox mtbxCPF;
    }
}