namespace WindowsFormsControleFuncionários
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlAcesso_Login = new System.Windows.Forms.Panel();
            this.pbx_Olho_Login = new System.Windows.Forms.PictureBox();
            this.lblSenha_Login = new System.Windows.Forms.Label();
            this.lblUsuario_Login = new System.Windows.Forms.Label();
            this.pbxCadeado_Login = new System.Windows.Forms.PictureBox();
            this.tbx_Senha_Login = new System.Windows.Forms.TextBox();
            this.pbxUsuario_Login = new System.Windows.Forms.PictureBox();
            this.tbxUsuario_Login = new System.Windows.Forms.TextBox();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.lnkEsqueceu_Senha = new System.Windows.Forms.LinkLabel();
            this.btn_Cadastrar_User = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLogin3 = new System.Windows.Forms.Label();
            this.lblLogin2 = new System.Windows.Forms.Label();
            this.lblLogin1 = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlAcesso_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Olho_Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadeado_Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuario_Login)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAcesso_Login
            // 
            this.pnlAcesso_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlAcesso_Login.Controls.Add(this.pbx_Olho_Login);
            this.pnlAcesso_Login.Controls.Add(this.lblSenha_Login);
            this.pnlAcesso_Login.Controls.Add(this.lblUsuario_Login);
            this.pnlAcesso_Login.Controls.Add(this.pbxCadeado_Login);
            this.pnlAcesso_Login.Controls.Add(this.tbx_Senha_Login);
            this.pnlAcesso_Login.Controls.Add(this.pbxUsuario_Login);
            this.pnlAcesso_Login.Controls.Add(this.tbxUsuario_Login);
            this.pnlAcesso_Login.Location = new System.Drawing.Point(224, 273);
            this.pnlAcesso_Login.Name = "pnlAcesso_Login";
            this.pnlAcesso_Login.Size = new System.Drawing.Size(312, 170);
            this.pnlAcesso_Login.TabIndex = 1;
            // 
            // pbx_Olho_Login
            // 
            this.pbx_Olho_Login.Image = global::WindowsFormsControleFuncionários.Properties.Resources.eye__1_;
            this.pbx_Olho_Login.Location = new System.Drawing.Point(250, 118);
            this.pbx_Olho_Login.Name = "pbx_Olho_Login";
            this.pbx_Olho_Login.Size = new System.Drawing.Size(42, 26);
            this.pbx_Olho_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Olho_Login.TabIndex = 6;
            this.pbx_Olho_Login.TabStop = false;
            this.pbx_Olho_Login.Click += new System.EventHandler(this.pbx_Olho_Login_Click);
            this.pbx_Olho_Login.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbx_Olho_Login_MouseDown);
            this.pbx_Olho_Login.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbx_Olho_Login_MouseUp);
            // 
            // lblSenha_Login
            // 
            this.lblSenha_Login.AutoSize = true;
            this.lblSenha_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha_Login.Location = new System.Drawing.Point(80, 96);
            this.lblSenha_Login.Name = "lblSenha_Login";
            this.lblSenha_Login.Size = new System.Drawing.Size(51, 16);
            this.lblSenha_Login.TabIndex = 5;
            this.lblSenha_Login.Text = "Senha";
            // 
            // lblUsuario_Login
            // 
            this.lblUsuario_Login.AutoSize = true;
            this.lblUsuario_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario_Login.Location = new System.Drawing.Point(79, 13);
            this.lblUsuario_Login.Name = "lblUsuario_Login";
            this.lblUsuario_Login.Size = new System.Drawing.Size(51, 16);
            this.lblUsuario_Login.TabIndex = 4;
            this.lblUsuario_Login.Text = "E-mail";
            // 
            // pbxCadeado_Login
            // 
            this.pbxCadeado_Login.Image = global::WindowsFormsControleFuncionários.Properties.Resources.trancar;
            this.pbxCadeado_Login.Location = new System.Drawing.Point(21, 99);
            this.pbxCadeado_Login.Name = "pbxCadeado_Login";
            this.pbxCadeado_Login.Size = new System.Drawing.Size(50, 50);
            this.pbxCadeado_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCadeado_Login.TabIndex = 3;
            this.pbxCadeado_Login.TabStop = false;
            // 
            // tbx_Senha_Login
            // 
            this.tbx_Senha_Login.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Senha_Login.Location = new System.Drawing.Point(77, 114);
            this.tbx_Senha_Login.Name = "tbx_Senha_Login";
            this.tbx_Senha_Login.Size = new System.Drawing.Size(218, 33);
            this.tbx_Senha_Login.TabIndex = 2;
            this.tbx_Senha_Login.UseSystemPasswordChar = true;
            // 
            // pbxUsuario_Login
            // 
            this.pbxUsuario_Login.Image = global::WindowsFormsControleFuncionários.Properties.Resources.do_utilizador;
            this.pbxUsuario_Login.Location = new System.Drawing.Point(20, 17);
            this.pbxUsuario_Login.Name = "pbxUsuario_Login";
            this.pbxUsuario_Login.Size = new System.Drawing.Size(50, 50);
            this.pbxUsuario_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUsuario_Login.TabIndex = 1;
            this.pbxUsuario_Login.TabStop = false;
            // 
            // tbxUsuario_Login
            // 
            this.tbxUsuario_Login.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsuario_Login.Location = new System.Drawing.Point(76, 32);
            this.tbxUsuario_Login.Name = "tbxUsuario_Login";
            this.tbxUsuario_Login.Size = new System.Drawing.Size(218, 33);
            this.tbxUsuario_Login.TabIndex = 0;
            this.tbxUsuario_Login.TextChanged += new System.EventHandler(this.tbxUsuario_Login_TextChanged);
            // 
            // btnAcessar
            // 
            this.btnAcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessar.Location = new System.Drawing.Point(461, 453);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(75, 23);
            this.btnAcessar.TabIndex = 2;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = true;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // lnkEsqueceu_Senha
            // 
            this.lnkEsqueceu_Senha.AutoSize = true;
            this.lnkEsqueceu_Senha.Location = new System.Drawing.Point(221, 458);
            this.lnkEsqueceu_Senha.Name = "lnkEsqueceu_Senha";
            this.lnkEsqueceu_Senha.Size = new System.Drawing.Size(104, 13);
            this.lnkEsqueceu_Senha.TabIndex = 3;
            this.lnkEsqueceu_Senha.TabStop = true;
            this.lnkEsqueceu_Senha.Text = "Esqueceu a Senha?";
            // 
            // btn_Cadastrar_User
            // 
            this.btn_Cadastrar_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar_User.Location = new System.Drawing.Point(361, 453);
            this.btn_Cadastrar_User.Name = "btn_Cadastrar_User";
            this.btn_Cadastrar_User.Size = new System.Drawing.Size(91, 23);
            this.btn_Cadastrar_User.TabIndex = 4;
            this.btn_Cadastrar_User.Text = "Cadastrar";
            this.btn_Cadastrar_User.UseVisualStyleBackColor = true;
            this.btn_Cadastrar_User.Click += new System.EventHandler(this.btn_Cadastrar_User_Click);
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
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(750, 194);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackgroundImage = global::WindowsFormsControleFuncionários.Properties.Resources.Gestão_PRO__3___1_;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.Location = new System.Drawing.Point(702, 3);
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
            this.btnMinimizar.Location = new System.Drawing.Point(680, 3);
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
            this.btnClose.Location = new System.Drawing.Point(724, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
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
            this.lblLogin3.Location = new System.Drawing.Point(213, 125);
            this.lblLogin3.Name = "lblLogin3";
            this.lblLogin3.Size = new System.Drawing.Size(173, 32);
            this.lblLogin3.TabIndex = 3;
            this.lblLogin3.Text = "Carga Horária";
            // 
            // lblLogin2
            // 
            this.lblLogin2.AutoSize = true;
            this.lblLogin2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLogin2.Location = new System.Drawing.Point(212, 85);
            this.lblLogin2.Name = "lblLogin2";
            this.lblLogin2.Size = new System.Drawing.Size(284, 32);
            this.lblLogin2.TabIndex = 2;
            this.lblLogin2.Text = "Sistema Gerenciador de";
            // 
            // lblLogin1
            // 
            this.lblLogin1.AutoSize = true;
            this.lblLogin1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLogin1.Location = new System.Drawing.Point(213, 45);
            this.lblLogin1.Name = "lblLogin1";
            this.lblLogin1.Size = new System.Drawing.Size(174, 32);
            this.lblLogin1.TabIndex = 1;
            this.lblLogin1.Text = "Bem Vindo ao";
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::WindowsFormsControleFuncionários.Properties.Resources.Gestão_PRO;
            this.pbxLogo.Location = new System.Drawing.Point(33, 23);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(150, 150);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.btn_Cadastrar_User);
            this.Controls.Add(this.lnkEsqueceu_Senha);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.pnlAcesso_Login);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlAcesso_Login.ResumeLayout(false);
            this.pnlAcesso_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Olho_Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadeado_Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuario_Login)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblLogin2;
        private System.Windows.Forms.Label lblLogin1;
        private System.Windows.Forms.Label lblLogin3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlAcesso_Login;
        private System.Windows.Forms.PictureBox pbxUsuario_Login;
        private System.Windows.Forms.TextBox tbxUsuario_Login;
        private System.Windows.Forms.PictureBox pbxCadeado_Login;
        private System.Windows.Forms.TextBox tbx_Senha_Login;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.Label lblSenha_Login;
        private System.Windows.Forms.Label lblUsuario_Login;
        private System.Windows.Forms.LinkLabel lnkEsqueceu_Senha;
        private System.Windows.Forms.Button btn_Cadastrar_User;
        private System.Windows.Forms.PictureBox pbx_Olho_Login;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
    }
}

