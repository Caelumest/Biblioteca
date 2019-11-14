namespace Biblioteca
{
    partial class Biblioteca_Detalhes_Livro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Biblioteca_Detalhes_Livro));
            this.capaLivroDetalhes = new System.Windows.Forms.PictureBox();
            this.tituloLivroDetalhes = new System.Windows.Forms.Label();
            this.autoresLivroDetalhes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtPublicacaoLivroDetalhes = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.editoraLivroDetalhes = new System.Windows.Forms.Label();
            this.isbnLivroDetalhes = new System.Windows.Forms.Label();
            this.sinopseLivroDetalhes = new System.Windows.Forms.Label();
            this.voltarDetalhesBotao = new System.Windows.Forms.PictureBox();
            this.excluirDetalhesLivro = new System.Windows.Forms.PictureBox();
            this.alterarDetalhesBotao = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.capaLivroDetalhes)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voltarDetalhesBotao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excluirDetalhesLivro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alterarDetalhesBotao)).BeginInit();
            this.SuspendLayout();
            // 
            // capaLivroDetalhes
            // 
            this.capaLivroDetalhes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.capaLivroDetalhes.Location = new System.Drawing.Point(12, 12);
            this.capaLivroDetalhes.Name = "capaLivroDetalhes";
            this.capaLivroDetalhes.Size = new System.Drawing.Size(150, 200);
            this.capaLivroDetalhes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.capaLivroDetalhes.TabIndex = 0;
            this.capaLivroDetalhes.TabStop = false;
            // 
            // tituloLivroDetalhes
            // 
            this.tituloLivroDetalhes.AutoEllipsis = true;
            this.tituloLivroDetalhes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLivroDetalhes.Location = new System.Drawing.Point(168, 9);
            this.tituloLivroDetalhes.Name = "tituloLivroDetalhes";
            this.tituloLivroDetalhes.Size = new System.Drawing.Size(373, 57);
            this.tituloLivroDetalhes.TabIndex = 1;
            this.tituloLivroDetalhes.Text = "Titulo do Livro";
            this.tituloLivroDetalhes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // autoresLivroDetalhes
            // 
            this.autoresLivroDetalhes.AutoEllipsis = true;
            this.autoresLivroDetalhes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoresLivroDetalhes.Location = new System.Drawing.Point(168, 57);
            this.autoresLivroDetalhes.Name = "autoresLivroDetalhes";
            this.autoresLivroDetalhes.Size = new System.Drawing.Size(373, 20);
            this.autoresLivroDetalhes.TabIndex = 2;
            this.autoresLivroDetalhes.Text = "por Autores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Detalhes do livro";
            // 
            // dtPublicacaoLivroDetalhes
            // 
            this.dtPublicacaoLivroDetalhes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtPublicacaoLivroDetalhes.AutoEllipsis = true;
            this.dtPublicacaoLivroDetalhes.AutoSize = true;
            this.dtPublicacaoLivroDetalhes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPublicacaoLivroDetalhes.Location = new System.Drawing.Point(3, 35);
            this.dtPublicacaoLivroDetalhes.Name = "dtPublicacaoLivroDetalhes";
            this.dtPublicacaoLivroDetalhes.Size = new System.Drawing.Size(127, 20);
            this.dtPublicacaoLivroDetalhes.TabIndex = 5;
            this.dtPublicacaoLivroDetalhes.Text = "Data da publicação:";
            this.dtPublicacaoLivroDetalhes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.editoraLivroDetalhes, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.isbnLivroDetalhes, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtPublicacaoLivroDetalhes, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(547, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(264, 426);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // editoraLivroDetalhes
            // 
            this.editoraLivroDetalhes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.editoraLivroDetalhes.AutoEllipsis = true;
            this.editoraLivroDetalhes.AutoSize = true;
            this.editoraLivroDetalhes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editoraLivroDetalhes.Location = new System.Drawing.Point(3, 95);
            this.editoraLivroDetalhes.Name = "editoraLivroDetalhes";
            this.editoraLivroDetalhes.Size = new System.Drawing.Size(55, 20);
            this.editoraLivroDetalhes.TabIndex = 7;
            this.editoraLivroDetalhes.Text = "Editora:";
            this.editoraLivroDetalhes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // isbnLivroDetalhes
            // 
            this.isbnLivroDetalhes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.isbnLivroDetalhes.AutoEllipsis = true;
            this.isbnLivroDetalhes.AutoSize = true;
            this.isbnLivroDetalhes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnLivroDetalhes.Location = new System.Drawing.Point(3, 65);
            this.isbnLivroDetalhes.Name = "isbnLivroDetalhes";
            this.isbnLivroDetalhes.Size = new System.Drawing.Size(43, 20);
            this.isbnLivroDetalhes.TabIndex = 6;
            this.isbnLivroDetalhes.Text = "ISBN:";
            this.isbnLivroDetalhes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sinopseLivroDetalhes
            // 
            this.sinopseLivroDetalhes.AutoEllipsis = true;
            this.sinopseLivroDetalhes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinopseLivroDetalhes.Location = new System.Drawing.Point(168, 93);
            this.sinopseLivroDetalhes.Name = "sinopseLivroDetalhes";
            this.sinopseLivroDetalhes.Size = new System.Drawing.Size(373, 345);
            this.sinopseLivroDetalhes.TabIndex = 6;
            this.sinopseLivroDetalhes.Text = resources.GetString("sinopseLivroDetalhes.Text");
            // 
            // voltarDetalhesBotao
            // 
            this.voltarDetalhesBotao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltarDetalhesBotao.Image = ((System.Drawing.Image)(resources.GetObject("voltarDetalhesBotao.Image")));
            this.voltarDetalhesBotao.Location = new System.Drawing.Point(12, 374);
            this.voltarDetalhesBotao.Name = "voltarDetalhesBotao";
            this.voltarDetalhesBotao.Size = new System.Drawing.Size(64, 64);
            this.voltarDetalhesBotao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.voltarDetalhesBotao.TabIndex = 7;
            this.voltarDetalhesBotao.TabStop = false;
            this.voltarDetalhesBotao.Click += new System.EventHandler(this.voltarDetalhesBotao_Click);
            // 
            // excluirDetalhesLivro
            // 
            this.excluirDetalhesLivro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("excluirDetalhesLivro.BackgroundImage")));
            this.excluirDetalhesLivro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.excluirDetalhesLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excluirDetalhesLivro.Location = new System.Drawing.Point(12, 218);
            this.excluirDetalhesLivro.Name = "excluirDetalhesLivro";
            this.excluirDetalhesLivro.Size = new System.Drawing.Size(50, 50);
            this.excluirDetalhesLivro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.excluirDetalhesLivro.TabIndex = 8;
            this.excluirDetalhesLivro.TabStop = false;
            this.toolTip1.SetToolTip(this.excluirDetalhesLivro, "Excluir livro");
            this.excluirDetalhesLivro.Click += new System.EventHandler(this.excluirDetalhesLivro_Click);
            // 
            // alterarDetalhesBotao
            // 
            this.alterarDetalhesBotao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("alterarDetalhesBotao.BackgroundImage")));
            this.alterarDetalhesBotao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alterarDetalhesBotao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alterarDetalhesBotao.Location = new System.Drawing.Point(68, 218);
            this.alterarDetalhesBotao.Name = "alterarDetalhesBotao";
            this.alterarDetalhesBotao.Size = new System.Drawing.Size(50, 50);
            this.alterarDetalhesBotao.TabIndex = 9;
            this.alterarDetalhesBotao.TabStop = false;
            this.toolTip1.SetToolTip(this.alterarDetalhesBotao, "Alterar informações");
            this.alterarDetalhesBotao.Click += new System.EventHandler(this.alterarDetalhesBotao_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.Desktop;
            // 
            // Biblioteca_Detalhes_Livro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.alterarDetalhesBotao);
            this.Controls.Add(this.excluirDetalhesLivro);
            this.Controls.Add(this.voltarDetalhesBotao);
            this.Controls.Add(this.sinopseLivroDetalhes);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.autoresLivroDetalhes);
            this.Controls.Add(this.tituloLivroDetalhes);
            this.Controls.Add(this.capaLivroDetalhes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Biblioteca_Detalhes_Livro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca_Detalhes_Livro";
            this.Load += new System.EventHandler(this.Biblioteca_Detalhes_Livro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.capaLivroDetalhes)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voltarDetalhesBotao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excluirDetalhesLivro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alterarDetalhesBotao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox capaLivroDetalhes;
        private System.Windows.Forms.Label tituloLivroDetalhes;
        private System.Windows.Forms.Label autoresLivroDetalhes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dtPublicacaoLivroDetalhes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label editoraLivroDetalhes;
        private System.Windows.Forms.Label isbnLivroDetalhes;
        private System.Windows.Forms.Label sinopseLivroDetalhes;
        private System.Windows.Forms.PictureBox voltarDetalhesBotao;
        private System.Windows.Forms.PictureBox excluirDetalhesLivro;
        private System.Windows.Forms.PictureBox alterarDetalhesBotao;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}