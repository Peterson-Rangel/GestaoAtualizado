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
    public partial class PagInicial : Form
    {
        public PagInicial()
        {
            InitializeComponent();
        }
        
        SqlConnection conexao = new SqlConnection(@"Persist Security Info=False;User ID=senac;Password=senac;Initial Catalog=controle;Server=TAU0588420W10-1;");

        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;

        private void btnMaxi_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized) { 
                
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Você tem certeza que deseja sair?", "Desconectar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sair == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                Login retornarLogin = new Login();
                retornarLogin.Show();
                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tbxAcompanhamento.Text != "")
            {
                try
                {
                    conexao.Open();
                    comando.CommandText = "select * from funcionarios where nome like('%" + tbxAcompanhamento.Text + "%')";
                    comando.Connection = conexao;

                    //recer dados de uma tabela após a execução do Select
                    SqlDataAdapter da = new SqlDataAdapter();

                    //objeto que pode representar uma ou mais tabelas de dados quais permanecem alocadas em memória
                    DataTable dt = new DataTable();

                    da.SelectCommand = comando;
                    da.Fill(dt);//Preenchimento do datatable. Método ou função de abrir od DataTables
                    dgvAcompanhamento.DataSource = dt;
                    conexao.Close();
                }

                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }

            else
            {
                dgvAcompanhamento.DataSource = null;
            }
        }

        private void btnCadastrarColab_Click(object sender, EventArgs e)
        {
            CadastrarColaborador cadColab = new CadastrarColaborador();
            cadColab.Show();
            this.Hide();
        }

        private void dgvAcompanhamento_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void l(object sender, DataGridViewCellEventArgs e)
        {

        }
    } //atualizado
}
