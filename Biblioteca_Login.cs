using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Biblioteca_Login : Form
    {
        public Biblioteca_Login()
        {
            InitializeComponent();
        }
        
        //Chama a função que verifica se existe o usuário no sistema
        private void EntrarNoSistema()
        {
            //Caso algum campo estiver vazio, informa ao usuário para preencher
            if (nomeUsuarioBox.Text == string.Empty || senhaUsuarioBox.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos corretamente");
                return;
            }

            using (SqlConnection connection = new SqlConnection(Utilidades.ConnectionString))
            {
                //Comando para buscar todos os usuários do banco com seu login e senha
                string query = "SELECT id_usuario, login_usuario, senha_usuario, nome_usuario FROM Usuarios WHERE login_usuario= @login_usuario and senha_usuario = @senha_usuario";
                SqlCommand cmd = new SqlCommand(query, connection);
                //Modifica o comando com as informações passadas
                cmd.Parameters.AddWithValue("@login_usuario", nomeUsuarioBox.Text);
                cmd.Parameters.AddWithValue("@senha_usuario",Utilidades.encriptarSenha(senhaUsuarioBox.Text));
                try
                {
                    connection.Open();
                    using (SqlDataReader usuarios = cmd.ExecuteReader())
                    {
                        //Verifica se alguma linha foi retornada com o comando, caso tenha sido, ele entra com o usuário
                        if (usuarios.HasRows)
                        {
                            usuarios.Read();
                            //Esconde a tela de login
                            Hide();
                            //Declara uma nova tela principal
                            Biblioteca_Principal bp = new Biblioteca_Principal();
                            //Define a mensagem da tela principal com o nome do usuario
                            bp.LabelBemVindo.Text = "Bem vindo " + usuarios["nome_usuario"].ToString() + "!";
                            //Salva o id para saber qual usuário está logado
                            bp.IdUsuario((int)usuarios["id_usuario"]);
                            //Define a tela como principal
                            bp.ShowDialog();
                            //Fecha a janela de login
                            Close();
                        }
                        else
                            MessageBox.Show("Usuário e/ou senha incorretos");
                    }
                    connection.Close();
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
        }
        //Função ao clicar no botao cancelar, automaticamente fecha a janela
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Função para tentativa de login
        private void button1_Click(object sender, EventArgs e)
        {
            EntrarNoSistema();
        }
        //Função para reconhecer o botão desejado e executar o comando passado
        private void loginWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                EntrarNoSistema();
            }
        }
    }
}
