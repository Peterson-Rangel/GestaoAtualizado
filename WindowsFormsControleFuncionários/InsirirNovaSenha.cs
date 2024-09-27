using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControleFuncionários
{
    public partial class InsirirNovaSenha : Form
    {
        public InsirirNovaSenha()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            
            } else if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pbx_Olho_Senha1_MouseDown(object sender, MouseEventArgs e)
        {
            tbx_confrm_Senha1.UseSystemPasswordChar = false;
        }


        private void pbx_Olho_Senha1_MouseUp(object sender, MouseEventArgs e)
        {
            tbx_confrm_Senha1.UseSystemPasswordChar = true;
        }

        private void pbx_Olho_Senha2_MouseDown(object sender, MouseEventArgs e)
        {
            tbx_confirmSenha2.UseSystemPasswordChar = false;
        }

        private void pbx_Olho_Senha2_MouseUp(object sender, MouseEventArgs e)
        {
            tbx_confirmSenha2.UseSystemPasswordChar = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
