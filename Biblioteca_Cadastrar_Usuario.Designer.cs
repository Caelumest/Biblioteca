namespace Biblioteca
{
    partial class Biblioteca_Cadastrar_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Biblioteca_Cadastrar_Usuario));
            this.label6 = new System.Windows.Forms.Label();
            this.loginUsuarioBox = new System.Windows.Forms.TextBox();
            this.cpfUsuarioBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.telefoneUsuarioBox = new System.Windows.Forms.TextBox();
            this.emailUsuarioBox = new System.Windows.Forms.TextBox();
            this.nomeUsuarioBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.senhaUsuarioBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.confirmarSenhaBox = new System.Windows.Forms.TextBox();
            this.enderecoUsuarioBox = new System.Windows.Forms.TextBox();
            this.cancelarBotao = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.poderUsuarioBox = new System.Windows.Forms.ComboBox();
            this.bibliotecaDataSet = new Biblioteca.BibliotecaDataSet();
            this.bibliotecaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "*Login";
            // 
            // loginUsuarioBox
            // 
            this.loginUsuarioBox.Location = new System.Drawing.Point(12, 270);
            this.loginUsuarioBox.Name = "loginUsuarioBox";
            this.loginUsuarioBox.Size = new System.Drawing.Size(311, 20);
            this.loginUsuarioBox.TabIndex = 29;
            // 
            // cpfUsuarioBox
            // 
            this.cpfUsuarioBox.Location = new System.Drawing.Point(12, 177);
            this.cpfUsuarioBox.Name = "cpfUsuarioBox";
            this.cpfUsuarioBox.Size = new System.Drawing.Size(146, 20);
            this.cpfUsuarioBox.TabIndex = 26;
            this.cpfUsuarioBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cpfUsuarioBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "*CPF";
            // 
            // telefoneUsuarioBox
            // 
            this.telefoneUsuarioBox.Location = new System.Drawing.Point(164, 177);
            this.telefoneUsuarioBox.Name = "telefoneUsuarioBox";
            this.telefoneUsuarioBox.Size = new System.Drawing.Size(159, 20);
            this.telefoneUsuarioBox.TabIndex = 25;
            this.telefoneUsuarioBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefoneUsuarioBox_KeyPress);
            // 
            // emailUsuarioBox
            // 
            this.emailUsuarioBox.Location = new System.Drawing.Point(12, 103);
            this.emailUsuarioBox.Name = "emailUsuarioBox";
            this.emailUsuarioBox.Size = new System.Drawing.Size(311, 20);
            this.emailUsuarioBox.TabIndex = 24;
            // 
            // nomeUsuarioBox
            // 
            this.nomeUsuarioBox.Location = new System.Drawing.Point(12, 36);
            this.nomeUsuarioBox.Name = "nomeUsuarioBox";
            this.nomeUsuarioBox.Size = new System.Drawing.Size(311, 20);
            this.nomeUsuarioBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "*Endereço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Telefone (Opcional)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "*Nome completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email (Opcional)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 35;
            this.label8.Text = "*Senha";
            // 
            // senhaUsuarioBox
            // 
            this.senhaUsuarioBox.Location = new System.Drawing.Point(12, 328);
            this.senhaUsuarioBox.Name = "senhaUsuarioBox";
            this.senhaUsuarioBox.PasswordChar = '*';
            this.senhaUsuarioBox.Size = new System.Drawing.Size(311, 20);
            this.senhaUsuarioBox.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 19);
            this.label9.TabIndex = 37;
            this.label9.Text = "*Confirmar senha";
            // 
            // confirmarSenhaBox
            // 
            this.confirmarSenhaBox.Location = new System.Drawing.Point(12, 388);
            this.confirmarSenhaBox.Name = "confirmarSenhaBox";
            this.confirmarSenhaBox.PasswordChar = '*';
            this.confirmarSenhaBox.Size = new System.Drawing.Size(311, 20);
            this.confirmarSenhaBox.TabIndex = 36;
            // 
            // enderecoUsuarioBox
            // 
            this.enderecoUsuarioBox.Location = new System.Drawing.Point(344, 36);
            this.enderecoUsuarioBox.Name = "enderecoUsuarioBox";
            this.enderecoUsuarioBox.Size = new System.Drawing.Size(444, 20);
            this.enderecoUsuarioBox.TabIndex = 38;
            // 
            // cancelarBotao
            // 
            this.cancelarBotao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBotao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelarBotao.Location = new System.Drawing.Point(698, 476);
            this.cancelarBotao.Name = "cancelarBotao";
            this.cancelarBotao.Size = new System.Drawing.Size(90, 26);
            this.cancelarBotao.TabIndex = 40;
            this.cancelarBotao.Text = "Cancelar";
            this.cancelarBotao.UseVisualStyleBackColor = true;
            this.cancelarBotao.Click += new System.EventHandler(this.cancelarBotao_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(586, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 26);
            this.button2.TabIndex = 39;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // poderUsuarioBox
            // 
            this.poderUsuarioBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.poderUsuarioBox.FormattingEnabled = true;
            this.poderUsuarioBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuário"});
            this.poderUsuarioBox.Location = new System.Drawing.Point(344, 103);
            this.poderUsuarioBox.Name = "poderUsuarioBox";
            this.poderUsuarioBox.Size = new System.Drawing.Size(161, 21);
            this.poderUsuarioBox.TabIndex = 41;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bibliotecaDataSetBindingSource
            // 
            this.bibliotecaDataSetBindingSource.DataSource = this.bibliotecaDataSet;
            this.bibliotecaDataSetBindingSource.Position = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(340, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 19);
            this.label10.TabIndex = 43;
            this.label10.Text = "*Nível de acesso";
            // 
            // Biblioteca_Cadastrar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.poderUsuarioBox);
            this.Controls.Add(this.cancelarBotao);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.enderecoUsuarioBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.confirmarSenhaBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.senhaUsuarioBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.loginUsuarioBox);
            this.Controls.Add(this.cpfUsuarioBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telefoneUsuarioBox);
            this.Controls.Add(this.emailUsuarioBox);
            this.Controls.Add(this.nomeUsuarioBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Biblioteca_Cadastrar_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.Biblioteca_Cadastrar_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox loginUsuarioBox;
        private System.Windows.Forms.TextBox cpfUsuarioBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox telefoneUsuarioBox;
        private System.Windows.Forms.TextBox emailUsuarioBox;
        private System.Windows.Forms.TextBox nomeUsuarioBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox senhaUsuarioBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox confirmarSenhaBox;
        private System.Windows.Forms.TextBox enderecoUsuarioBox;
        private System.Windows.Forms.Button cancelarBotao;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox poderUsuarioBox;
        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource bibliotecaDataSetBindingSource;
        private System.Windows.Forms.Label label10;
    }
}