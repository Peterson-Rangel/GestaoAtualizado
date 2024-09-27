namespace WindowsFormsControleFuncionários
{
    partial class CadastroConfirmado
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
            this.lblCadas_Criado = new System.Windows.Forms.Label();
            this.lnkReturn_Inicio = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pbxConfirm_Green = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConfirm_Green)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadas_Criado
            // 
            this.lblCadas_Criado.AutoSize = true;
            this.lblCadas_Criado.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadas_Criado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCadas_Criado.Location = new System.Drawing.Point(141, 131);
            this.lblCadas_Criado.Name = "lblCadas_Criado";
            this.lblCadas_Criado.Size = new System.Drawing.Size(470, 45);
            this.lblCadas_Criado.TabIndex = 9;
            this.lblCadas_Criado.Text = "Cadastro Criado com Sucesso!";
            // 
            // lnkReturn_Inicio
            // 
            this.lnkReturn_Inicio.AutoSize = true;
            this.lnkReturn_Inicio.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkReturn_Inicio.Location = new System.Drawing.Point(259, 331);
            this.lnkReturn_Inicio.Name = "lnkReturn_Inicio";
            this.lnkReturn_Inicio.Size = new System.Drawing.Size(224, 30);
            this.lnkReturn_Inicio.TabIndex = 11;
            this.lnkReturn_Inicio.TabStop = true;
            this.lnkReturn_Inicio.Text = "RETORNAR AO INÍCIO";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(728, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackgroundImage = global::WindowsFormsControleFuncionários.Properties.Resources.Gestão_PRO__3___1_;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.Location = new System.Drawing.Point(706, -1);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(23, 23);
            this.btnMaximizar.TabIndex = 15;
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
            this.btnMinimizar.Location = new System.Drawing.Point(684, -1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(23, 23);
            this.btnMinimizar.TabIndex = 14;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::WindowsFormsControleFuncionários.Properties.Resources.back;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVoltar.Location = new System.Drawing.Point(9, 7);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(40, 27);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // pbxConfirm_Green
            // 
            this.pbxConfirm_Green.Image = global::WindowsFormsControleFuncionários.Properties.Resources.verified;
            this.pbxConfirm_Green.Location = new System.Drawing.Point(321, 203);
            this.pbxConfirm_Green.Name = "pbxConfirm_Green";
            this.pbxConfirm_Green.Size = new System.Drawing.Size(100, 100);
            this.pbxConfirm_Green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxConfirm_Green.TabIndex = 10;
            this.pbxConfirm_Green.TabStop = false;
            // 
            // CadastroConfirmado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lnkReturn_Inicio);
            this.Controls.Add(this.pbxConfirm_Green);
            this.Controls.Add(this.lblCadas_Criado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "CadastroConfirmado";
            this.Text = "CadastroConfirmado";
            this.Load += new System.EventHandler(this.CadastroConfirmado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxConfirm_Green)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCadas_Criado;
        private System.Windows.Forms.PictureBox pbxConfirm_Green;
        private System.Windows.Forms.LinkLabel lnkReturn_Inicio;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnClose;
    }
}