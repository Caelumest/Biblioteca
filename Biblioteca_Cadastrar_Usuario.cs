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
using System.Security.Cryptography;
using System.IO;

namespace Biblioteca
{
    public partial class Biblioteca_Cadastrar_Usuario : Form
    {
        public TextBox NomeBox => nomeUsuarioBox;
        public TextBox LoginBox => loginUsuarioBox;
        public TextBox EmailBox => emailUsuarioBox;
        public TextBox EnderecoBox => enderecoUsuarioBox;
        public TextBox CpfBox => cpfUsuarioBox;
        public TextBox TelefoneBox => telefoneUsuarioBox;
        public ComboBox PoderDropdown => poderUsuarioBox;
        public TextBox SenhaBox => senhaUsuarioBox;
        public TextBox ConfirmarSenhaBox => confirmarSenhaBox;
        public static Biblioteca_Principal bibliotecaPincipal => Application.OpenForms["Biblioteca_Cadastrar_Usuario"] as Biblioteca_Principal;
        public Biblioteca_Cadastrar_Usuario()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

            //Checa se algum campo não está preenchido
            if (loginUsuarioBox.Text != string.Empty && senhaUsuarioBox.Text != string.Empty && nomeUsuarioBox.Text != string.Empty && enderecoUsuarioBox.Text != string.Empty && cpfUsuarioBox.Text != string.Empty && poderUsuarioBox.Text != string.Empty) {
                //Checa se a senha e a confirmação de senha são iguais
                if (senhaUsuarioBox.Text == confirmarSenhaBox.Text)
                {
                    //Linha de comando para inserir os dados no banco
                    string query = !Utilidades.alterandoUsuarios ?
                        "insert into Usuarios values(@login_usuario, @senha_usuario, @email_usuario, @nome_usuario, @endereco_usuario, @cpf_usuario, @telefone_usuario, @poder_usuario)" :
                        "update Usuarios set login_usuario = @login_usuario,senha_usuario= @senha_usuario,email_usuario= @email_usuario,nome_usuario= @nome_usuario,endereco_usuario= @endereco_usuario,cpf_usuario= @cpf_usuario,telefone_usuario= @telefone_usuario, poder_usuario = @poder_usuario from Usuarios where id_usuario = " + Convert.ToInt32(Tag);
                    using (SqlConnection connection = new SqlConnection(Utilidades.ConnectionString))
                    {
                        //Roda os comandos buscando algum erro, caso ocorra a aplicação informa o erro ao invés de finalizar a aplicação
                        try
                        {
                            //Abre a conexão com o banco de dados com as configurações especificadas
                            connection.Open();
                            //Insere o comando desejado na query
                            SqlCommand cmd = new SqlCommand(query, connection);

                            //Modifica os valores da query para os valores captados na tela de inclusão de livros
                            cmd.Parameters.AddWithValue("@login_usuario", loginUsuarioBox.Text);
                            //Encripta a senha do usuario chamando a funcao encriptar
                            cmd.Parameters.AddWithValue("@senha_usuario", Utilidades.encriptarSenha(senhaUsuarioBox.Text.ToString()));
                            cmd.Parameters.AddWithValue("@email_usuario", emailUsuarioBox.Text);
                            cmd.Parameters.AddWithValue("@nome_usuario", nomeUsuarioBox.Text);
                            cmd.Parameters.AddWithValue("@endereco_usuario", enderecoUsuarioBox.Text);
                            cmd.Parameters.AddWithValue("@cpf_usuario", cpfUsuarioBox.Text);
                            cmd.Parameters.AddWithValue("@telefone_usuario", telefoneUsuarioBox.Text);
                            int poder = poderUsuarioBox.Text == "Usuário" ? 0 : poderUsuarioBox.Text == "Administrador" ? 1 : 0;
                            cmd.Parameters.AddWithValue("@poder_usuario", poder);

                            //Executa a instrução desejada na query
                            cmd.ExecuteNonQuery();

                            //Exibe uma mensagem de sucesso para o usuário saber que não houve erros
                            string mensagem = Utilidades.alterandoUsuarios ? "Alterado com sucesso!" : "Salvo com sucesso!";
                            if (Utilidades.bibliotecaConsultaUsuario != null)
                                Utilidades.bibliotecaConsultaUsuario.AtualizarUsuarios();
                            MessageBox.Show(mensagem);

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
                else
                    MessageBox.Show("As senhas devem ser iguais");
            }
            else
                MessageBox.Show("Todos os campos obrigatórios precisam ser preenchidos");
        }

        private void cancelarBotao_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Biblioteca_Cadastrar_Usuario_Load(object sender, EventArgs e)
        {
            poderUsuarioBox.Text = "Usuário";
        }

        private void cpfUsuarioBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se o digito é um numero, caso nao seja, nao permite o usuario digitar
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void telefoneUsuarioBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
