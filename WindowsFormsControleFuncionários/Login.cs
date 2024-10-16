using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace WindowsFormsControleFuncionários
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        /*SqlConnection conexao = new SqlConnection(@"Persist Security Info=true;User ID=PetersonRangel;Password=Pokoloko1@.;
        Initial Catalog=controle;Server=PETERSON-RANGEL;Encrypt=false;");*///Person

        SqlConnection conexao = new SqlConnection(@"Persist Security Info=true;User ID=sa;Password=2024aiiiminhavuaida;
        Initial Catalog=controle;Server=LAPTOP-VOJU9E07;Encrypt=false;");//Leandro

        /*SqlConnection conexao = new SqlConnection (@"Persist Security Info=true; User ID=senac; Password=senac;
        Initial Catalog=controle;Server=TAU0588417W10-1;Encrypt=false;");*///Senac Peterson

        /*SqlConnection conexao = new SqlConnection(@"Persist Security Info=true; User ID=senac; Password=senac;
        Initial Catalog=controle;Server=TAU0588420W10-1;Encrypt=false;");*/// Senac Leandro

        SqlCommand comando = new SqlCommand();

        SqlDataReader dataType;



        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void pbx_Olho_Login_MouseDown(object sender, MouseEventArgs e)
        {
            tbx_Senha_Login.UseSystemPasswordChar = false;
        }

        private void pbx_Olho_Login_MouseUp(object sender, MouseEventArgs e)
        {
            tbx_Senha_Login.UseSystemPasswordChar = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            } else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void tbxUsuario_Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (tbxUsuario_Login.Text == string.Empty || tbx_Senha_Login.Text == string.Empty)
            {
                MessageBox.Show("Campo USUÁRIO e/ou SENHA não preenchidos, necessário preencher!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    conexao.Open();
                    comando.CommandText = "select * from usuarios where email = ('" + tbxUsuario_Login.Text + "') and senha = ('" + tbx_Senha_Login.Text + "')";
                    comando.Connection = conexao;
                    dataType = comando.ExecuteReader();

                    if (dataType.HasRows)
                    {
                        PagInicial inicio = new PagInicial();
                        inicio.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Campo USUARIO ou SENHA incorretos!", "Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbxUsuario_Login.Clear();
                        tbx_Senha_Login.Clear();
                        tbxUsuario_Login.Focus();

                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    conexao.Close();
                }
                finally
                {
                    conexao.Close();
                }
            } 

        }

        private void btn_Cadastrar_User_Click(object sender, EventArgs e)
        {
            try
            {
                CadastrarGerente telaGerente = new CadastrarGerente();
                telaGerente.Show();
            }
            catch(Exception erro) {
                MessageBox.Show(erro.Message);                
            }
        }

        private void pbx_Olho_Login_Click(object sender, EventArgs e)
        {

        }

        private void lnkEsqueceu_Senha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
     
