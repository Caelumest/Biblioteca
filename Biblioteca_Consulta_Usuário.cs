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

namespace Biblioteca
{
    public partial class Biblioteca_Consulta_Usuário : Form
    {
        //Variável para salvar a linha clicada pelo usuário no DataGridView
        private DataGridViewRow linhaSelecionada;

        public Biblioteca_Consulta_Usuário()
        {
            InitializeComponent();
        }

        //Função que tem como objetivo atualizar o DataGridView após alguma alteração
        public void AtualizarUsuarios()
        {
            using (SqlConnection connection = new SqlConnection(Utilidades.ConnectionString))
            {
                //Roda os comandos buscando algum erro, caso ocorra a aplicação informa o erro ao invés de finalizar a aplicação
                try
                {
                    //Abre a conexão com o banco de dados com as configurações especificadas
                    connection.Open();
                    //Insere o comando desejado na query
                    SqlDataAdapter cmd = new SqlDataAdapter("Select * from Usuarios", connection);
                    //Chama a função para criar uma nova DataTable com as informações adquiridas
                    CriarNovaDataTable(cmd);

                    //Fecha a conexão com o banco de dados
                    connection.Close();
                }
                catch (Exception es)
                {
                    //Mostra na tela o erro captado caso haja algum
                    MessageBox.Show(es.Message);
                }
            }
        }
        private void Biblioteca_Consulta_Usuário_Load(object sender, EventArgs e)
        {
            AtualizarUsuarios();
        }
        //Função chamada após o usuario clicar no botão de exclusão
        private void button1_Click(object sender, EventArgs e)
        {
            //Caso nenhuma linha do DataGridView estiver selecionada, retorna uma mensagem informando o usuário
            if (linhaSelecionada != null)
            {
                //Pede uma confirmação para evitar exclusões acidentais
                if (MessageBox.Show("Tem certeza que deseja excluir esse usuário?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(Utilidades.ConnectionString))
                        {
                            //Comando para deletar o usuário clicado utilizando a linha clicada para obter o seu id
                            string query = "DELETE FROM Usuarios WHERE id_usuario =" + linhaSelecionada.Cells[0].Value;
                            SqlCommand cmd = new SqlCommand(query, connection);
                            connection.Open();
                            //Executa o comando delete
                            cmd.ExecuteNonQuery();
                            //Atualiza os usuarios do DataGridView mostrando as alterações
                            AtualizarUsuarios();
                            //Declara como nula linha selecionada, pois ela não existe mais
                            linhaSelecionada = null;
                            //Informa ao usuário que foi bem sucedida a exclusão
                            MessageBox.Show("Usuário excluído com sucesso!");
                            connection.Close();
                        }
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.Message);
                    }
                }
            }
            else
                //Mensagem retornada caso nenhuma linha esteja selecionada
                MessageBox.Show("Nenhum usuário selecionado.");
        }

