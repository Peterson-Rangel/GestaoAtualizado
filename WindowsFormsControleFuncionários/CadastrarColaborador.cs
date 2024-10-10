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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsControleFuncionários
{
    public partial class CadastrarColaborador : Form
    {
        public CadastrarColaborador()
        {
            InitializeComponent();
        }

        //SqlConnection conexao = new SqlConnection (@"Persist Security Info=true; User ID=PetersonRangel; Password=Pokoloko1@.;
        //Initial Catalog=controle;Server=PETERSON-RANGEL;Encrypt=false;");

        /*SqlConnection conexao = new SqlConnection (@"Persist Security Info=true; User ID=senac; Password=senac;
        Initial Catalog=controle;Server=TAU0588417W10-1;Encrypt=false;");*/

        SqlConnection conexao = new SqlConnection(@"Persist Security Info=true; User ID=senac; Password=senac;
        Initial Catalog=controle;Server=TAU0588420W10-1;Encrypt=false;");

        //ahj



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
            if (tbxNomeColab.Text == string.Empty || mtbxCpfColab.Text == string.Empty || cbxPeriodo.Text == string.Empty || mtbxWhatsApp.Text == string.Empty || tbxEmailColab.Text == string.Empty
                || cbxStatus.Text == string.Empty || tbxPausas.Text == string.Empty || mtbxSalario.Text == string.Empty || tbxCargoAtual.Text == string.Empty || mtbxInicioContrato.Text == string.Empty
                || tbxObservacao.Text == string.Empty || mtbxCep.Text == string.Empty || tbxLogradouro.Text == string.Empty || tbxNumResidencia.Text == string.Empty || tbxBairro.Text == string.Empty
                || tbxCidade.Text == string.Empty || tbxEstado.Text == string.Empty || tbxComplemento.Text ==string.Empty)
            {
                MessageBox.Show("Campos obrigatórios não preenchidos", "Cadastro Colaborador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string nomeColaborador = tbxNomeColab.Text;
                    string cpfColaborador = mtbxCpfColab.Text;
                    string periodo = cbxPeriodo.Text;
                    DateTime entrada = DateTime.Parse(tbxEntrada.Text);
                    DateTime saida = DateTime.Parse(tbxSaida.Text);
                    string whatsApp = mtbxWhatsApp.Text;
                    string eMail = tbxEmailColab.Text;
                    string status = cbxStatus.Text; // VERIFICAR TIPO DE DADOS SALVO NO SQL SERVER (PALAVRA RESERVADA)
                    DateTime pausas = DateTime.Parse(tbxPausas.Text);
                    DateTime retorno = DateTime.Parse(tbxRetorno.Text);
                    
                    string salariotexto = mtbxSalario.Text; //Tratamento de dados aqui? Sql Server == DECIMAL
                    salariotexto = salariotexto.Replace("R$", "").Replace(" ", "").Replace(",", ".").Trim();
                    decimal salario = decimal.Parse(salariotexto); //Tratamento de dados aqui? Sql Server == DECIMAL
                    
                    string cargo = tbxCargoAtual.Text;
                    cargotexto = salariotexto.Replace("R$", "").Replace(" ", "").Replace(",", ".").Trim();
                    decimal salario = decimal.Parse(cargotexto);
                    
                    DateTime inicioCont = DateTime.Parse(mtbxInicioContrato.Text); //Tratamento de dados aqui? Sql Server == DATA
                    
                    string observ = tbxObservacao.Text;
                    string cep = mtbxCep.Text; //Não Adicionado na tabela SQL SERVER
                    string logradouro = tbxLogradouro.Text;
                    int numResidencia = int.Parse(tbxNumResidencia.Text); //Tratamento de dados aqui? Sql Server == INT
                    string bairro = tbxBairro.Text;
                    string cidade = tbxCidade.Text;
                    string estado = tbxEstado.Text;
                    string complemento = tbxComplemento.Text;


                    //FALTA DECLARAR O RESTANTES DAS VARIAVEIS NO ADD.WITHVALLUE?
                    comando.CommandText = "insert into funcionarios(nome, cpf, whatsapp, email, data_contratacao, salario, status, observacao) values(@nome, @cpf, @whatsapp, @email, @dataInicio, @salario, @status, @observacao); " +
                        "insert into funcoes(funcao) values(@cargo); " +
                        "insert into enderecos_funcionarios (logradouro, numero, bairro, cidade, estado, complemento, cep) values(@logradouro, @numero, @bairro, @cidade, @estado, @complemento, @cep); " +
                        "insert into pausas (pausa, retorno) values (@pausa, @retorno); " +
                        "insert into periodos (periodo, entrada, saida) values (@periodo, @entrada, @saida);";

                    comando.Connection = conexao;
                    comando.Parameters.Clear(); 

                    comando.Parameters.AddWithValue("@nome", SqlDbType.Char).Value = nomeColaborador;
                    comando.Parameters.AddWithValue("@cpf", SqlDbType.Char).Value = cpfColaborador;
                    comando.Parameters.AddWithValue("@salario", SqlDbType.Decimal).Value = salario;
                    comando.Parameters.AddWithValue("@whatsapp", SqlDbType.Char).Value = whatsApp;
                    comando.Parameters.AddWithValue("@email", SqlDbType.Char).Value = eMail;
                    comando.Parameters.AddWithValue("@dataInicio", SqlDbType.Date).Value = inicioCont;
                    comando.Parameters.AddWithValue("@observacao", SqlDbType.Char).Value = observ;
                    comando.Parameters.AddWithValue("@status", SqlDbType.Char).Value = status;

                    comando.Parameters.AddWithValue("@cargo", SqlDbType.Char).Value = cargo;

                    comando.Parameters.AddWithValue("@logradouro", SqlDbType.Char).Value = logradouro;                    
                    comando.Parameters.AddWithValue("@bairro", SqlDbType.Char).Value = bairro;
                    comando.Parameters.AddWithValue("@numero", SqlDbType.Int).Value = numResidencia;
                    comando.Parameters.AddWithValue("@cidade", SqlDbType.Char).Value = cidade;
                    comando.Parameters.AddWithValue("@estado", SqlDbType.Char).Value = estado;
                    comando.Parameters.AddWithValue("@complemento", SqlDbType.Char).Value = complemento;
                    comando.Parameters.AddWithValue("@cep", SqlDbType.Char).Value = cep;

                    comando.Parameters.AddWithValue("@pausa", SqlDbType.Time).Value = pausas;
                    comando.Parameters.AddWithValue("@retorno", SqlDbType.Time).Value = retorno;

                    comando.Parameters.AddWithValue("@periodo", SqlDbType.Char).Value = periodo;
                    comando.Parameters.AddWithValue("@entrada", SqlDbType.Time).Value = entrada;
                    comando.Parameters.AddWithValue("@saida", SqlDbType.Time).Value = saida;







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

        private void CadastrarColaborador_Load(object sender, EventArgs e)
        {

        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnteste_Click(object sender, EventArgs e)
        {
                       
          
        }
    }
}
