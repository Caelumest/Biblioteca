using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca
{
    internal static class Utilidades
    {
        //Chave para decriptar senhas
        private static string _chave = "MIYDOR938GTSQAF";
        public static string ChaveDecriptadora => _chave;
        //Declara a string de conexão do banco de dados
        private static string _connection = @"Data Source=(localdb)\MSSQLLocalDB; Integrated Security=True;AttachDbFileName=S:\Users\leona\source\repos\Biblioteca\Biblioteca\Biblioteca.mdf";
        public static string ConnectionString => _connection;
        //Variáveis para o controle de alteração
        public static bool alterandoUsuarios = false;
        public static bool alterandoLivros = false;
        //Busca uma janela principal/consulta de usuários que esteja aberta para controle da aplicação
        public static Biblioteca_Consulta_Usuário bibliotecaConsultaUsuario => Application.OpenForms["Biblioteca_Consulta_Usuário"] as Biblioteca_Consulta_Usuário;
        public static Biblioteca_Principal bibliotecaPincipal => Application.OpenForms["Biblioteca_Principal"] as Biblioteca_Principal;
        public static Biblioteca_Detalhes_Livro bibliotecaDetalhes => Application.OpenForms["Biblioteca_Detalhes_Livro"] as Biblioteca_Detalhes_Livro;
        public static Biblioteca_Cadastrar_Usuario cadastroUsuario = new Biblioteca_Cadastrar_Usuario();
        public static string encriptarSenha(string senha) => Encriptar(senha);
        //Função para encriptar a senha do usuário
        private static string Encriptar(string senha)
        {
            string chave = Utilidades.ChaveDecriptadora;
            byte[] bytes = Encoding.Unicode.GetBytes(senha);
            using (Aes encryptador = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(chave, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptador.Key = pdb.GetBytes(32);
                encryptador.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptador.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytes, 0, bytes.Length);
                        cs.Close();
                    }
                    senha = Convert.ToBase64String(ms.ToArray());
                }
            }
            return senha;
        }

        //Função para decriptar a senha do usuario
        private static string Decriptar(string senha)
        {
            string chave = Utilidades.ChaveDecriptadora;
            byte[] bytes = Convert.FromBase64String(senha);
            using (Aes encryptador = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(chave, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptador.Key = pdb.GetBytes(32);
                encryptador.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptador.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytes, 0, bytes.Length);
                        cs.Close();
                    }
                    senha = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return senha;
        }

        //Função para converter um conjunto byte para imagem
        public static Image ConvertToImage(byte[] binary)
        {
            return Image.FromStream(new MemoryStream(binary));
        }
    }
}