namespace WindowsFormsControleFuncionários
{
    partial class SenhaAlterada
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lnkReturn_Inicio = new System.Windows.Forms.LinkLabel();
            this.pbxConfirm_Green = new System.Windows.Forms.PictureBox();
            this.lblSenhaAlterada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConfirm_Green)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackgroundImage = global::WindowsFormsControleFuncionários.Properties.Resources.Gestão_PRO__3___1_;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.Location = new System.Drawing.Point(704, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(23, 23);
            this.btnMaximizar.TabIndex = 22;
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
            this.btnMinimizar.Location = new System.Drawing.Point(682, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(23, 23);
            this.btnMinimizar.TabIndex = 21;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(726, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::WindowsFormsControleFuncionários.Properties.Resources.back;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(40, 27);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // lnkReturn_Inicio
            // 
            this.lnkReturn_Inicio.AutoSize = true;
            this.lnkReturn_Inicio.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkReturn_Inicio.Location = new System.Drawing.Point(260, 360);
            this.lnkReturn_Inicio.Name = "lnkReturn_Inicio";
            this.lnkReturn_Inicio.Size = new System.Drawing.Size(224, 30);
            this.lnkReturn_Inicio.TabIndex = 18;
            this.lnkReturn_Inicio.TabStop = true;
            this.lnkReturn_Inicio.Text = "RETORNAR AO INÍCIO";
            // 
            // pbxConfirm_Green
            // 
            this.pbxConfirm_Green.Image = global::WindowsFormsControleFuncionários.Properties.Resources.verified;
            this.pbxConfirm_Green.Location = new System.Drawing.Point(322, 232);
            this.pbxConfirm_Green.Name = "pbxConfirm_Green";
            this.pbxConfirm_Green.Size = new System.Drawing.Size(100, 100);
            this.pbxConfirm_Green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxConfirm_Green.TabIndex = 17;
            this.pbxConfirm_Green.TabStop = false;
            // 
            // lblSenhaAlterada
            // 
            this.lblSenhaAlterada.AutoSize = true;
            this.lblSenhaAlterada.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaAlterada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSenhaAlterada.Location = new System.Drawing.Point(142, 160);
            this.lblSenhaAlterada.Name = "lblSenhaAlterada";
            this.lblSenhaAlterada.Size = new System.Drawing.Size(456, 45);
            this.lblSenhaAlterada.TabIndex = 16;
            this.lblSenhaAlterada.Text = "Senha Alterada com Sucesso!";
            // 
            // SenhaAlterada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lnkReturn_Inicio);
            this.Controls.Add(this.pbxConfirm_Green);
            this.Controls.Add(this.lblSenhaAlterada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SenhaAlterada";
            this.Text = "SenhaAlterada";
            ((System.ComponentModel.ISupportInitialize)(this.pbxConfirm_Green)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.LinkLabel lnkReturn_Inicio;
        private System.Windows.Forms.PictureBox pbxConfirm_Green;
        private System.Windows.Forms.Label lblSenhaAlterada;
    }
}