        //Função chamada após clique em alguma das células do DataGridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Salva index e a linha clicado pelo usuário
            int indexSelecionado = e.RowIndex;
            linhaSelecionada = dataGridView1.Rows[indexSelecionado];
        }

        //Função para abrir uma nova tela de inclusão de usuário
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (linhaSelecionada != null)
            {
                if (!Utilidades.cadastroUsuario.IsHandleCreated)
                {
                    //Declara uma nova instancia de cadastro de usuário
                    Utilidades.cadastroUsuario = new Biblioteca_Cadastrar_Usuario();
                    //Abre a janela de inclusão de usuários
                    Utilidades.cadastroUsuario.Show();
                    MessageBox.Show("AAA");
                }
                else
                {
                    Utilidades.cadastroUsuario.Focus();
                    MessageBox.Show("AAssssA");
                }
                try
                {
                    using (SqlConnection connection = new SqlConnection(Utilidades.ConnectionString))
                    {
                        //Comando para pegar todas as informações dos usuários da linha selecionada
                        string query = "SELECT * FROM Usuarios where id_usuario =" + linhaSelecionada.Cells[0].Value;
                        SqlCommand cmd = new SqlCommand(query, connection);
                        connection.Open();
                        //Executa um novo comando de leitura
                        using (SqlDataReader livros = cmd.ExecuteReader())
                        {
                            //Lê o registro do banco
                            livros.Read();
                            //Altera as informações da box de inclusão para uma alteração mais dinâmica e fácil

                            Utilidades.cadastroUsuario.LoginBox.Text = livros["login_usuario"].ToString();
                            Utilidades.cadastroUsuario.SenhaBox.Text = livros["senha_usuario"].ToString();
                            Utilidades.cadastroUsuario.ConfirmarSenhaBox.Text = livros["senha_usuario"].ToString();
                            Utilidades.cadastroUsuario.EmailBox.Text = livros["email_usuario"].ToString();
                            Utilidades.cadastroUsuario.NomeBox.Text = livros["nome_usuario"].ToString();
                            Utilidades.cadastroUsuario.EnderecoBox.Text = livros["endereco_usuario"].ToString();
                            Utilidades.cadastroUsuario.CpfBox.Text = livros["cpf_usuario"].ToString();
                            Utilidades.cadastroUsuario.TelefoneBox.Text = livros["telefone_usuario"].ToString();
                            //Salva o id do usuário na janela para alteração segura
                            Utilidades.cadastroUsuario.Tag = livros["id_usuario"].ToString();
                            //Converte o nível de poder do usuário de número para string conforme seu nível
                            string poder = Convert.ToInt32(livros["poder_usuario"]) == 0 ? "Usuário" : Convert.ToInt32(livros["poder_usuario"]) == 1 ? "Administrador" : "Usuário";
                            Utilidades.cadastroUsuario.PoderDropdown.Text = poder;
                            //Declara que uma alteração de usuários está sendo feita
                            Utilidades.alterandoUsuarios = true;
                        }
                        connection.Close();
                    }
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada");
            }
        }
        //Função para busca no banco sempre que o textbox reconhecer um novo caractere
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Caso a caixa de texto estiver vazia ele retorna todos os dados, senão, faz a busca
            if (boxConsulta.Text != string.Empty)
            {
                using (SqlConnection connection = new SqlConnection(Utilidades.ConnectionString))
                {
                    //Cria uma variável que busca o que foi digitado nos campos desejados da tabela
                    string query = "select * from Usuarios where (login_usuario like @texto_consulta or email_usuario like @texto_consulta or nome_usuario like @texto_consulta " +
                        "or telefone_usuario like @texto_consulta or cpf_usuario like @texto_consulta or endereco_usuario like @texto_consulta)";

                    SqlDataAdapter cmd = new SqlDataAdapter(query, connection);
                    //Muda o valor passado na query utilizando % para indicar que a busca pode retornar qualquer combinação de caracteres em qualquer posição
                    cmd.SelectCommand.Parameters.AddWithValue("@texto_consulta", "%" + boxConsulta.Text.ToString() + "%");
                    connection.Open();
                    //Cria uma nova datatable com as informações passadas
                    CriarNovaDataTable(cmd);

                    connection.Close();
                }
            }
            else
                //Atualiza a Grid de usuários
                AtualizarUsuarios();
        }

        private void CriarNovaDataTable(SqlDataAdapter cmd)
        {
            //Declara uma nova DataTable
            DataTable dtbl = new DataTable();
            //Insere na DataTable as linhas retornadas pelo comando na query
            cmd.Fill(dtbl);

            //Preenche o DataGridView com as informações obtidas do banco de dados removendo a seleção e declarando que é somente para leitura
            dataGridView1.DataSource = dtbl;
            dataGridView1.ClearSelection();
            dataGridView1.ReadOnly = true;
        }

    }
}
