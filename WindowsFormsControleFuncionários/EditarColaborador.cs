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

        private void pbxIrAcompanhamento_Click(object sender, EventArgs e)
        {
            PagInicial inicio = new PagInicial();
            inicio.Show();
            this.Hide();
        }

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

        private void btnEditarColab_Click(object sender, EventArgs e)
        {
            if (tbxNomeColab.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo 'Nome'", "Nome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxNomeColab.Focus();
            }

            else if (tbxCpfColab.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo 'CPF'", "CPF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxCpfColab.Focus();
            }

            else if (tbxWhatsApp.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo 'WhatsApp'", "WhatsApp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxWhatsApp.Focus();
            }

            else if (tbxEmailColab.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo 'E-Mail'", "E-Mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxEmailColab.Focus();
            }

            else if (tbxCargoAtual.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo 'Cargo Atual'", "Cargo Atual", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxCargoAtual.Focus();
            }

            else if (tbxSalario.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo 'Salário Atual'", "Salário Atual", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxSalario.Focus();
            }

            else if (cbxPeriodo.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo 'Período'", "Período", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxPeriodo.Focus();
            }

            else if (tbxPausas.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo 'Pausas'", "Pausas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxPausas.Focus();
            }

            else if (tbxRetorno.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo 'Retorno'", "Retorno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxRetorno.Focus();
            }

            else if (tbxInicioContrato.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo 'Início Contrato'", "Início Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxInicioContrato.Focus();
            }

            else if (cbxStatus.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo 'Status'", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxStatus.Focus();
            }

            /*else if (tbxEntrada.Text.Length < 8)
            {
                MessageBox.Show("Obrigatório informar o campo 'Entrada'", "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxEntrada.Focus();
            }*/

            /*else if (tbxSaida.Text.Length < 8)
            {
                MessageBox.Show("Obrigatório informar o campo 'Saída'", "Saída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxSaida.Focus();
            }*/

            else if (tbxCep.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo 'CEP'", "CEP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxCep.Focus();
            }

            else if (tbxLogradouro.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo 'Logradouro'", "Logradouro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxLogradouro.Focus();
            }

            else if (tbxNumResidencia.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo 'Nº'", "Nº", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxNumResidencia.Focus();
            }

            else if (tbxBairro.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo 'Bairro'", "Bairro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxBairro.Focus();
            }

            else if (   tbxCidade.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo 'Cidade'", "Cidade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxCidade.Focus();
            }

            else if (tbxEstado.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo 'Estado'", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxEstado.Focus();
            }

            else if (tbxCidade.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo 'Cidade'", "Cidade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxCidade.Focus();
            }

            else if (tbxEstado.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo 'Estado'", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxEstado.Focus();
            }

            else if (tbxComplemento.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo 'Complemento'", "Complemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxComplemento.Focus();
            }

            else if (tbxObservacao.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo 'Observações'", "Observações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxObservacao.Focus();
            }

            else
            {// se não for erro semântico, lógico ou de sintaxe
                try // entrada de dados
                {
                    /*int id_funcionario =int.Parse(lblFuncionarioId.Text);
                    string nomeColaborador = tbxNomeColab.Text;
                    string cpfColaborador = tbxCpfColab.Text;
                    string periodo = cbxPeriodo.Text;

                    //string horaEntrada = tbxEntrada.Text; 
                    //horaEntrada = salariotexto.Replace(":", "").Trim();//
                    //DateTime entrada = DateTime.Parse(tbxEntrada.Text); //Se necessário, usar apenas este

                    //string horaSaida = tbxSaida.Text;
                    //horaSaida = horaSaida.ToString();
                    //DateTime saida = DateTime.Parse(tbxSaida.Text);//Se necessário, usar apenas este

                    string whatsApp = tbxWhatsApp.Text;
                    string eMail = tbxEmailColab.Text;
                    string status = cbxStatus.Text; 

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
                    int numResidencia = int.Parse(tbxNumResidencia.Text); //Tratamento de dados aqui? Sql Server == INT
                    string bairro = tbxBairro.Text;
                    string cidade = tbxCidade.Text;
                    string estado = tbxEstado.Text;
                    string complemento = tbxComplemento.Text;*/

                    //string strSql = "update tbl_atendente1 set ds_Login = @login, ds_Senha = @senha, nm_atendente = @nome, ds_status=1 where cd_atendente = @cd";
                    string atualizaFuncionarios = "update funcionarios set nome = @nome, cpf = @cpf, whatsapp = @whatsapp, email = @email, data_contratacao = @dataInicio, status = @status, observacao = @observacao  where id_funcionario = @id_funcionario";
                    string atualizaEnderecos = "update enderecos_funcionarios set cep = @cep, logradouro = @logradouro, numero = @numero, bairro = @bairro, cidade = @cidade, estado = @estado, complemento = @complemento  where id_funcionario = @id_funcionario";
                    string atualizaCargos = "update funcoes set funcao = @funcao where id_funcionario = @id_funcionario";
                    string atualizaPausas = "update pausas set pausa = @pausa, retorno = @retorno where id_funcionario = @id_funcionario";
                    string atualizaPeriodos = "update periodos set periodo = @periodo where id_funcionario = @id_funcionario";
                    string atualizaSalarios = "update salarios set salario = @salario where id_funcionario = @id_funcionario";


                    comando.CommandText = atualizaFuncionarios;
                    comando.CommandText = atualizaEnderecos;
                    comando.CommandText = atualizaCargos;
                    comando.CommandText = atualizaPausas;
                    comando.CommandText = atualizaPeriodos;
                    comando.CommandText = atualizaSalarios;

                    comando.Connection = conexao;

                    //SqlCommand cm = new SqlCommand(sql, cn);

                    //comando.Parameters.Clear();
                   /* comando.Parameters.AddWithValue("@id_funcionario", SqlDbType.Int).Value = id_funcionario;
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
                    //comando.Parameters.AddWithValue("@entrada", SqlDbType.Time).Value = entrada;
                    //comando.Parameters.AddWithValue("@saida", SqlDbType.Time).Value = saida;*/

                    conexao.Open();
                    int linhasAfetadas = comando.ExecuteNonQuery(); // se nenhum registro for afetado (null) , retorna 0

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Os dados foram alterados com sucesso", "Alteração de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    else
                    {
                        MessageBox.Show("Nenhum dado foi alterado!");
                    }
                }

                catch (Exception erro) // lida com as excesssões = no caso, exibe a mensagem de erro e fecha o banco de dados
                {
                    MessageBox.Show(erro.Message);
                    conexao.Close();
                }

                finally //opcional. É executado independentemente da excessão.
                {
                    conexao.Close();
                }
            }
        }

        private void EditarColaborador_Load(object sender, EventArgs e)
        {
            lblFuncionarioId.Text = PagInicial.id_funcionario;
            tbxNomeColab.Text = PagInicial.nomeColab;
            tbxCpfColab.Text = PagInicial.cpfColab;
            tbxWhatsApp.Text = PagInicial.whatsappColab;
            tbxEmailColab.Text = PagInicial.emailColab;
            tbxCargoAtual.Text = PagInicial.cargoColab;
            tbxSalario.Text = PagInicial.salarioColab;
            cbxPeriodo.Text = PagInicial.periodoColab;

            tbxPausas.Text = PagInicial.pausaColab;
            tbxRetorno.Text = PagInicial.retornoColab;
            tbxInicioContrato.Text = PagInicial.inicioContratoColab;
            cbxStatus.Text = PagInicial.statusColab;
            //tbxEntrada.Text = PagInicial.entradaColab;
            //tbxSaida.Text = PagInicial.saidaColab;

            tbxCep.Text = PagInicial.cepColab;
            tbxLogradouro.Text = PagInicial.logradouroColab;
            tbxNumResidencia.Text = PagInicial.numeroColab;
            tbxBairro.Text = PagInicial.bairroColab;
            tbxCidade.Text = PagInicial.cidadeColab;
            tbxEstado.Text = PagInicial.estadoColab;

            tbxComplemento.Text = PagInicial.complementoColab;
            tbxObservacao.Text = PagInicial.observacoesColab;
        }

    }
}
