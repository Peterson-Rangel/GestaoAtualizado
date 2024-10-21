using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace WindowsFormsControleFuncionários
{
    public partial class CadastrarGerente : Form
    {
        public CadastrarGerente()
        {
            InitializeComponent();
        }

        /*SqlConnection conexao = new SqlConnection(@"Persist Security Info=true;User ID=PetersonRangel;Password=Pokoloko1@.;
        Initial Catalog=controle;Server=PETERSON-RANGEL;Encrypt=false;");*///Peterson

        SqlConnection conexao = new SqlConnection(@"Persist Security Info=true;User ID=sa;Password=2024aiiiminhavuaida;
        Initial Catalog=controle;Server=LAPTOP-VOJU9E07;Encrypt=false;");//Leandro

        /*SqlConnection conexao = new SqlConnection (@"Persist Security Info=true; User ID=senac; Password=senac;
        Initial Catalog=controle;Server=TAU0588417W10-1;Encrypt=false;");*///Senac Peterson

        /*SqlConnection conexao = new SqlConnection(@"Persist Security Info=true; User ID=senac; Password=senac;
        Initial Catalog=controle;Server=TAU0588420W10-1;Encrypt=false;");*/// Senac Leandro


        SqlCommand comando = new SqlCommand();

        SqlDataReader dr;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) {
                this.WindowState = FormWindowState.Maximized;
            } else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CadastrarGerente_Load(object sender, EventArgs e)
        {
           
        }

        private void pnlLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (tbxNome.Text == "" || tbxEmail.Text == "" || mtbxCPF.Text == "" || tbxSenha.Text == "" || tbxConfirmar.Text == "")
            {
                MessageBox.Show("Campos obrigatórios não preenchidos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            
            else if (tbxConfirmar.Text != tbxSenha.Text)
            {
                //CONFIRMAÇÃO E SENHA / Lógica de igualdade de senha


                MessageBox.Show("Campo 'Confirmar Senha' precisa ser igual informado acima!");
                }
            
            else
            {
                try
                {
                    string nomeG = tbxNome.Text;
                    string emailG = tbxEmail.Text;
                    string cpfG = mtbxCPF.Text;
                    string senhaG = tbxSenha.Text;
                    
                    //comando.CommandText = "insert into usuarios values nome = ('" + tbxNome.Text + "') and email = ('" + tbxEmail.Text + "') and cpf = ('" + tbxCPF.Text + "') and senha = ('" + tbxSenha.Text + "') and confirmar_senha = ('" + tbxConfirmar.Text + "')";
                    comando.CommandText = "insert into usuarios (nome, email, cpf, senha) values (@nome, @email, @cpf, @senha);";
                    comando.Connection = conexao;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@nome", SqlDbType.Char).Value = nomeG;
                    comando.Parameters.AddWithValue("@email", SqlDbType.Char).Value = emailG;
                    comando.Parameters.AddWithValue("@cpf", SqlDbType.Char).Value = cpfG;
                    comando.Parameters.AddWithValue("@senha", SqlDbType.Char).Value = senhaG;

                    conexao.Open();

                    int linhas = comando.ExecuteNonQuery();
                    if (linhas > 0)
                    {
                        MessageBox.Show("Usuário cadastrado com sucesso!");
                        this.Close();
                        Login login = new Login(); 
                        login.Show();
                    }
                    
                    else
                    {
                        MessageBox.Show("Usuário não foi cadastrado!");
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    conexao.Close();
                }
                finally {
                    conexao.Close();    
                }
            }
        }

        private void btnOlhoSenha_MouseDown(object sender, MouseEventArgs e)
        {
            tbxSenha.UseSystemPasswordChar = false;
        }

        private void btnOlhoSenha_MouseUp(object sender, MouseEventArgs e)
        {
            tbxSenha.UseSystemPasswordChar = true;
        }

        private void btnOlhoConfirmar_MouseDown(object sender, MouseEventArgs e)
        {
            tbxConfirmar.UseSystemPasswordChar = false;
        }

        private void btnOlhoConfirmar_MouseUp(object sender, MouseEventArgs e)
        {
            tbxConfirmar.UseSystemPasswordChar = true;
        }
    } 
}
