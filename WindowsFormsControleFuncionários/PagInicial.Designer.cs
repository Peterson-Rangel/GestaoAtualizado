namespace WindowsFormsControleFuncionários
{
    partial class PagInicial
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnMaxi = new System.Windows.Forms.Button();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblAcompanhamento = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.tbxAcompanhamento = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCadastrarColab = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dgvAcompanhamento = new System.Windows.Forms.DataGridView();
            this.lblEdicao1 = new System.Windows.Forms.Label();
            this.lblEdicao2 = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcompanhamento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(968, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 28);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.pnlLeft.Controls.Add(this.btnMaxi);
            this.pnlLeft.Controls.Add(this.btnMini);
            this.pnlLeft.Controls.Add(this.btnFechar);
            this.pnlLeft.Controls.Add(this.lblAcompanhamento);
            this.pnlLeft.Controls.Add(this.pbxLogo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(1000, 239);
            this.pnlLeft.TabIndex = 10;
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
            // lblAcompanhamento
            // 
            this.lblAcompanhamento.AutoSize = true;
            this.lblAcompanhamento.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcompanhamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAcompanhamento.Location = new System.Drawing.Point(345, 79);
            this.lblAcompanhamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAcompanhamento.Name = "lblAcompanhamento";
            this.lblAcompanhamento.Size = new System.Drawing.Size(433, 62);
            this.lblAcompanhamento.TabIndex = 1;
            this.lblAcompanhamento.Text = "Acompanhamento";
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
            // tbxAcompanhamento
            // 
            this.tbxAcompanhamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAcompanhamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAcompanhamento.Location = new System.Drawing.Point(133, 298);
            this.tbxAcompanhamento.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAcompanhamento.Name = "tbxAcompanhamento";
            this.tbxAcompanhamento.Size = new System.Drawing.Size(422, 34);
            this.tbxAcompanhamento.TabIndex = 11;
            this.tbxAcompanhamento.TextChanged += new System.EventHandler(this.tbxAcompanhamento_TextChanged);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPesquisa.Location = new System.Drawing.Point(132, 263);
            this.lblPesquisa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(404, 32);
            this.lblPesquisa.TabIndex = 7;
            this.lblPesquisa.Text = "Pesquise o funcionário pelo nome";
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackgroundImage = global::WindowsFormsControleFuncionários.Properties.Resources.Gestão_PRO__3___1_;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.Location = new System.Drawing.Point(939, 2);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(31, 28);
            this.btnMaximizar.TabIndex = 9;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = global::WindowsFormsControleFuncionários.Properties.Resources.minimize_sign;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.Image = global::WindowsFormsControleFuncionários.Properties.Resources.maximize;
            this.btnMinimizar.Location = new System.Drawing.Point(909, 2);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(31, 28);
            this.btnMinimizar.TabIndex = 8;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarColab
            // 
            this.btnCadastrarColab.FlatAppearance.BorderSize = 10;
            this.btnCadastrarColab.Location = new System.Drawing.Point(80, 629);
            this.btnCadastrarColab.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrarColab.Name = "btnCadastrarColab";
            this.btnCadastrarColab.Size = new System.Drawing.Size(177, 28);
            this.btnCadastrarColab.TabIndex = 13;
            this.btnCadastrarColab.Text = "Cadastrar Novo Colaborador";
            this.btnCadastrarColab.UseVisualStyleBackColor = true;
            this.btnCadastrarColab.Click += new System.EventHandler(this.btnCadastrarColab_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Location = new System.Drawing.Point(907, 634);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(77, 28);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dgvAcompanhamento
            // 
            this.dgvAcompanhamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcompanhamento.Location = new System.Drawing.Point(133, 341);
            this.dgvAcompanhamento.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAcompanhamento.Name = "dgvAcompanhamento";
            this.dgvAcompanhamento.RowHeadersWidth = 51;
            this.dgvAcompanhamento.Size = new System.Drawing.Size(833, 271);
            this.dgvAcompanhamento.TabIndex = 15;
            this.dgvAcompanhamento.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvAcompanhamento_MouseDoubleClick);
            // 
            // lblEdicao1
            // 
            this.lblEdicao1.AutoSize = true;
            this.lblEdicao1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdicao1.Location = new System.Drawing.Point(646, 269);
            this.lblEdicao1.Name = "lblEdicao1";
            this.lblEdicao1.Size = new System.Drawing.Size(302, 25);
            this.lblEdicao1.TabIndex = 16;
            this.lblEdicao1.Text = "Clique no espaça à esquerda do Id";
            // 
            // lblEdicao2
            // 
            this.lblEdicao2.AutoSize = true;
            this.lblEdicao2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdicao2.Location = new System.Drawing.Point(719, 300);
            this.lblEdicao2.Name = "lblEdicao2";
            this.lblEdicao2.Size = new System.Drawing.Size(230, 25);
            this.lblEdicao2.TabIndex = 17;
            this.lblEdicao2.Text = "para editar algum  campo";
            // 
            // PagInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 677);
            this.Controls.Add(this.lblEdicao2);
            this.Controls.Add(this.lblEdicao1);
            this.Controls.Add(this.dgvAcompanhamento);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastrarColab);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.tbxAcompanhamento);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PagInicial";
            this.Text = "PagInicial";
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcompanhamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnMaxi;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblAcompanhamento;
        private System.Windows.Forms.TextBox tbxAcompanhamento;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Button btnCadastrarColab;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgvAcompanhamento;
        private System.Windows.Forms.Label lblEdicao1;
        private System.Windows.Forms.Label lblEdicao2;
    }
}