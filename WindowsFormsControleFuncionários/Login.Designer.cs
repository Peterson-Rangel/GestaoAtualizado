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
            this.btn_Cadastrar_User = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLogin3 = new System.Windows.Forms.Label();
            this.lblLogin2 = new System.Windows.Forms.Label();
            this.lblLogin1 = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lnklblEsqueci = new System.Windows.Forms.LinkLabel();
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
            this.pnlAcesso_Login.Location = new System.Drawing.Point(299, 336);
            this.pnlAcesso_Login.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAcesso_Login.Name = "pnlAcesso_Login";
            this.pnlAcesso_Login.Size = new System.Drawing.Size(416, 209);
            this.pnlAcesso_Login.TabIndex = 1;
            // 
            // pbx_Olho_Login
            // 
            this.pbx_Olho_Login.Image = global::WindowsFormsControleFuncionários.Properties.Resources.eye__1_;
            this.pbx_Olho_Login.Location = new System.Drawing.Point(333, 145);
            this.pbx_Olho_Login.Margin = new System.Windows.Forms.Padding(4);
            this.pbx_Olho_Login.Name = "pbx_Olho_Login";
            this.pbx_Olho_Login.Size = new System.Drawing.Size(56, 32);
            this.pbx_Olho_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Olho_Login.TabIndex = 6;
            this.pbx_Olho_Login.TabStop = false;
            this.pbx_Olho_Login.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbx_Olho_Login_MouseDown);
            this.pbx_Olho_Login.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbx_Olho_Login_MouseUp);
            // 
            // lblSenha_Login
            // 
            this.lblSenha_Login.AutoSize = true;
            this.lblSenha_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha_Login.Location = new System.Drawing.Point(107, 118);
            this.lblSenha_Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha_Login.Name = "lblSenha_Login";
            this.lblSenha_Login.Size = new System.Drawing.Size(61, 20);
            this.lblSenha_Login.TabIndex = 5;
            this.lblSenha_Login.Text = "Senha";
            // 
            // lblUsuario_Login
            // 
            this.lblUsuario_Login.AutoSize = true;
            this.lblUsuario_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario_Login.Location = new System.Drawing.Point(105, 16);
            this.lblUsuario_Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario_Login.Name = "lblUsuario_Login";
            this.lblUsuario_Login.Size = new System.Drawing.Size(63, 20);
            this.lblUsuario_Login.TabIndex = 4;
            this.lblUsuario_Login.Text = "E-mail";
            // 
            // pbxCadeado_Login
            // 
            this.pbxCadeado_Login.Image = global::WindowsFormsControleFuncionários.Properties.Resources.trancar;
            this.pbxCadeado_Login.Location = new System.Drawing.Point(28, 122);
            this.pbxCadeado_Login.Margin = new System.Windows.Forms.Padding(4);
            this.pbxCadeado_Login.Name = "pbxCadeado_Login";
            this.pbxCadeado_Login.Size = new System.Drawing.Size(67, 62);
            this.pbxCadeado_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCadeado_Login.TabIndex = 3;
            this.pbxCadeado_Login.TabStop = false;
            // 
            // tbx_Senha_Login
            // 
            this.tbx_Senha_Login.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Senha_Login.Location = new System.Drawing.Point(103, 140);
            this.tbx_Senha_Login.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_Senha_Login.Name = "tbx_Senha_Login";
            this.tbx_Senha_Login.Size = new System.Drawing.Size(289, 39);
            this.tbx_Senha_Login.TabIndex = 2;
            this.tbx_Senha_Login.UseSystemPasswordChar = true;
            // 
            // pbxUsuario_Login
            // 
            this.pbxUsuario_Login.Image = global::WindowsFormsControleFuncionários.Properties.Resources.do_utilizador;
            this.pbxUsuario_Login.Location = new System.Drawing.Point(27, 21);
            this.pbxUsuario_Login.Margin = new System.Windows.Forms.Padding(4);
            this.pbxUsuario_Login.Name = "pbxUsuario_Login";
            this.pbxUsuario_Login.Size = new System.Drawing.Size(67, 62);
            this.pbxUsuario_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUsuario_Login.TabIndex = 1;
            this.pbxUsuario_Login.TabStop = false;
            // 
            // tbxUsuario_Login
            // 
            this.tbxUsuario_Login.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsuario_Login.Location = new System.Drawing.Point(101, 39);
            this.tbxUsuario_Login.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUsuario_Login.Name = "tbxUsuario_Login";
            this.tbxUsuario_Login.Size = new System.Drawing.Size(289, 39);
            this.tbxUsuario_Login.TabIndex = 0;
            // 
            // btnAcessar
            // 
            this.btnAcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessar.Location = new System.Drawing.Point(299, 558);
            this.btnAcessar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(100, 28);
            this.btnAcessar.TabIndex = 2;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = true;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // btn_Cadastrar_User
            // 
            this.btn_Cadastrar_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar_User.Location = new System.Drawing.Point(435, 558);
            this.btn_Cadastrar_User.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cadastrar_User.Name = "btn_Cadastrar_User";
            this.btn_Cadastrar_User.Size = new System.Drawing.Size(121, 28);
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
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(1000, 239);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackgroundImage = global::WindowsFormsControleFuncionários.Properties.Resources.Gestão_PRO__3___1_;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.Location = new System.Drawing.Point(936, 4);
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
            this.btnMinimizar.Location = new System.Drawing.Point(907, 4);
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
            this.btnClose.Location = new System.Drawing.Point(965, 4);
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
            this.lblLogin3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLogin3.Location = new System.Drawing.Point(525, 131);
            this.lblLogin3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin3.Name = "lblLogin3";
            this.lblLogin3.Size = new System.Drawing.Size(143, 28);
            this.lblLogin3.TabIndex = 3;
            this.lblLogin3.Text = "Carga Horária";
            // 
            // lblLogin2
            // 
            this.lblLogin2.AutoSize = true;
            this.lblLogin2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLogin2.Location = new System.Drawing.Point(286, 131);
            this.lblLogin2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin2.Name = "lblLogin2";
            this.lblLogin2.Size = new System.Drawing.Size(236, 28);
            this.lblLogin2.TabIndex = 2;
            this.lblLogin2.Text = "Sistema Gerenciador de";
            this.lblLogin2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogin1
            // 
            this.lblLogin1.AutoSize = true;
            this.lblLogin1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLogin1.Location = new System.Drawing.Point(284, 55);
            this.lblLogin1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin1.Name = "lblLogin1";
            this.lblLogin1.Size = new System.Drawing.Size(520, 54);
            this.lblLogin1.TabIndex = 1;
            this.lblLogin1.Text = "Bem Vindo ao Gestão PRO";
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::WindowsFormsControleFuncionários.Properties.Resources.Gestão_PRO;
            this.pbxLogo.Location = new System.Drawing.Point(44, 28);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(200, 185);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // lnklblEsqueci
            // 
            this.lnklblEsqueci.AutoSize = true;
            this.lnklblEsqueci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblEsqueci.Location = new System.Drawing.Point(582, 562);
            this.lnklblEsqueci.Name = "lnklblEsqueci";
            this.lnklblEsqueci.Size = new System.Drawing.Size(134, 20);
            this.lnklblEsqueci.TabIndex = 5;
            this.lnklblEsqueci.TabStop = true;
            this.lnklblEsqueci.Text = "Esqueci o e-mail";
            this.lnklblEsqueci.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblEsqueci_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1000, 677);
            this.Controls.Add(this.lnklblEsqueci);
            this.Controls.Add(this.btn_Cadastrar_User);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.pnlAcesso_Login);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(2560, 1329);
            this.MinimumSize = new System.Drawing.Size(1000, 677);
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
        private System.Windows.Forms.Button btn_Cadastrar_User;
        private System.Windows.Forms.PictureBox pbx_Olho_Login;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.LinkLabel lnklblEsqueci;
    }
}

