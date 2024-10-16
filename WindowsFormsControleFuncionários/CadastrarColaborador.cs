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

        /*SqlConnection conexao = new SqlConnection (@"Persist Security Info=true; User ID=PetersonRangel; Password=Pokoloko1@.;
        Initial Catalog=controle;Server=PETERSON-RANGEL;Encrypt=false;");*/ //Servidor casa Peterson

        SqlConnection conexao = new SqlConnection(@"Persist Security Info=true;User ID=sa;Password=2024aiiiminhavuaida;
        Initial Catalog=controle;Server=LAPTOP-VOJU9E07;Encrypt=false;");//Leandro

        /*SqlConnection conexao = new SqlConnection(@"Persist Security Info=true; User ID=senac; Password=senac;
        Initial Catalog=controle;Server=TAU0588420W10-1;Encrypt=false;");*///Servidor Senac Leandro

        /*SqlConnection conexao = new SqlConnection(@"Persist Security Info=true; User ID=senac; Password=senac;
        Initial Catalog=controle;Server=TAU0588417W10-1;Encrypt=false;");*/ //Servidor Senac Peterson

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
            else if (this.WindowState == FormWindowState.Maximized)
            {

                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void btnCadastroColab_Click(object sender, EventArgs e)
        {
            if (tbxNomeColab.Text == string.Empty || tbxCpfColab.Text == string.Empty || tbxWhatsApp.Text == string.Empty || tbxEmailColab.Text == string.Empty || tbxCargoAtual.Text == string.Empty
                || tbxSalario.Text == string.Empty || cbxPeriodo.Text == string.Empty || tbxPausas.Text == string.Empty || tbxRetorno.Text == string.Empty || tbxInicioContrato.Text == string.Empty
                || cbxStatus.Text == string.Empty || tbxCep.Text == string.Empty || tbxLogradouro.Text == string.Empty || tbxBairro.Text == string.Empty || tbxNumResidencia.Text == string.Empty
                || tbxCidade.Text == string.Empty || tbxEstado.Text == string.Empty || tbxComplemento.Text == string.Empty || tbxObservacao.Text == string.Empty)
            {                
                MessageBox.Show("Campos obrigatórios não preenchidos", "Cadastro Colaborador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
            
            else
            {
                try
                {
                    string nomeColaborador = tbxNomeColab.Text;
                    string cpfColaborador = tbxCpfColab.Text;
                    string whatsApp = tbxWhatsApp.Text;
                    string eMail = tbxEmailColab.Text;
                    string cargo = tbxCargoAtual.Text;

                    string salariotexto = tbxSalario.Text; //Tratamento de dados aqui? Sql Server == DECIMAL
                    salariotexto = salariotexto.Replace("R$", "").Replace(" ", "").Replace(",", ".").Trim();
                    decimal salario = decimal.Parse(salariotexto); //Tratamento de dados aqui? Sql Server == DECIMAL

                    string periodo = cbxPeriodo.Text;
                    DateTime pausas = DateTime.Parse(tbxPausas.Text);
                    DateTime retorno = DateTime.Parse(tbxRetorno.Text);

                    string inicioCont = tbxInicioContrato.Text;
                    inicioCont = inicioCont.Replace("/", "-").Replace("/", "-").Trim();
                    DateTime inicioContrato = DateTime.Parse(inicioCont); //Tratamento de dados aqui? Sql Server == DATA

                    string status = cbxStatus.Text;

                    //string horaEntrada = mtbxEntrada.Text; 
                    //horaEntrada = salariotexto.Replace(":", "").Trim();//
                    //DateTime entrada = DateTime.Parse(tbxEntrada.Text);// Só usar esse, se necessário

                    //string horaSaida = mtbxSaida.Text;
                    //horaSaida = horaSaida.ToString();
                    //DateTime saida = DateTime.Parse(tbxSaida.Text);// Só usar esse, se necessário

                    string cep = tbxCep.Text; // fazer API
                    string logradouro = tbxLogradouro.Text;
                    string bairro = tbxBairro.Text;
                    int numResidencia = int.Parse(tbxNumResidencia.Text);
                    string cidade = tbxCidade.Text;
                    string estado = tbxEstado.Text;
                    string complemento = tbxComplemento.Text;
                    string observ = tbxObservacao.Text;


                    comando.CommandText = "insert into funcionarios(nome, cpf, whatsApp, email, data_contratacao, status, observacao) values(@nome, @cpf, @whatsapp, @email, @dataInicio, @status, @observacao); " +
                        "insert into enderecos_funcionarios (cep, logradouro, numero, bairro, cidade, estado, complemento) values(@cep, @logradouro, @numero, @bairro, @cidade, @estado, @complemento); " +
                        //"insert into acompanhamentos (hora_entrada, hora_saida, hora_pausa, hora_retorno) values(@horaEntrada, @horaSaida, @horaPausa, @horaRetorno); " +
                        "insert into funcoes (funcao) values(@cargo); " +
                        "insert into pausas (pausa, retorno) values (@pausa, @retorno); " +
                        "insert into periodos (periodo) values(@periodo); " +
                        "insert into salarios (salario) values (@salario);";
                        

                    comando.Connection = conexao;
                    comando.Parameters.Clear();

                    comando.Parameters.AddWithValue("@nome", SqlDbType.Char).Value = nomeColaborador;
                    comando.Parameters.AddWithValue("@cpf", SqlDbType.Char).Value = cpfColaborador;
                    comando.Parameters.AddWithValue("@whatsapp", SqlDbType.Char).Value = whatsApp;
                    comando.Parameters.AddWithValue("@email", SqlDbType.Char).Value = eMail;
                    comando.Parameters.AddWithValue("@cargo", SqlDbType.Char).Value = cargo;
                    comando.Parameters.AddWithValue("@salario", SqlDbType.Decimal).Value = salario;
                    comando.Parameters.AddWithValue("@periodo", SqlDbType.Char).Value = periodo;

                    comando.Parameters.AddWithValue("@pausa", SqlDbType.Time).Value = pausas;
                    comando.Parameters.AddWithValue("@retorno", SqlDbType.Time).Value = retorno;
                    //comando.Parameters.AddWithValue("@entrada", SqlDbType.Time).Value = entrada;
                    //comando.Parameters.AddWithValue("@saida", SqlDbType.Time).Value = saida;
                    comando.Parameters.AddWithValue("@dataInicio", SqlDbType.Date).Value = inicioCont;
                    comando.Parameters.AddWithValue("@status", SqlDbType.Char).Value = status;
                    comando.Parameters.AddWithValue("@cep", SqlDbType.Char).Value = cep;

                    comando.Parameters.AddWithValue("@logradouro", SqlDbType.Char).Value = logradouro;
                    comando.Parameters.AddWithValue("@bairro", SqlDbType.Char).Value = bairro;
                    comando.Parameters.AddWithValue("@numero", SqlDbType.Int).Value = numResidencia;
                    comando.Parameters.AddWithValue("@cidade", SqlDbType.Char).Value = cidade;
                    comando.Parameters.AddWithValue("@estado", SqlDbType.Char).Value = estado;
                    comando.Parameters.AddWithValue("@complemento", SqlDbType.Char).Value = complemento;
                    comando.Parameters.AddWithValue("@observacao", SqlDbType.Char).Value = observ;

          

                    conexao.Open();

                    int linhasAfetadas = comando.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Funcionário cadastrado com sucesso!");
                        PagInicial inicio = new PagInicial();
                        inicio.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Funcionário não foi cadastrado!");
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
    }
}

