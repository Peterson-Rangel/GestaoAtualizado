using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
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
            InitializeComponent();//;Oi
        }

        //Variaveis
        public static string id_funcionario;
        public static string nomeColab;
        public static string cpfColab;
        public static string whatsappColab;
        public static string emailColab;
        public static string cargoColab;
        public static string salarioColab;
        public static string periodoColab;

        public static string pausaColab;
        public static string retornoColab;
        public static string inicioContratoColab;
        public static string statusColab;
        //public static string entradaColab;
        //public static string saidaColab;

        public static string cepColab;
        public static string logradouroColab;
        public static string numeroColab;
        public static string bairroColab;
        public static string cidadeColab;
        public static string estadoColab;

        public static string complementoColab;
        public static string observacoesColab;



        //SqlConnection conexao = new SqlConnection(@"Persist Security Info=False;User ID=senac;Password=senac;Initial Catalog=controle;Server=TAU0588420W10-1;");
        SqlConnection conexao = new SqlConnection(@"Persist Security Info=False;User ID=sa;Password=2024aiiiminhavuaida;Initial Catalog=controle;Server=LAPTOP-VOJU9E07;");

        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;

        private void btnMaxi_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {

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

        private void tbxAcompanhamento_TextChanged(object sender, EventArgs e)
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
            if (dgvAcompanhamento.SelectedRows.Count > 0)
            {
                carregaColaborador();
                EditarColaborador editColab = new EditarColaborador();
                editColab.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Nemhuma linha foi selecionada");
            }
        }

        private void carregaColaborador()
        {

            nomeColab = dgvAcompanhamento.SelectedRows[0].Cells[1].Value.ToString();
            cpfColab = dgvAcompanhamento.SelectedRows[0].Cells[2].Value.ToString();
            whatsappColab = dgvAcompanhamento.SelectedRows[0].Cells[3].Value.ToString();
            emailColab = dgvAcompanhamento.SelectedRows[0].Cells[4].Value.ToString();
            cargoColab = dgvAcompanhamento.SelectedRows[0].Cells[1].Value.ToString();
            salarioColab = dgvAcompanhamento.SelectedRows[0].Cells[1].Value.ToString();
            periodoColab = dgvAcompanhamento.SelectedRows[0].Cells[1].Value.ToString();

            pausaColab = dgvAcompanhamento.SelectedRows[0].Cells[1].Value.ToString();
            retornoColab = dgvAcompanhamento.SelectedRows[0].Cells[2].Value.ToString();
            inicioContratoColab = dgvAcompanhamento.SelectedRows[0].Cells[5].Value.ToString();
            statusColab = dgvAcompanhamento.SelectedRows[0].Cells[6].Value.ToString();
            //entradaColab = dgvAcompanhamento.SelectedRows[0].Cells[1].Value.ToString();
            //saidaColab = dgvAcompanhamento.SelectedRows[0].Cells[2].Value.ToString();

            cepColab = dgvAcompanhamento.SelectedRows[0].Cells[1].Value.ToString();
            logradouroColab = dgvAcompanhamento.SelectedRows[0].Cells[2].Value.ToString();
            numeroColab = dgvAcompanhamento.SelectedRows[0].Cells[3].Value.ToString();
            bairroColab = dgvAcompanhamento.SelectedRows[0].Cells[4].Value.ToString();
            cidadeColab = dgvAcompanhamento.SelectedRows[0].Cells[5].Value.ToString();
            estadoColab = dgvAcompanhamento.SelectedRows[0].Cells[6].Value.ToString();

            complementoColab = dgvAcompanhamento.SelectedRows[0].Cells[7].Value.ToString();
            observacoesColab = dgvAcompanhamento.SelectedRows[0].Cells[7].Value.ToString();
        }
    }
}

