namespace WindowsFormsControleFuncionários
{
    partial class InserirNovaSenha
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNova_Senha = new System.Windows.Forms.Label();
            this.tbxNovaSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxConfirmaNovaSenha = new System.Windows.Forms.TextBox();
            this.pnl_InserirSenha = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pbx_Olho_Senha1 = new System.Windows.Forms.PictureBox();
            this.pbx_Olho_Senha2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastrarNova = new System.Windows.Forms.Button();
            this.lblRetornoLogin = new System.Windows.Forms.Label();
            this.lblRetornarPara = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnl_InserirSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Olho_Senha1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Olho_Senha2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(969, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 28);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblNova_Senha
            // 
            this.lblNova_Senha.AutoSize = true;
            this.lblNova_Senha.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNova_Senha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNova_Senha.Location = new System.Drawing.Point(295, 86);
            this.lblNova_Senha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNova_Senha.Name = "lblNova_Senha";
            this.lblNova_Senha.Size = new System.Drawing.Size(428, 54);
            this.lblNova_Senha.TabIndex = 20;
            this.lblNova_Senha.Text = "Cadastrar nova senha";
            // 
            // tbxNovaSenha
            // 
            this.tbxNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNovaSenha.Location = new System.Drawing.Point(36, 151);
            this.tbxNovaSenha.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNovaSenha.Name = "tbxNovaSenha";
            this.tbxNovaSenha.Size = new System.Drawing.Size(357, 30);
            this.tbxNovaSenha.TabIndex = 21;
            this.tbxNovaSenha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(39, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Digite sua nova senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(39, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Digite novamente sua nova senha";
            // 
            // tbxConfirmaNovaSenha
            // 
            this.tbxConfirmaNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConfirmaNovaSenha.Location = new System.Drawing.Point(36, 248);
            this.tbxConfirmaNovaSenha.Margin = new System.Windows.Forms.Padding(4);
            this.tbxConfirmaNovaSenha.Name = "tbxConfirmaNovaSenha";
            this.tbxConfirmaNovaSenha.Size = new System.Drawing.Size(357, 30);
            this.tbxConfirmaNovaSenha.TabIndex = 23;
            this.tbxConfirmaNovaSenha.UseSystemPasswordChar = true;
            // 
            // pnl_InserirSenha
            // 
            this.pnl_InserirSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.pnl_InserirSenha.Controls.Add(this.pbxLogo);
            this.pnl_InserirSenha.Controls.Add(this.btnMaximizar);
            this.pnl_InserirSenha.Controls.Add(this.lblNova_Senha);
            this.pnl_InserirSenha.Controls.Add(this.btnClose);
            this.pnl_InserirSenha.Controls.Add(this.btnMinimizar);
            this.pnl_InserirSenha.Location = new System.Drawing.Point(-3, -1);
            this.pnl_InserirSenha.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_InserirSenha.Name = "pnl_InserirSenha";
            this.pnl_InserirSenha.Size = new System.Drawing.Size(1016, 167);
            this.pnl_InserirSenha.TabIndex = 27;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::WindowsFormsControleFuncionários.Properties.Resources.Gestão_PRO;
            this.pbxLogo.Location = new System.Drawing.Point(16, 14);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(161, 144);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 20;
            this.pbxLogo.TabStop = false;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackgroundImage = global::WindowsFormsControleFuncionários.Properties.Resources.Gestão_PRO__3___1_;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.Location = new System.Drawing.Point(940, 4);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(31, 28);
            this.btnMaximizar.TabIndex = 18;
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
            this.btnMinimizar.Location = new System.Drawing.Point(911, 4);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(31, 28);
            this.btnMinimizar.TabIndex = 17;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::WindowsFormsControleFuncionários.Properties.Resources.back;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVoltar.Location = new System.Drawing.Point(30, 492);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 68);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pbx_Olho_Senha1
            // 
            this.pbx_Olho_Senha1.Image = global::WindowsFormsControleFuncionários.Properties.Resources.eye__1_;
            this.pbx_Olho_Senha1.Location = new System.Drawing.Point(393, 151);
            this.pbx_Olho_Senha1.Margin = new System.Windows.Forms.Padding(4);
            this.pbx_Olho_Senha1.Name = "pbx_Olho_Senha1";
            this.pbx_Olho_Senha1.Size = new System.Drawing.Size(56, 32);
            this.pbx_Olho_Senha1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Olho_Senha1.TabIndex = 26;
            this.pbx_Olho_Senha1.TabStop = false;
            this.pbx_Olho_Senha1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbx_Olho_Senha1_MouseDown);
            this.pbx_Olho_Senha1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbx_Olho_Senha1_MouseUp);
            // 
            // pbx_Olho_Senha2
            // 
            this.pbx_Olho_Senha2.Image = global::WindowsFormsControleFuncionários.Properties.Resources.eye__1_;
            this.pbx_Olho_Senha2.Location = new System.Drawing.Point(393, 248);
            this.pbx_Olho_Senha2.Margin = new System.Windows.Forms.Padding(4);
            this.pbx_Olho_Senha2.Name = "pbx_Olho_Senha2";
            this.pbx_Olho_Senha2.Size = new System.Drawing.Size(56, 32);
            this.pbx_Olho_Senha2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Olho_Senha2.TabIndex = 25;
            this.pbx_Olho_Senha2.TabStop = false;
            this.pbx_Olho_Senha2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbx_Olho_Senha2_MouseDown);
            this.pbx_Olho_Senha2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbx_Olho_Senha2_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.tbxNovaSenha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbx_Olho_Senha1);
            this.panel1.Controls.Add(this.tbxConfirmaNovaSenha);
            this.panel1.Controls.Add(this.pbx_Olho_Senha2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(274, 174);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 304);
            this.panel1.TabIndex = 28;
            // 
            // btnCadastrarNova
            // 
            this.btnCadastrarNova.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarNova.Location = new System.Drawing.Point(649, 506);
            this.btnCadastrarNova.Name = "btnCadastrarNova";
            this.btnCadastrarNova.Size = new System.Drawing.Size(116, 54);
            this.btnCadastrarNova.TabIndex = 29;
            this.btnCadastrarNova.Text = "Cadastrar nova senha";
            this.btnCadastrarNova.UseVisualStyleBackColor = true;
            this.btnCadastrarNova.Click += new System.EventHandler(this.btnCadastrarNova_Click);
            // 
            // lblRetornoLogin
            // 
            this.lblRetornoLogin.AutoSize = true;
            this.lblRetornoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetornoLogin.Location = new System.Drawing.Point(157, 528);
            this.lblRetornoLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRetornoLogin.Name = "lblRetornoLogin";
            this.lblRetornoLogin.Size = new System.Drawing.Size(98, 20);
            this.lblRetornoLogin.TabIndex = 236;
            this.lblRetornoLogin.Text = "para Login";
            // 
            // lblRetornarPara
            // 
            this.lblRetornarPara.AutoSize = true;
            this.lblRetornarPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetornarPara.Location = new System.Drawing.Point(164, 506);
            this.lblRetornarPara.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRetornarPara.Name = "lblRetornarPara";
            this.lblRetornarPara.Size = new System.Drawing.Size(82, 20);
            this.lblRetornarPara.TabIndex = 235;
            this.lblRetornarPara.Text = "Retornar";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(36, 50);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(357, 30);
            this.textBox1.TabIndex = 237;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // InserirNovaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 677);
            this.Controls.Add(this.lblRetornoLogin);
            this.Controls.Add(this.lblRetornarPara);
            this.Controls.Add(this.btnCadastrarNova);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_InserirSenha);
            this.Controls.Add(this.btnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InserirNovaSenha";
            this.Text = "InsirirNovaSenha";
            this.pnl_InserirSenha.ResumeLayout(false);
            this.pnl_InserirSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Olho_Senha1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Olho_Senha2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblNova_Senha;
        private System.Windows.Forms.TextBox tbxNovaSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxConfirmaNovaSenha;
        private System.Windows.Forms.PictureBox pbx_Olho_Senha2;
        private System.Windows.Forms.PictureBox pbx_Olho_Senha1;
        private System.Windows.Forms.Panel pnl_InserirSenha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnCadastrarNova;
        private System.Windows.Forms.Label lblRetornoLogin;
        private System.Windows.Forms.Label lblRetornarPara;
        private System.Windows.Forms.TextBox textBox1;
    }
}