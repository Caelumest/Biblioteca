using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Biblioteca
{
    public partial class Biblioteca_Principal : Form
    {
        //Variável de controle para saber qual usuário está logado
        private int _idUsuario;
        public int IdUsuario(int valor) => _idUsuario = valor;
        //Variáveis para controle do numero de páginas e página atual da aplicação
        private int totalPaginas;
        private int paginaAtual = 1;
        //Declara a label para que possa ser acessada fora da classe
        public Label LabelBemVindo => bemVindoLabel;
        //Declara novas instancias das janelas chamadas
        private Biblioteca_Detalhes_Livro bibliotecaDetalhes = new Biblioteca_Detalhes_Livro();
        private Biblioteca_Livros incluirLivro = new Biblioteca_Livros();
        private Biblioteca_Cadastrar_Usuario cadastroUsuario = new Biblioteca_Cadastrar_Usuario();
        private Biblioteca_Consulta_Usuário consultaUsuario = new Biblioteca_Consulta_Usuário();

        public Biblioteca_Principal()
        {
            InitializeComponent();
        }
        //Comando para obter o nivel de acesso do usuario
        public int ChecarPoder()
        {
            int poder = 0;
            using (SqlConnection connection = new SqlConnection(Utilidades.ConnectionString))
            {
                //Comando para obter privilegios do usuario
                string query = "SELECT poder_usuario FROM Usuarios where id_usuario = @id_usuario";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id_usuario", _idUsuario);
                connection.Open();
                using (SqlDataReader usuarios = cmd.ExecuteReader())
                {
                    //Executa o comando e obtem as informações do livro clicado
                    usuarios.Read();
                    poder = Convert.ToInt16(usuarios["poder_usuario"]);
                }
                connection.Close();
            }
            return poder;
        }
        //Função para obter o numero de linhas que existem no banco de dados
        private int GetRowCount()
        {
            //String com o comando a ser executado no banco
            string query = "SELECT COUNT(1) FROM Livros";
            //Declara uma conexão com o banco passando a ConnectionString desejada
            using (SqlConnection connection = new SqlConnection(Utilidades.ConnectionString))
            {
                //Comandos para execução e abertura do banco de dados
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                //Executa o comando passado
                cmd.ExecuteNonQuery();
                //Retorna a primeira linha da primeira coluna com o total de linhas
                int total = Convert.ToInt32(cmd.ExecuteScalar());
                //Libera os recursos do comando
                cmd.Dispose();
                //Fecha a conexão com o banco
                connection.Close();
                //Retorna o total de linhas como resultado
                return total;
            }
        }
        //Comando chamado assim que a janela é criada
        private void Biblioteca_Principal_Load(object sender, EventArgs e)
        {
            //Atualiza a tela com os livros salvos do banco
            PopularLivros(false);
            //Checa ao carregar se o usuario tem poder suficiente para utilizar serviços
            if(ChecarPoder() == 0)
            {
                livrosToolStripMenuItem.Dispose();
                usuariosToolStripMenuItem.Dispose();
            }
            //Limita a data máxima para o dia atual
            buscaData1.MaxDate = DateTime.Now;
            buscaData2.MaxDate = DateTime.Now;
        }
        //Função chamada após clique no item de inserção de livros do menu
        private void inserirLivroToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            //Checa se alguma outra janela de inclusão já está aberta, caso esteja ele trás para frente, caso não ele cria uma
            if (!incluirLivro.IsHandleCreated)
            {
                incluirLivro = new Biblioteca_Livros();
                incluirLivro.Show();
            }
            else
                incluirLivro.Focus();
            //Declara que não está ocorrendo mais uma alteração de livros
            Utilidades.alterandoLivros = false;
        }

        private void painel_Click(object sender, EventArgs e)
        {
            //Obtem o item que está sendo clicado
            Control cont = (Control)sender;
            //Checa se alguma janela de detalhes já existe, caso exista apenas altera as informações
            if (!bibliotecaDetalhes.IsHandleCreated)
            {
                bibliotecaDetalhes = new Biblioteca_Detalhes_Livro();
                bibliotecaDetalhes.Show();
            }
            else
                bibliotecaDetalhes.Focus();

            using (SqlConnection connection = new SqlConnection(Utilidades.ConnectionString))
            {
                //Comando para obter os detalhes do livro
                string query = "SELECT * FROM Livros where id_livro =" + Convert.ToInt32(cont.Tag);
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader livros = cmd.ExecuteReader())
                {
                    //Executa o comando e obtem as informações do livro clicado
                    livros.Read();
                    bibliotecaDetalhes.TituloLivro.Text = livros["titulo_livro"].ToString();
                    bibliotecaDetalhes.AutoresLivro.Text = "por " + livros["autor_livro"].ToString();
                    bibliotecaDetalhes.SinopseLivro.Text = "Sinópse: " + livros["texto_livro"].ToString();
                    bibliotecaDetalhes.IsbnLivro.Text = "ISBN: " + livros["isbn_livro"].ToString();
                    bibliotecaDetalhes.EditoraLivro.Text = "Editora: " + livros["editora_livro"].ToString();
                    bibliotecaDetalhes.DtPublicacaoLivro.Text = "Publicação: "+ Convert.ToDateTime(livros["dt_publicacao_livro"]).ToShortDateString();
                    //Converte de byte para imagem o campo especificado para exibir na imagem de capa do livro
                    bibliotecaDetalhes.CapaLivro.Image = Utilidades.ConvertToImage(livros["imagem_capa_livro"] as byte[]);
                    //Obtem o id do livro salvo na tag do item clicado e passa para a janela de detalhes
                    bibliotecaDetalhes.Tag = cont.Tag;
                }
                connection.Close();
            }
        }
        private bool buscandoPorData = false;
        public void PopularLivros(bool buscando)
        {
            int lastId = 0;
                //Declara o máximo de livros que podem ser exibidos em uma página
                int itensMaximos = 35;
            //Chama a função para obter o número de linhas existentes no banco de dados
            int totalLivros = GetRowCount();
            //A linha na qual começará a busca do banco de dados
            int itemInicial = 1;
            //Executa um cálculo para saber o número de páginas de acordo com o número de itens no banco e o máximo de itens por pagina
            float paginas = (float)totalLivros / (float)itensMaximos;
            totalPaginas = paginas > (int)paginas ? (int)paginas + 1 : (int)paginas;
            //Caso o total de livros no banco de dados seja maior que o máximo de itens exibidos o valor passa a ser o máximo de itens
            if (totalLivros > itensMaximos)
                totalLivros = itensMaximos;
            //Muda a label para informar a página e quantas páginas existem
            if(totalPaginas == 0) totalPaginas = 1;
            paginasLabel.Text = paginaAtual.ToString() + "/" + totalPaginas.ToString();
            //Cálculo para informar a partir de qual item a busca no banco deve começar
            itemInicial = 1 + (paginaAtual - 1) * itensMaximos;
            //Limpa todos os itens da tela inicial
            mainTableLayout.Controls.Clear();
            //Executa o loop com o número de itens máximos de cada página
            for (int i = itemInicial; i <= totalLivros*paginaAtual; i++)
            {
                //Declara como string vazio para evitar erros e utilizar abaixo no código
                string titulo = "";
                string autor = "";
                string idLivro = "";
                Image img = null;
                try
                {
                    using (SqlConnection connection = new SqlConnection(Utilidades.ConnectionString))
                    {
                        //Declara uma query dinamica que muda caso o usuário esteja fazendo uma busca
                        string query = buscando ? "select titulo_livro, autor_livro, id_livro, imagem_capa_livro from Livros where (titulo_livro like @texto_consulta or isbn_livro like @texto_consulta or editora_livro like @texto_consulta " +
                        "or autor_livro like @texto_consulta) and id_livro > @last_id" :
                            "SELECT titulo_livro, autor_livro, id_livro, imagem_capa_livro FROM (SELECT ROW_NUMBER() OVER (ORDER BY id_livro ASC) AS rownumber, id_livro, titulo_livro, imagem_capa_livro, autor_livro FROM Livros) AS foo WHERE rownumber =" + i;
                        if (buscandoPorData)
                            query = "select titulo_livro, autor_livro, id_livro, imagem_capa_livro from livros where id_livro > @last_id and dt_publicacao_livro between @data1 and @data2";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        //Adiciona o campo na query do que está sendo pesquisado
                        if (buscandoPorData)
                        {
                            cmd.Parameters.AddWithValue("@data1", buscaData1.Value.ToString("MM/dd/yyyy"));
                            cmd.Parameters.AddWithValue("@data2", buscaData2.Value.ToString("MM/dd/yyyy"));
                            
                        }
                        
                        cmd.Parameters.AddWithValue("@last_id", lastId);
                        cmd.Parameters.AddWithValue("@texto_consulta", "%" + buscaUsuariosBox.Text.ToString() + "%");
                        connection.Open();
                        using (SqlDataReader livros = cmd.ExecuteReader())
                        {
                            //Cancela o loop caso encontre uma linha inexistente no banco de dados
                            if (!livros.HasRows)
                                break;
                            livros.Read();
                            lastId = (int)livros["id_livro"];
                            titulo = livros["titulo_livro"].ToString();
                            autor = livros["autor_livro"].ToString();
                            idLivro = livros["id_livro"].ToString();
                            //Salva e converte a imagem para byte na variável
                            img = Utilidades.ConvertToImage(livros["imagem_capa_livro"] as byte[]);

                            //Cria os paineis que aparecem na tela principal com as informações passadas
                            var painel = new TableLayoutPanel
                            {
                                Name = "painel",
                                Size = new Size(240, 290),
                                //Dock = DockStyle.Fill,
                                Anchor = AnchorStyles.Top,
                                BackColor = Color.LightGray,
                                Tag = livros["id_livro"].ToString(), //Declara como tag o id do livro para quando clicado ser utilizado como busca no banco
                                Cursor = Cursors.Hand,
                            };
                            var imagemCapa = new PictureBox
                            {
                                Name = "imagemCapa",
                                Size = new Size(150, 200),
                                //Location = new Point(44, 50),
                                Dock = DockStyle.None,
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Anchor = AnchorStyles.Top,
                                Image = img,
                                Tag = livros["id_livro"].ToString(),

                            };
                            var tituloLivro = new Label
                            {
                                Name = "tituloLivro",
                                Size = new Size(painel.Size.Width - 10, 60),
                                AutoEllipsis = true,
                                Font = new Font("Arial", 12, FontStyle.Bold),
                                //Location = new Point(0, 10),
                                TextAlign = ContentAlignment.MiddleCenter,
                                Anchor = AnchorStyles.Bottom,
                                ForeColor = Color.Black,
                                Text = titulo,
                                Tag = livros["id_livro"].ToString(),
                            };
                            var autorLivro = new Label
                            {
                                Name = "autorLivro",
                                Size = new Size(painel.Size.Width - 10, 20),
                                Font = new Font("Arial", 8),
                                AutoEllipsis = true,
                                //Location = new Point(3, 260),
                                TextAlign = ContentAlignment.TopCenter,
                                Anchor = AnchorStyles.Top,
                                ForeColor = Color.Black,
                                Text = autor,
                                Tag = livros["id_livro"].ToString(),
                            };
                            //Adiciona o painel na tela principal
                            mainTableLayout.Controls.Add(painel);
                            //Adiciona as informações e imagem do livro no painel
                            painel.Controls.Add(tituloLivro);
                            painel.Controls.Add(imagemCapa);
                            painel.Controls.Add(autorLivro);
                            //Declara que o item clicado chamará a função especificada
                            painel.Click += new EventHandler(painel_Click);
                            autorLivro.Click += new EventHandler(painel_Click);
                            imagemCapa.Click += new EventHandler(painel_Click);
                            tituloLivro.Click += new EventHandler(painel_Click);
                        }
                        connection.Close();
                    }
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
            buscandoPorData = false;
            //Atualiza o dia maximo de data para o dia atual
            buscaData1.MaxDate = DateTime.Now;
            buscaData2.MaxDate = DateTime.Now;
        }
        //Função chamada ao clicar no item cadastrar usuário que abre uma nova janela caso já nao exista uma
        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!cadastroUsuario.IsHandleCreated)
            {
                cadastroUsuario = new Biblioteca_Cadastrar_Usuario();
                cadastroUsuario.Show();
            }
            else
                cadastroUsuario.Focus();
            //Declara que não está ocorrendo uma alteração
            Utilidades.alterandoUsuarios = false;
        }
        
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!consultaUsuario.IsHandleCreated)
            {
                consultaUsuario = new Biblioteca_Consulta_Usuário();
                consultaUsuario.Show();
            }
            else
                consultaUsuario.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Checa o total de páginas e caso a página atual seja menor que o total, avança
            if (paginaAtual < totalPaginas)
            {
                paginaAtual++;
                PopularLivros(false);
            }
            buscaUsuariosBox.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Checa o total de páginas e a página atual não seja menor que 1, retorna
            if (paginaAtual > 1)
            {
                paginaAtual--;
                PopularLivros(false);
            }
            buscaUsuariosBox.Text = string.Empty;
        }
        //Função chamada toda vez que a caixa de texto de busca é mudado
        private void buscaUsuariosBox_TextChanged(object sender, EventArgs e)
        {
            //Chama um timer que reseta cada vez que o usuario insere uma informação na caixa, após 0.5 segundo sem apertar realiza a busca
            buscaTimer.Stop();
            buscaTimer.Start();
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Biblioteca_Login login = new Biblioteca_Login();
                Hide();
                login.ShowDialog();
                Close();
            }
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar a aplicação?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            buscandoPorData = true;
            PopularLivros(false);
        }

        private void buscaTimer_Tick(object sender, EventArgs e)
        {
            //Chama a função de atualização de livros na tela, passando true para informar que é uma busca
            PopularLivros(true);
            buscaTimer.Stop();
        }
    }
}
