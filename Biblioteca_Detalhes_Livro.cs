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
    public partial class Biblioteca_Detalhes_Livro : Form
    {
        public Biblioteca_Detalhes_Livro()
        {
            InitializeComponent();
        }

        //Cria variáveis para acessar as propriedades privadas citadas fora da classe
        public Label TituloLivro => tituloLivroDetalhes;
        public Label AutoresLivro => autoresLivroDetalhes;
        public Label EditoraLivro => editoraLivroDetalhes;
        public Label SinopseLivro => sinopseLivroDetalhes;
        public Label IsbnLivro => isbnLivroDetalhes;
        public Label DtPublicacaoLivro => dtPublicacaoLivroDetalhes;
        public PictureBox CapaLivro => capaLivroDetalhes;
        public PictureBox BotaoExcluir => excluirDetalhesLivro;
        public PictureBox BotaoAlterar => alterarDetalhesBotao;

        //Função chamada pelo botão de exclusão após ser clicado
        private void excluirDetalhesLivro_Click(object sender, EventArgs e)
        {
            //Cria uma caixa de texto para o usuário confirmar a ação caso tenha clicado errado
            if (MessageBox.Show("Tem certeza que deseja apagar esse livro?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Executa o código de forma segura informando o usuário caso haja algum erro específico no código
                try
                {
                    //Acessa o banco de dados e executa o comando DELETE para excluir a opção selecionada
                    using (SqlConnection connection = new SqlConnection(Utilidades.ConnectionString))
                    {
                        string query = "DELETE FROM Livros WHERE id_livro =" + Convert.ToInt32(this.Tag);
                        SqlCommand cmd = new SqlCommand(query, connection);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                //Mostra o erro específico caso haja algum
                catch(Exception es)
                {
                    MessageBox.Show(es.Message);
                }
                //Executa a função PopularLivros para atualizar os livros na tela, com false para especificar que não é uma busca
                Utilidades.bibliotecaPincipal.PopularLivros(false);
                //Fecha a janela de detalhe dos livros após a exclusão
                Close();
            }
        }
        //Função chamada pelo botão de alteração após ser clicado
        private void alterarDetalhesBotao_Click(object sender, EventArgs e)
        {
            //Declara uma nova instancia da classe para executar suas funções
            Biblioteca_Livros insereLivro = new Biblioteca_Livros();
            //Abre uma nova instancia da janela de inserção de livros
            insereLivro.Show();
            //Declara uma nova conexão com o banco de dados especificado pela ConnectionString
            using (SqlConnection connection = new SqlConnection(Utilidades.ConnectionString))
            {
                //Declara o comando que será enviado ao banco de dados para buscar as informações do livro especificado
                string query = "SELECT * FROM Livros where id_livro =" + Convert.ToInt32(Tag);
                //Procedimento para execução no banco de dados
                SqlCommand cmd = new SqlCommand(query, connection);
                //Abre a conexão com o banco
                connection.Open();
                //Executa o comando de leitura
                using (SqlDataReader livros = cmd.ExecuteReader())
                {
                    //Passa para o próximo registro do banco
                    livros.Read();

                    //Modifica as caixas de texto da área de inserção de livros para uma a atualização mais dinâmica do usuário
                    insereLivro.TituloBox.Text = livros["titulo_livro"].ToString();
                    insereLivro.AutorBox.Text = livros["autor_livro"].ToString();
                    insereLivro.SinopseBox.Text = livros["texto_livro"].ToString();
                    insereLivro.IsbnBox.Text = livros["isbn_livro"].ToString();
                    insereLivro.EditoraBox.Text = livros["editora_livro"].ToString();
                    //Salva o id do livro para a alteração utilizando o id do livro clicado 
                    insereLivro.Tag = livros["id_livro"].ToString();
                    //Converte a informação recebida para o formao DateTime especificando a forma de data desejada
                    insereLivro.DataBox.Text = Convert.ToDateTime(livros["dt_publicacao_livro"]).ToString("MM/dd/yyyy"); 
                    //Converte a imagem em byte para ser salva em varbinary no banco de dados
                    insereLivro.ImagemCapa.Image = Utilidades.ConvertToImage(livros["imagem_capa_livro"] as byte[]);
                    //Declara que está ocorrendo uma alteração em algum livro para melhor controle
                    Utilidades.alterandoLivros = true;
                }
                //Fecha a conexão com o banco
                connection.Close();
            }
        }
        //Fecha a janela ao clicar na seta
        private void voltarDetalhesBotao_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Biblioteca_Detalhes_Livro_Load(object sender, EventArgs e)
        {
            if (Utilidades.bibliotecaPincipal.ChecarPoder() == 0)
            {
                excluirDetalhesLivro.Dispose();
                alterarDetalhesBotao.Dispose();
            }
        }
    }
}
