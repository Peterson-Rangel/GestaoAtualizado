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
    public partial class EditarColaborador : Form
    {
        public EditarColaborador()
        {
            InitializeComponent();
        }

        //SqlConnection conexao = new SqlConnection (@"Persist Security Info=true; User ID=PetersonRangel; Password=Pokoloko1@.;
        //Initial Catalog=controle;Server=PETERSON-RANGEL;Encrypt=false;");

        /*SqlConnection conexao = new SqlConnection (@"Persist Security Info=true; User ID=senac; Password=senac;
        Initial Catalog=controle;Server=TAU0588417W10-1;Encrypt=false;");*/

        SqlConnection conexao = new SqlConnection(@"Persist Security Info=true; User ID=senac; Password=senac;
        Initial Catalog=controle;Server=TAU0588420W10-1;Encrypt=false;");



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

        private void EditarColaborador_Load(object sender, EventArgs e)
        {

        }

        private void pbxIrAcompanhamento_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarColab_Click(object sender, EventArgs e)
        {
            if (tbxNomeColab.Text == string.Empty || tbxCpfColab.Text == string.Empty || cbxPeriodo.Text == string.Empty || tbxWhatsApp.Text == string.Empty || tbxEmailColab.Text == string.Empty
                || cbxStatus.Text == string.Empty || tbxPausas.Text == string.Empty || tbxSalario.Text == string.Empty || tbxCargoAtual.Text == string.Empty || tbxInicioContrato.Text == string.Empty
                || tbxObservacao.Text == string.Empty || tbxCep.Text == string.Empty || tbxLogradouro.Text == string.Empty || tbxNumResidencia.Text == string.Empty || tbxBairro.Text == string.Empty
                || tbxCidade.Text == string.Empty || tbxEstado.Text == string.Empty || tbxComplemento.Text == string.Empty)
            {
                MessageBox.Show("Campos obrigatórios não preenchidos", "Cadastro Colaborador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string nomeColaborador = tbxNomeColab.Text;
                    string cpfColaborador = tbxCpfColab.Text;
                    string periodo = cbxPeriodo.Text;

                    //string horaEntrada = mtbxEntrada.Text; 
                    //horaEntrada = salariotexto.Replace(":", "").Trim();//
                    DateTime entrada = DateTime.Parse(tbxEntrada.Text);

                    //string horaSaida = mtbxSaida.Text;
                    //horaSaida = horaSaida.ToString();
                    DateTime saida = DateTime.Parse(tbxSaida.Text);

                    string whatsApp = tbxWhatsApp.Text;
                    string eMail = tbxEmailColab.Text;
                    string status = cbxStatus.Text; // VERIFICAR TIPO DE DADOS SALVO NO SQL SERVER (PALAVRA RESERVADA)

                    DateTime pausas = DateTime.Parse(tbxPausas.Text);

                    DateTime retorno = DateTime.Parse(tbxRetorno.Text);

                    string salariotexto = tbxSalario.Text; //Tratamento de dados aqui? Sql Server == DECIMAL
                    salariotexto = salariotexto.Replace("R$", "").Replace(" ", "").Replace(",", ".").Trim();
                    decimal salario = decimal.Parse(salariotexto); //Tratamento de dados aqui? Sql Server == DECIMAL

                    string cargo = tbxCargoAtual.Text;

                    string inicioCont = tbxInicioContrato.Text;
                    inicioCont = inicioCont.Replace("/", "-").Replace("/", "-").Trim();
                    DateTime inicioContrato = DateTime.Parse(inicioCont); //Tratamento de dados aqui? Sql Server == DATA

                    string observ = tbxObservacao.Text;
                    string cep = tbxCep.Text; // fazer API
                    string logradouro = tbxLogradouro.Text;
                    int numResidencia = int.Parse(tbxNumResidencia.Text);
                    string bairro = tbxBairro.Text;
                    string cidade = tbxCidade.Text;
                    string estado = tbxEstado.Text;
                    string complemento = tbxComplemento.Text;

                    //Precisa fazer um por um?
                    comando.CommandText = "update funcionarios set (nome, cpf, whatsapp, email, data_contratacao, salario, status, observacao) where (@nome, @cpf, @whatsapp, @email, @dataInicio, @salario, @status, @observacao); " +
                        "update funcoes set (funcao) where (@cargo); " +
                        "update enderecos_funcionarios set (logradouro, numero, bairro, cidade, estado, complemento, cep) where (@logradouro, @numero, @bairro, @cidade, @estado, @complemento, @cep); " +
                        "update pausas set (pausa, retorno) where (@pausa, @retorno); " +
                        "update periodos set (periodo, entrada, saida) where (@periodo, @entrada, @saida);";

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

//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//namespace WindowsFormsControleFuncionários
//{
//    public partial class PagInicial : Form
//    {
//        public PagInicial()
//        {
//            InitializeComponent();
//        }

//        //SqlConnection conexao = new SqlConnection(@"Persist Security Info=true;User ID=PetersonRangel;Password=Pokoloko1@.;
//        //Initial Catalog=controle;Server=PETERSON-RANGEL;Encrypt=false;");

//        SqlConnection conexao = new SqlConnection(@"Persist Security Info=true;User ID=senac;Password=senac;
//        Initial Catalog=controle;Server=TAU0588417W10-1;Encrypt=false;");



//        SqlCommand comando = new SqlCommand();
//        SqlDataReader dt;



//        private void btnMaxi_Click(object sender, EventArgs e)
//        {
//            if (this.WindowState == FormWindowState.Normal)
//            {
//                this.WindowState = FormWindowState.Maximized;
//            }
//            else if (this.WindowState == FormWindowState.Maximized)
//            {

//                this.WindowState = FormWindowState.Normal;
//            }
//        }

//        private void btnMini_Click(object sender, EventArgs e)
//        {
//            this.WindowState = FormWindowState.Minimized;
//        }

//        private void btnFechar_Click(object sender, EventArgs e)
//        {
//            Application.Exit();
//        }

//        private void btnSair_Click(object sender, EventArgs e)
//        {
//            Login returnarLogin = new Login();
//            MessageBox.Show("Tem certeza que deseja sair?", "Desconectar?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
//            returnarLogin.Show();
//            this.Hide();
//        }

//        private void tbxAcompanhamento_TextChanged(object sender, EventArgs e)
//        {
//            if (tbxAcompanhamento.Text != "")
//            {
//                try
//                {
//                    conexao.Open();
//                    comando.CommandText = "select * from funcionarios where nome like ('%" + tbxAcompanhamento.Text + "%')";
//                    comando.Connection = conexao;

//                    SqlDataAdapter da = new SqlDataAdapter();

//                    DataTable dt = new DataTable();

//                    da.SelectCommand = comando;
//                    da.Fill(dt);
//                    dgvAcompanhamento.DataSource = dt;

//                }
//                catch (Exception erro)
//                {
//                    MessageBox.Show(erro.Message);
//                    conexao.Close();
//                }
//                finally { conexao.Close(); }
//            }
//            //else
//            //{
//            //    dgvAcompanhamento = null;
//            //}
//        }

//        private void carregaColaborador()
//        {

//            tbxNome.Text = dgvAcompanhamento.SelectedRows[0].Cells[1].Value.ToString();
//            //tbxNome.Text = dgvAcompanhamento.SelectedRows[0].Cells[3].Value.ToString();
//            //tbxLogin.Text = dgvAcompanhamento.SelectedRows[0].Cells[1].Value.ToString();
//            //tbxSenha.Text = dgvAcompanhamento.SelectedRows[0].Cells[2].Value.ToString();
//            //string valor = dgvAcompanhamento.SelectedRows[0].Cells[4].Value.ToString();

//        }

//        private void dgvAcompanhamento_DoubleClick(object sender, EventArgs e)
//        {
//            carregaColaborador();
//            CadastrarGerente teste = new CadastrarGerente();
//            teste.Show();
//            this.Hide();
//        }
//    }
//}
