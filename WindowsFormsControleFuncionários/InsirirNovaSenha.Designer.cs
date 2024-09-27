namespace WindowsFormsControleFuncionários
{
    partial class InsirirNovaSenha
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
            this.lblInsira_Senha = new System.Windows.Forms.Label();
            this.tbx_confrm_Senha1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_confirmSenha2 = new System.Windows.Forms.TextBox();
            this.pnl_InserirSenha = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pbx_Olho_Senha1 = new System.Windows.Forms.PictureBox();
            this.pbx_Olho_Senha2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_InserirSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Olho_Senha1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Olho_Senha2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(727, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblInsira_Senha
            // 
            this.lblInsira_Senha.AutoSize = true;
            this.lblInsira_Senha.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsira_Senha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInsira_Senha.Location = new System.Drawing.Point(108, 208);
            this.lblInsira_Senha.Name = "lblInsira_Senha";
            this.lblInsira_Senha.Size = new System.Drawing.Size(348, 45);
            this.lblInsira_Senha.TabIndex = 20;
            this.lblInsira_Senha.Text = "Insira sua nova senha!";
            // 
            // tbx_confrm_Senha1
            // 
            this.tbx_confrm_Senha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_confrm_Senha1.Location = new System.Drawing.Point(27, 43);
            this.tbx_confrm_Senha1.Name = "tbx_confrm_Senha1";
            this.tbx_confrm_Senha1.Size = new System.Drawing.Size(269, 26);
            this.tbx_confrm_Senha1.TabIndex = 21;
            this.tbx_confrm_Senha1.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Digite sua senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(29, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Digite novamente sua senha";
            // 
            // tbx_confirmSenha2
            // 
            this.tbx_confirmSenha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_confirmSenha2.Location = new System.Drawing.Point(27, 141);
            this.tbx_confirmSenha2.Name = "tbx_confirmSenha2";
            this.tbx_confirmSenha2.Size = new System.Drawing.Size(269, 26);
            this.tbx_confirmSenha2.TabIndex = 23;
            this.tbx_confirmSenha2.UseSystemPasswordChar = true;
            // 
            // pnl_InserirSenha
            // 
            this.pnl_InserirSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.pnl_InserirSenha.Controls.Add(this.btnMaximizar);
            this.pnl_InserirSenha.Controls.Add(this.btnClose);
            this.pnl_InserirSenha.Controls.Add(this.btnMinimizar);
            this.pnl_InserirSenha.Controls.Add(this.btnVoltar);
            this.pnl_InserirSenha.Location = new System.Drawing.Point(-2, -1);
            this.pnl_InserirSenha.Name = "pnl_InserirSenha";
            this.pnl_InserirSenha.Size = new System.Drawing.Size(753, 175);
            this.pnl_InserirSenha.TabIndex = 27;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackgroundImage = global::WindowsFormsControleFuncionários.Properties.Resources.Gestão_PRO__3___1_;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.Location = new System.Drawing.Point(705, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(23, 23);
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
            this.btnMinimizar.Location = new System.Drawing.Point(683, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(23, 23);
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
            this.btnVoltar.Location = new System.Drawing.Point(9, 8);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(40, 27);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // pbx_Olho_Senha1
            // 
            this.pbx_Olho_Senha1.Image = global::WindowsFormsControleFuncionários.Properties.Resources.eye__1_;
            this.pbx_Olho_Senha1.Location = new System.Drawing.Point(295, 43);
            this.pbx_Olho_Senha1.Name = "pbx_Olho_Senha1";
            this.pbx_Olho_Senha1.Size = new System.Drawing.Size(42, 26);
            this.pbx_Olho_Senha1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Olho_Senha1.TabIndex = 26;
            this.pbx_Olho_Senha1.TabStop = false;
            this.pbx_Olho_Senha1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbx_Olho_Senha1_MouseDown);
            this.pbx_Olho_Senha1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbx_Olho_Senha1_MouseUp);
            // 
            // pbx_Olho_Senha2
            // 
            this.pbx_Olho_Senha2.Image = global::WindowsFormsControleFuncionários.Properties.Resources.eye__1_;
            this.pbx_Olho_Senha2.Location = new System.Drawing.Point(295, 141);
            this.pbx_Olho_Senha2.Name = "pbx_Olho_Senha2";
            this.pbx_Olho_Senha2.Size = new System.Drawing.Size(42, 26);
            this.pbx_Olho_Senha2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Olho_Senha2.TabIndex = 25;
            this.pbx_Olho_Senha2.TabStop = false;
            this.pbx_Olho_Senha2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbx_Olho_Senha2_MouseDown);
            this.pbx_Olho_Senha2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbx_Olho_Senha2_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.tbx_confrm_Senha1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbx_Olho_Senha1);
            this.panel1.Controls.Add(this.tbx_confirmSenha2);
            this.panel1.Controls.Add(this.pbx_Olho_Senha2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(105, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 191);
            this.panel1.TabIndex = 28;
            // 
            // InsirirNovaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_InserirSenha);
            this.Controls.Add(this.lblInsira_Senha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsirirNovaSenha";
            this.Text = "InsirirNovaSenha";
            this.pnl_InserirSenha.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblInsira_Senha;
        private System.Windows.Forms.TextBox tbx_confrm_Senha1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_confirmSenha2;
        private System.Windows.Forms.PictureBox pbx_Olho_Senha2;
        private System.Windows.Forms.PictureBox pbx_Olho_Senha1;
        private System.Windows.Forms.Panel pnl_InserirSenha;
        private System.Windows.Forms.Panel panel1;
    }
}