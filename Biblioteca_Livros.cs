using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Biblioteca_Livros : Form
    {
        //Declaração para acessar os controles fora da classe
        public TextBox TituloBox => tituloBox;
        public TextBox AutorBox => autorBox;
        public TextBox EditoraBox => editoraBox;
        public TextBox IsbnBox => isbnBox;
        public TextBox ImagemBox => imagemBox;
        public RichTextBox SinopseBox => sinopseBox;
        public DateTimePicker DataBox => dateBoxLivro;
        public PictureBox ImagemCapa => imagemCapa;
        
        public Biblioteca_Livros()
        {
            InitializeComponent();
        }
        //Botão responsável para selecionar a imagem da capa de livro na inclusão
        private void button1_Click(object sender, EventArgs e)
        {
            //Declara um novo OpenFileDialog para buscar o arquivo desejado
            OpenFileDialog open = new OpenFileDialog();
            //Declara os tipos de arquivos aceitos para imagem
            open.Filter = "Image Files:(*.jpg; *.png; *.jpeg; *.bmp; *.gif;)|*.jpg; *.png; *.jpeg; *.bmp; *.gif;";
            //Ao selecionar o arquivo, retorna o caminho e define a imagem na tela
            if(open.ShowDialog() == DialogResult.OK)
            {
                imagemBox.Text = open.FileName;
                imagemCapa.Image = new Bitmap(open.FileName);
            }
        }
        //Função após clicar no botão salvar
        private void button2_Click(object sender, EventArgs e)
        {
            //Checa se algum campo obrigatório está vazio
            if (tituloBox.Text != string.Empty && isbnBox.Text != string.Empty && imagemBox.Text != string.Empty && editoraBox.Text != string.Empty && autorBox.Text != string.Empty && dateBoxLivro.Value != null)
            {
                SqlConnection connection = new SqlConnection(Utilidades.ConnectionString);
                SqlCommand cmd;
                //Linha de comando para inserir os dados no banco variando caso seja uma alteração
                string query = !Utilidades.alterandoLivros ?
                    "insert into Livros values(@imagem_capa_livro, @titulo_livro, @isbn_livro, @editora_livro, @autor_livro, @texto_livro, @dt_publicacao_livro)" :
                    "update Livros set imagem_capa_livro = @imagem_capa_livro,titulo_livro= @titulo_livro,isbn_livro= @isbn_livro,editora_livro= @editora_livro,autor_livro= @autor_livro,texto_livro= @texto_livro,dt_publicacao_livro= @dt_publicacao_livro from Livros where id_livro = " + Convert.ToInt32(Tag);

                //Roda os comandos buscando algum erro, caso ocorra a aplicação informa o erro ao invés de finalizar a aplicação
                try
                {
                    //Abre a conexão com o banco de dados com as configurações especificadas
                    connection.Open();

                    //Converte o arquivo de imagem para byte
                    byte[] buffer = File.ReadAllBytes(imagemBox.Text);

                    //Insere o comando desejado na query
                    cmd = new SqlCommand(query, connection);

                    //Modifica os valores da query para os valores captados na tela de inclusão de livros
                    cmd.Parameters.AddWithValue("@imagem_capa_livro", buffer);
                    cmd.Parameters.AddWithValue("@titulo_livro", tituloBox.Text);
                    cmd.Parameters.AddWithValue("@isbn_livro", isbnBox.Text.ToString());
                    cmd.Parameters.AddWithValue("@editora_livro", editoraBox.Text.ToString());
                    cmd.Parameters.AddWithValue("@autor_livro", autorBox.Text.ToString());
                    cmd.Parameters.AddWithValue("@texto_livro", sinopseBox.Text.ToString());
                    cmd.Parameters.AddWithValue("@dt_publicacao_livro", dateBoxLivro.Value.ToString("MM/dd/yyyy"));

                    //Executa a instrução desejada na query
                    cmd.ExecuteNonQuery();

                    //Exibe uma mensagem de sucesso para o usuário saber que não houve erros
                    string mensagem = Utilidades.alterandoLivros ? "Alterado com sucesso!" : "Salvo com sucesso!";
                    MessageBox.Show(mensagem);
                    if (Utilidades.bibliotecaDetalhes.IsHandleCreated && Utilidades.alterandoLivros)
                        Utilidades.bibliotecaDetalhes.Close();
                    //Fecha a conexão com o banco de dados
                    connection.Close();

                    Utilidades.bibliotecaPincipal.PopularLivros(false);
                }
                catch (Exception es)
                {
                    //Mostra na tela o erro captado caso haja algum
                    MessageBox.Show(es.Message);
                }
            }
            else
                MessageBox.Show("Todos os campos obrigatoriós devem ser preenchidos");
        }
        //Chamado ao clicar o botão cancelar, fechando a janela
        private void cancelarBotao_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void isbnBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
