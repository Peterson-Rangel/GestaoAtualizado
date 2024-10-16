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
    public partial class Avaliacao : Form
    {
        public Avaliacao()
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

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaxi_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalvarAvaliacao_Click(object sender, EventArgs e)
        {
            if (tbxHoraEntrada.Text == string.Empty || tbxHoraSaida.Text == string.Empty
                || tbxHoraPausa.Text == string.Empty || tbxHoraRetorno.Text == string.Empty
                || rtbxComentarios.Text == string.Empty || tbxDataAumento.Text == string.Empty)
            {
                MessageBox.Show("Campos obrigatórios não preenchidos", "Avaliação Colaborador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                try
                {
                    string horaEntrada = tbxHoraEntrada.Text;
                    string horaSaida = tbxHoraSaida.Text;
                    string horaPausa = tbxHoraPausa.Text;
                    string horaRetorno = tbxHoraRetorno.Text;
                    string comentarios = rtbxComentarios.Text;
                    string dataAumento = tbxDataAumento.Text;

                    comando.CommandText = "insert into acompanhamentos(hora_entrada, hora_saida, hora_pausa, hora_retorno,observacao, data_aumento) values(@horaEntrada, @horaSaida, @horaPausa, @horaRetorno, @comentarios, @dataAumento); ";

                    comando.Connection = conexao;
                    comando.Parameters.Clear();

                    comando.Parameters.AddWithValue("@horaEntrada", SqlDbType.Time).Value = horaEntrada;
                    comando.Parameters.AddWithValue("@horaSaida", SqlDbType.Time).Value = horaSaida;
                    comando.Parameters.AddWithValue("@horaPausa", SqlDbType.Time).Value = horaPausa;
                    comando.Parameters.AddWithValue("@horaRetorno", SqlDbType.Time).Value = horaRetorno;
                    comando.Parameters.AddWithValue("@comentarios", SqlDbType.Date).Value = comentarios;
                    comando.Parameters.AddWithValue("@dataAumento", SqlDbType.Date).Value = dataAumento;

                    conexao.Open();

                    int linhasAfetadas = comando.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Avaliaão feita com sucesso!", "Avaliação Colaborador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //PagInicial inicio = new PagInicial();
                        //inicio.Show();
                        //this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Avaliaão não realizada!");
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

        private void pbxIrAcompanhamento_Click(object sender, EventArgs e)
        {
            PagInicial inicio = new PagInicial();
            inicio.Show();
            this.Hide();
        }
            
          private void Avaliacao_Load_1(object sender, EventArgs e)
        {
            tbxHoraEntrada.Text = PagInicial.entradaColab;
            tbxHoraSaida.Text = PagInicial.saidaColab;
            tbxHoraPausa.Text = PagInicial.horaPausaColab;
            tbxHoraRetorno.Text = PagInicial.horaRetornoColab;
            rtbxComentarios.Text = PagInicial.comentariosColab;
            tbxDataAumento.Text = PagInicial.dataAumentoColab;
        }

        //    private void EditarColaborador_Load(object sender, EventArgs e)
        //{
        //    lblFuncionarioId.Text = PagInicial.id_funcionario;
        //    tbxNomeColab.Text = PagInicial.nomeColab;
        //    tbxCpfColab.Text = PagInicial.cpfColab;
        //    tbxWhatsApp.Text = PagInicial.whatsappColab;
        //    tbxEmailColab.Text = PagInicial.emailColab;
        //    tbxCargoAtual.Text = PagInicial.cargoColab;
        //    tbxSalario.Text = PagInicial.salarioColab;
        //    cbxPeriodo.Text = PagInicial.periodoColab;

        //    tbxPausas.Text = PagInicial.pausaColab;
        //    tbxRetorno.Text = PagInicial.retornoColab;
        //    tbxInicioContrato.Text = PagInicial.inicioContratoColab;
        //    cbxStatus.Text = PagInicial.statusColab;
        //    //tbxEntrada.Text = PagInicial.entradaColab;
        //    //tbxSaida.Text = PagInicial.saidaColab;

        //    tbxCep.Text = PagInicial.cepColab;
        //    tbxLogradouro.Text = PagInicial.logradouroColab;
        //    tbxNumResidencia.Text = PagInicial.numeroColab;
        //    tbxBairro.Text = PagInicial.bairroColab;
        //    tbxCidade.Text = PagInicial.cidadeColab;
        //    tbxEstado.Text = PagInicial.estadoColab;

        //    tbxComplemento.Text = PagInicial.complementoColab;
        //    tbxObservacao.Text = PagInicial.observacoesColab;
        //}
    }
}
