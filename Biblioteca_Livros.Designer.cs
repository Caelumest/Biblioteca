namespace Biblioteca
{
    partial class Biblioteca_Livros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Biblioteca_Livros));
            this.imagemCapa = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tituloBox = new System.Windows.Forms.TextBox();
            this.autorBox = new System.Windows.Forms.TextBox();
            this.isbnBox = new System.Windows.Forms.TextBox();
            this.sinopseBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.editoraBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imagemBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateBoxLivro = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cancelarBotao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagemCapa)).BeginInit();
            this.SuspendLayout();
            // 
            // imagemCapa
            // 
            this.imagemCapa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imagemCapa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagemCapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagemCapa.Location = new System.Drawing.Point(656, 20);
            this.imagemCapa.Name = "imagemCapa";
            this.imagemCapa.Size = new System.Drawing.Size(150, 200);
            this.imagemCapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemCapa.TabIndex = 0;
            this.imagemCapa.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "*Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "*Título";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "*ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sinópse (Opcional)";
            // 
            // tituloBox
            // 
            this.tituloBox.Location = new System.Drawing.Point(16, 43);
            this.tituloBox.Name = "tituloBox";
            this.tituloBox.Size = new System.Drawing.Size(311, 20);
            this.tituloBox.TabIndex = 8;
            // 
            // autorBox
            // 
            this.autorBox.Location = new System.Drawing.Point(16, 110);
            this.autorBox.Name = "autorBox";
            this.autorBox.Size = new System.Drawing.Size(311, 20);
            this.autorBox.TabIndex = 9;
            // 
            // isbnBox
            // 
            this.isbnBox.Location = new System.Drawing.Point(374, 110);
            this.isbnBox.Name = "isbnBox";
            this.isbnBox.Size = new System.Drawing.Size(164, 20);
            this.isbnBox.TabIndex = 10;
            this.isbnBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isbnBox_KeyPress);
            // 
            // sinopseBox
            // 
            this.sinopseBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sinopseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinopseBox.Location = new System.Drawing.Point(16, 341);
            this.sinopseBox.MaxLength = 500;
            this.sinopseBox.Name = "sinopseBox";
            this.sinopseBox.Size = new System.Drawing.Size(481, 149);
            this.sinopseBox.TabIndex = 15;
            this.sinopseBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "*Editora";
            // 
            // editoraBox
            // 
            this.editoraBox.Location = new System.Drawing.Point(16, 184);
            this.editoraBox.Name = "editoraBox";
            this.editoraBox.Size = new System.Drawing.Size(311, 20);
            this.editoraBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imagemBox
            // 
            this.imagemBox.Enabled = false;
            this.imagemBox.Location = new System.Drawing.Point(16, 265);
            this.imagemBox.Name = "imagemBox";
            this.imagemBox.Size = new System.Drawing.Size(267, 20);
            this.imagemBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "*Imagem de Capa";
            // 
            // dateBoxLivro
            // 
            this.dateBoxLivro.CustomFormat = "dd/MM/yyyy";
            this.dateBoxLivro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBoxLivro.Location = new System.Drawing.Point(374, 184);
            this.dateBoxLivro.Name = "dateBoxLivro";
            this.dateBoxLivro.Size = new System.Drawing.Size(102, 20);
            this.dateBoxLivro.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(370, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "*Publicação";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(656, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 26);
            this.button2.TabIndex = 16;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cancelarBotao
            // 
            this.cancelarBotao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBotao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelarBotao.Location = new System.Drawing.Point(768, 527);
            this.cancelarBotao.Name = "cancelarBotao";
            this.cancelarBotao.Size = new System.Drawing.Size(90, 26);
            this.cancelarBotao.TabIndex = 19;
            this.cancelarBotao.Text = "Cancelar";
            this.cancelarBotao.UseVisualStyleBackColor = true;
            this.cancelarBotao.Click += new System.EventHandler(this.cancelarBotao_Click);
            // 
            // Biblioteca_Livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 565);
            this.Controls.Add(this.cancelarBotao);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateBoxLivro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.imagemBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editoraBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sinopseBox);
            this.Controls.Add(this.isbnBox);
            this.Controls.Add(this.autorBox);
            this.Controls.Add(this.tituloBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imagemCapa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Biblioteca_Livros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Livro";
            ((System.ComponentModel.ISupportInitialize)(this.imagemCapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagemCapa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tituloBox;
        private System.Windows.Forms.TextBox autorBox;
        private System.Windows.Forms.TextBox isbnBox;
        private System.Windows.Forms.RichTextBox sinopseBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox editoraBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox imagemBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateBoxLivro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cancelarBotao;
    }
}