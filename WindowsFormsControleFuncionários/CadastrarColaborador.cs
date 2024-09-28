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

namespace WindowsFormsControleFuncionários
{
    public partial class CadastrarColaborador : Form
    {
        public CadastrarColaborador()
        {
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection (@"Persist Security Info=true; User ID=PetersonRangel; Password=Pokoloko1@.;
        Initial Catalog=controle;Server=PETERSON-RANGEL;Encrypt=false;");

        SqlCommand comando = new SqlCommand();
        SqlDataReader dataType;

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized) { 
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastroColab_Click(object sender, EventArgs e)
        {
            if (tbxNomeColab.Text == string.Empty || tbxCpfColab.Text == string.Empty || tbxPeriodo.Text == string.Empty || tbxWhatsApp.Text == string.Empty || tbxEmailColab.Text == string.Empty
                || tbxStatus.Text == string.Empty || tbxPausas.Text == string.Empty || tbxSalario.Text == string.Empty || tbxCargoAtual.Text == string.Empty || tbxInicioContrato.Text == string.Empty
                || tbxObservacao.Text == string.Empty || tbxCep.Text == string.Empty || tbxLogradouro.Text == string.Empty || tbxNumResidencia.Text == string.Empty || tbxBairro.Text == string.Empty
                || tbxCidade.Text == string.Empty || tbxEstado.Text == string.Empty || tbxComplemento.Text ==string.Empty)
            {
                MessageBox.Show("Campos obrigatórios não preenchidos", "Cadastro Colaborador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string nomeColaborador = tbxNomeColab.Text;
                    string cpfColaborador = tbxCpfColab.Text;
                    string periodo = tbxPeriodo.Text;
                    string whatsApp = tbxWhatsApp.Text;
                    string eMail = tbxEmailColab.Text;
                    //string status = tbxStatus.Text; // VERIFICAR TIPO DE DADOS SALVO NO SQL SERVER (PALAVRA RESERVADA)
                    string pausas = tbxPausas.Text;
                    string salario = tbxSalario.Text; //Tratamento de dados aqui? Sql Server == DECIMAL
                    string cargo = tbxCargoAtual.Text;
                    string inicioCont = tbxInicioContrato.Text; //Tratamento de dados aqui? Sql Server == DATA
                    string observ = tbxObservacao.Text;
                    //string cep = tbxCep.Text; //Não Adicionado na tabela SQL SERVER
                    string logradouro = tbxLogradouro.Text;
                    string numResidencia = tbxNumResidencia.Text; //Tratamento de dados aqui? Sql Server == INT
                    string bairro = tbxBairro.Text;
                    string cidade = tbxCidade.Text;
                    string estado = tbxEstado.Text;
                    string complemento = tbxComplemento.Text;


                    //FALTA DECLARAR O RESTANTES DAS VARIAVEIS NO ADD.WITHVALLUE?
                    comando.CommandText = "insert into funcionarios (nome, cpf, data_contratacao, salario, observacao) values (@nome, @cpf, @dataInicio, @salario, @observacao);";
                    comando.CommandText = "insert into funcoes (funcao) values (@cargo);";
                    comando.CommandText = "insert into enderecos_funcionarios (logradouro, numero, bairro, cidade, estado, complemento) values(@logradouro, @numero, @bairro, @cidade, @estado, @complemento);";
                    comando.Connection = conexao;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@nome", SqlDbType.Char).Value = nomeColaborador;
                    comando.Parameters.AddWithValue("@cpf", SqlDbType.Char).Value = cpfColaborador;
                    comando.Parameters.AddWithValue("@salario", SqlDbType.Decimal).Value = salario;
                    comando.Parameters.AddWithValue("@@cargo", SqlDbType.Char).Value = cargo;

                    conexao.Open();

                    int linhasAfetadas = comando.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Usuário cadastrado com sucesso!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuário não foi cadastrado!");
                    }

                }
                catch (Exception erro) {
                    MessageBox.Show(erro.Message);
                    conexao.Close();
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
    }
}
