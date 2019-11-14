namespace Biblioteca
{
    partial class Biblioteca_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Biblioteca_Principal));
            this.dropDownMenu = new System.Windows.Forms.MenuStrip();
            this.bibliotecaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bibliotecaDataSet1 = new Biblioteca.BibliotecaDataSet();
            this.mainTableLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paginasLabel = new System.Windows.Forms.Label();
            this.botaoProximo = new System.Windows.Forms.Button();
            this.botaoAnterior = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buscaData1 = new System.Windows.Forms.DateTimePicker();
            this.buscaUsuariosBox = new System.Windows.Forms.TextBox();
            this.bemVindoLabel = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.buscaTimer = new System.Windows.Forms.Timer(this.components);
            this.buscaData2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dropDownMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dropDownMenu
            // 
            this.dropDownMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bibliotecaToolStripMenuItem,
            this.livrosToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.dropDownMenu.Location = new System.Drawing.Point(0, 0);
            this.dropDownMenu.Name = "dropDownMenu";
            this.dropDownMenu.Size = new System.Drawing.Size(1027, 24);
            this.dropDownMenu.TabIndex = 0;
            this.dropDownMenu.Text = "menuStrip1";
            // 
            // bibliotecaToolStripMenuItem
            // 
            this.bibliotecaToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bibliotecaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.toolStripSeparator1,
            this.fecharToolStripMenuItem});
            this.bibliotecaToolStripMenuItem.Name = "bibliotecaToolStripMenuItem";
            this.bibliotecaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.bibliotecaToolStripMenuItem.Text = "Biblioteca";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(106, 6);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.livrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirLivroToolStripMenuItem});
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.livrosToolStripMenuItem.Text = "Livros";
            // 
            // inserirLivroToolStripMenuItem
            // 
            this.inserirLivroToolStripMenuItem.Name = "inserirLivroToolStripMenuItem";
            this.inserirLivroToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.inserirLivroToolStripMenuItem.Text = "Inserir";
            this.inserirLivroToolStripMenuItem.Click += new System.EventHandler(this.inserirLivroToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuários";
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.inserirToolStripMenuItem.Text = "Inserir";
            this.inserirToolStripMenuItem.Click += new System.EventHandler(this.inserirToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // bibliotecaDataSet1
            // 
            this.bibliotecaDataSet1.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTableLayout.AutoScroll = true;
            this.mainTableLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainTableLayout.Location = new System.Drawing.Point(12, 65);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.Size = new System.Drawing.Size(1003, 384);
            this.mainTableLayout.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.paginasLabel);
            this.panel1.Controls.Add(this.botaoProximo);
            this.panel1.Controls.Add(this.botaoAnterior);
            this.panel1.Location = new System.Drawing.Point(409, 452);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 66);
            this.panel1.TabIndex = 2;
            // 
            // paginasLabel
            // 
            this.paginasLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paginasLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paginasLabel.Location = new System.Drawing.Point(69, 3);
            this.paginasLabel.Name = "paginasLabel";
            this.paginasLabel.Size = new System.Drawing.Size(65, 56);
            this.paginasLabel.TabIndex = 2;
            this.paginasLabel.Text = "pag/totalpag";
            this.paginasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botaoProximo
            // 
            this.botaoProximo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoProximo.BackgroundImage")));
            this.botaoProximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoProximo.Location = new System.Drawing.Point(140, 3);
            this.botaoProximo.Name = "botaoProximo";
            this.botaoProximo.Size = new System.Drawing.Size(60, 60);
            this.botaoProximo.TabIndex = 1;
            this.botaoProximo.UseVisualStyleBackColor = true;
            this.botaoProximo.Click += new System.EventHandler(this.button2_Click);
            // 
            // botaoAnterior
            // 
            this.botaoAnterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoAnterior.BackgroundImage")));
            this.botaoAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoAnterior.Location = new System.Drawing.Point(3, 3);
            this.botaoAnterior.Name = "botaoAnterior";
            this.botaoAnterior.Size = new System.Drawing.Size(60, 60);
            this.botaoAnterior.TabIndex = 0;
            this.botaoAnterior.UseVisualStyleBackColor = true;
            this.botaoAnterior.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buscaData2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buscaData1);
            this.panel2.Controls.Add(this.buscaUsuariosBox);
            this.panel2.Controls.Add(this.bemVindoLabel);
            this.panel2.Location = new System.Drawing.Point(12, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1003, 31);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(486, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buscaData1
            // 
            this.buscaData1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buscaData1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.buscaData1.Location = new System.Drawing.Point(260, 5);
            this.buscaData1.Name = "buscaData1";
            this.buscaData1.Size = new System.Drawing.Size(96, 20);
            this.buscaData1.TabIndex = 2;
            // 
            // buscaUsuariosBox
            // 
            this.buscaUsuariosBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscaUsuariosBox.Location = new System.Drawing.Point(782, 6);
            this.buscaUsuariosBox.Name = "buscaUsuariosBox";
            this.buscaUsuariosBox.Size = new System.Drawing.Size(218, 20);
            this.buscaUsuariosBox.TabIndex = 1;
            this.buscaUsuariosBox.TextChanged += new System.EventHandler(this.buscaUsuariosBox_TextChanged);
            // 
            // bemVindoLabel
            // 
            this.bemVindoLabel.AutoSize = true;
            this.bemVindoLabel.Location = new System.Drawing.Point(3, 9);
            this.bemVindoLabel.Name = "bemVindoLabel";
            this.bemVindoLabel.Size = new System.Drawing.Size(99, 13);
            this.bemVindoLabel.TabIndex = 0;
            this.bemVindoLabel.Text = "Bem vindo Usuário!";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // buscaTimer
            // 
            this.buscaTimer.Interval = 500;
            this.buscaTimer.Tick += new System.EventHandler(this.buscaTimer_Tick);
            // 
            // buscaData2
            // 
            this.buscaData2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buscaData2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.buscaData2.Location = new System.Drawing.Point(384, 6);
            this.buscaData2.Name = "buscaData2";
            this.buscaData2.Size = new System.Drawing.Size(96, 20);
            this.buscaData2.TabIndex = 4;
            this.buscaData2.Value = new System.DateTime(2019, 11, 11, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Entre:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "e";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(723, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Buscar:";
            // 
            // Biblioteca_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainTableLayout);
            this.Controls.Add(this.dropDownMenu);
            this.MainMenuStrip = this.dropDownMenu;
            this.Name = "Biblioteca_Principal";
            this.Text = "Biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Biblioteca_Principal_Load);
            this.dropDownMenu.ResumeLayout(false);
            this.dropDownMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip dropDownMenu;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private BibliotecaDataSet bibliotecaDataSet1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel mainTableLayout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label paginasLabel;
        private System.Windows.Forms.Button botaoProximo;
        private System.Windows.Forms.Button botaoAnterior;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label bemVindoLabel;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox buscaUsuariosBox;
        private System.Windows.Forms.ToolStripMenuItem bibliotecaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker buscaData1;
        private System.Windows.Forms.Timer buscaTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker buscaData2;
        private System.Windows.Forms.Label label3;
    }
}

