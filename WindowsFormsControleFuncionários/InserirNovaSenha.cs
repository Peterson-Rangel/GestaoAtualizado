using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControleFuncionários
{
    public partial class InserirNovaSenha : Form
    {
        public InserirNovaSenha()
        {
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection(@"Persist Security Info=true;User ID=sa;Password=2024aiiiminhavuaida;
        Initial Catalog=controle;Server=LAPTOP-VOJU9E07;Encrypt=false;");//Leandro

        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            } 
            
            else if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pbx_Olho_Senha1_MouseDown(object sender, MouseEventArgs e)
        {
            tbxNovaSenha.UseSystemPasswordChar = false;
        }


        private void pbx_Olho_Senha1_MouseUp(object sender, MouseEventArgs e)
        {
            tbxNovaSenha.UseSystemPasswordChar = true;
        }

        private void pbx_Olho_Senha2_MouseDown(object sender, MouseEventArgs e)
        {
            tbxConfirmaNovaSenha.UseSystemPasswordChar = false;
        }

        private void pbx_Olho_Senha2_MouseUp(object sender, MouseEventArgs e)
        {
            tbxConfirmaNovaSenha.UseSystemPasswordChar = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCadastrarNova_Click(object sender, EventArgs e)
        {
            if (tbxNovaSenha.Text == "" || tbxConfirmaNovaSenha.Text == string.Empty) 
            { 
                MessageBox.Show("Preencher todos os campos", "Redefinir senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if(tbxNovaSenha.Text != tbxConfirmaNovaSenha.Text) 
            { 
                MessageBox.Show("Campos devem ser iguais", "Redefinir senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else 
            {
                try
                {
                    string novaSenha = tbxNovaSenha.Text;

                    comando.Connection = conexao;
                    conexao.Open();
                    comando.CommandText = "insert into usuarios (senha) values (@senha);";

                    comando.Parameters.AddWithValue("@senha", SqlDbType.Char).Value = novaSenha;

                    int linhas = comando.ExecuteNonQuery();

                    if (linhas > 0)
                    {
                        MessageBox.Show("Nova senha cadastrada com sucesso", "Redefinir senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        MessageBox.Show("Nova senha não foi cadastrada", "Redefinir senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    conexao.Close();
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
