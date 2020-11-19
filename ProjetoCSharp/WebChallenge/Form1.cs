using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace WebChallenge
{
    public partial class Form1 : Form
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataAdapter da;
        string strSQL;

        public Form1()
        {
            InitializeComponent();
        }

        //Função do botão Salvar
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Criando a conexão com o banco de dados.
                connection = new MySqlConnection("Server=localhost;Database=banco_tarefas;Uid=root;Pwd=1234");

                //Comando SQL para inserir dados na tabela Tarefas.
                strSQL = "INSERT INTO TAREFAS (DATA, DESCRICAO, PRIORIDADE, OBSERVACOES, STATUS) VALUES (@DATA, @DESCRICAO, " +
                    "@PRIORIDADE, @OBSERVACOES, @STATUS)";

                //Criando o comando que executa a instrução SQL.
                command = new MySqlCommand(strSQL, connection);
                command.Parameters.AddWithValue("@DATA", textBoxData.Text);
                command.Parameters.AddWithValue("@DESCRICAO", textBoxDescription.Text);
                command.Parameters.AddWithValue("@PRIORIDADE", comboBoxPriority.Text);
                command.Parameters.AddWithValue("@OBSERVACOES", textBoxComments.Text);
                command.Parameters.AddWithValue("@STATUS", comboBoxStatus.Text);

                //Abre a conexão com o banco.
                connection.Open();

                command.ExecuteNonQuery();//Executa a instrunção.
                MessageBox.Show("Salvo com sucesso");//Mensagem para confirmar que foi Cadastrado.
                this.Clear();//Instancia da função para Limpar.
                GridFill();//Listar.

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//Mensagem.Show("Não encontrado").
            }
        }

        //GridFill para Listar.
        void GridFill()
        {

            try
            {
                //Criando a conexão com o banco de dados.
                connection = new MySqlConnection("Server=localhost;Database=banco_tarefas;Uid=root;Pwd=1234");

                //Comando SQL para selecionar todos os dados da tabela Tarefas.
                strSQL = "SELECT * FROM TAREFAS";

                //Criando o comando que executa a instrução SQL.
                da = new MySqlDataAdapter(strSQL, connection);

                DataTable dt = new DataTable();

                da.Fill(dt);//Listando os dados.

                dataGridView.DataSource = dt;//Listando os dados no GridView.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//Mensagem.Show("Não encontrado").
            }
            finally
            {
                connection.Close();//Fecha conexão com o banco.
                connection = null;//Valor nulo.
                command = null;//Valor nulo.
            }
        }

        //Função para Limpar campos.
        public void Clear()
        {
            textBoxID.Clear();
            textBoxData.Clear();
            textBoxDescription.Clear();
            comboBoxPriority.SelectedIndex = -1;
            textBoxComments.Clear();
            comboBoxStatus.SelectedIndex = -1;
        }

        //Função do Form que esta recebendo os comboBox e o Limpar e Listar. 
        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();//Limpar todo o Grid.
            GridFill();//Listar no GridView quando iniciar o projeto.
            //..
            //Valores do ComboBox.
            string[] box01 = new string[]
            {
                "BAIXA",
                "MÉDIA",
                "ALTA"
            };
            comboBoxPriority.Items.AddRange(box01);
            string[] box02 = new string[]
            {
                "PENDENTE",
                "FINALIZADO"
            };
            comboBoxStatus.Items.AddRange(box02);
        }

        //Função para Editar dados da tabela.
        private void buttonToEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //Criando a conexão com o banco de dados.
                connection = new MySqlConnection("Server=localhost;Database=banco_tarefas;Uid=root;Pwd=1234");

                //Comando SQL para Atualizar todos os dados da tabela Tarefas.
                strSQL = "UPDATE TAREFAS SET DATA = @DATA, DESCRICAO = @DESCRICAO, PRIORIDADE = @PRIORIDADE, " +
                    "OBSERVACOES = @OBSERVACOES, STATUS = @STATUS WHERE ID = @ID";

                //Criando o comando que executa a instrução SQL.
                command = new MySqlCommand(strSQL, connection);
                command.Parameters.AddWithValue("@ID", textBoxID.Text);
                command.Parameters.AddWithValue("@DATA", textBoxData.Text);
                command.Parameters.AddWithValue("@DESCRICAO", textBoxDescription.Text);
                command.Parameters.AddWithValue("@PRIORIDADE", comboBoxPriority.Text);
                command.Parameters.AddWithValue("@OBSERVACOES", textBoxComments.Text);
                command.Parameters.AddWithValue("@STATUS", comboBoxStatus.Text);

                connection.Open();//Abre a conexão com o banco.

                command.ExecuteNonQuery();//Executa a instrunção.
                MessageBox.Show("Editado com sucesso");//Mensagem para confirma que foi Editado.
                this.Clear();//Instancia da função para Limpar.
                GridFill();//Listar.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//Mensagem.Show("Não encontrado").
            }
        }

        //Função para Excluir dados da tabela.
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //Criando a conexão com o banco de dados.
                connection = new MySqlConnection("Server=localhost;Database=banco_tarefas;Uid=root;Pwd=1234");

                //Comando SQL para Excluir todos os dados da tabela Tarefas.
                strSQL = "DELETE FROM TAREFAS WHERE ID = @ID";

                //Criando o comando que executa a instrução SQL.
                command = new MySqlCommand(strSQL, connection);
                command.Parameters.AddWithValue("@ID", textBoxID.Text);


                connection.Open();//Abre a conexão com o banco.

                command.ExecuteNonQuery();//Executa a instrunção.
                MessageBox.Show("Excluido com sucesso");//Mensagem para confirmar que foi Excluido.
                this.Clear();//Instancia da função para Limpar.
                GridFill();//Listar.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//Mensagem.Show("Não encontrado").
            }
        }
    }
 }