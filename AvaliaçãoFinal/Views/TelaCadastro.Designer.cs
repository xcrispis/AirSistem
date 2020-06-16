namespace AvaliaçãoFinal
{
    partial class TelaCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CampoNome = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CampoSobrenome = new System.Windows.Forms.TextBox();
            this.CampoEndereco = new System.Windows.Forms.TextBox();
            this.CampoNumero = new System.Windows.Forms.TextBox();
            this.CampoUsuario = new System.Windows.Forms.TextBox();
            this.senhaCampo = new System.Windows.Forms.TextBox();
            this.senhaCampoConfirma = new System.Windows.Forms.TextBox();
            this.senhaInvalida = new System.Windows.Forms.Label();
            this.senhaDiferente = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Usuário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Confirmar Senha";
            // 
            // CampoNome
            // 
            this.CampoNome.AccessibleDescription = "";
            this.CampoNome.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.CampoNome.Location = new System.Drawing.Point(144, 47);
            this.CampoNome.Name = "CampoNome";
            this.CampoNome.Size = new System.Drawing.Size(145, 20);
            this.CampoNome.TabIndex = 1;
            this.CampoNome.Text = "Nome";
            this.CampoNome.TextChanged += new System.EventHandler(this.CampoNome_TextChanged);
            this.CampoNome.Enter += new System.EventHandler(this.CampoNome_Enter);
            this.CampoNome.Leave += new System.EventHandler(this.CampoNome_Leave);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(642, 181);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "É admin";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(596, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(692, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Deletar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(596, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 141);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // CampoSobrenome
            // 
            this.CampoSobrenome.AccessibleDescription = "";
            this.CampoSobrenome.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.CampoSobrenome.Location = new System.Drawing.Point(328, 47);
            this.CampoSobrenome.Name = "CampoSobrenome";
            this.CampoSobrenome.Size = new System.Drawing.Size(145, 20);
            this.CampoSobrenome.TabIndex = 1;
            this.CampoSobrenome.Text = "Sobrenome";
            this.CampoSobrenome.Enter += new System.EventHandler(this.CampoSobrenome_Enter);
            this.CampoSobrenome.Leave += new System.EventHandler(this.CampoSobrenome_Leave);
            // 
            // CampoEndereco
            // 
            this.CampoEndereco.AccessibleDescription = "";
            this.CampoEndereco.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.CampoEndereco.Location = new System.Drawing.Point(144, 98);
            this.CampoEndereco.Name = "CampoEndereco";
            this.CampoEndereco.Size = new System.Drawing.Size(145, 20);
            this.CampoEndereco.TabIndex = 1;
            this.CampoEndereco.Text = "Digite o endereço...";
            this.CampoEndereco.Enter += new System.EventHandler(this.CampoEndereco_Enter);
            this.CampoEndereco.Leave += new System.EventHandler(this.CampoEndereco_Leave);
            // 
            // CampoNumero
            // 
            this.CampoNumero.AccessibleDescription = "";
            this.CampoNumero.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.CampoNumero.Location = new System.Drawing.Point(351, 98);
            this.CampoNumero.Name = "CampoNumero";
            this.CampoNumero.Size = new System.Drawing.Size(35, 20);
            this.CampoNumero.TabIndex = 1;
            this.CampoNumero.Text = "N";
            this.CampoNumero.Enter += new System.EventHandler(this.CampoNumero_Enter);
            this.CampoNumero.Leave += new System.EventHandler(this.CampoNumero_Leave);
            // 
            // CampoUsuario
            // 
            this.CampoUsuario.AccessibleDescription = "";
            this.CampoUsuario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.CampoUsuario.Location = new System.Drawing.Point(144, 201);
            this.CampoUsuario.Name = "CampoUsuario";
            this.CampoUsuario.Size = new System.Drawing.Size(145, 20);
            this.CampoUsuario.TabIndex = 1;
            this.CampoUsuario.Text = "Coloque seu usuario...";
            this.CampoUsuario.Enter += new System.EventHandler(this.CampoUsuario_Enter);
            this.CampoUsuario.Leave += new System.EventHandler(this.CampoUsuario_Leave);
            // 
            // senhaCampo
            // 
            this.senhaCampo.AccessibleDescription = "";
            this.senhaCampo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.senhaCampo.Location = new System.Drawing.Point(144, 261);
            this.senhaCampo.Name = "senhaCampo";
            this.senhaCampo.PasswordChar = '*';
            this.senhaCampo.Size = new System.Drawing.Size(145, 20);
            this.senhaCampo.TabIndex = 1;
            this.senhaCampo.TextChanged += new System.EventHandler(this.senhaCampo_TextChanged);
            this.senhaCampo.Enter += new System.EventHandler(this.senhaCampo_Enter);
            this.senhaCampo.Leave += new System.EventHandler(this.senhaCampo_Leave);
            // 
            // senhaCampoConfirma
            // 
            this.senhaCampoConfirma.AccessibleDescription = "";
            this.senhaCampoConfirma.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.senhaCampoConfirma.Location = new System.Drawing.Point(144, 323);
            this.senhaCampoConfirma.Name = "senhaCampoConfirma";
            this.senhaCampoConfirma.PasswordChar = '*';
            this.senhaCampoConfirma.Size = new System.Drawing.Size(145, 20);
            this.senhaCampoConfirma.TabIndex = 1;
            this.senhaCampoConfirma.TextChanged += new System.EventHandler(this.senhaDiferente_TextChanged);
            this.senhaCampoConfirma.Enter += new System.EventHandler(this.senhaCampoConfirma_Enter);
            this.senhaCampoConfirma.Leave += new System.EventHandler(this.senhaCampoConfirma_Leave);
            // 
            // senhaInvalida
            // 
            this.senhaInvalida.AutoSize = true;
            this.senhaInvalida.ForeColor = System.Drawing.Color.Red;
            this.senhaInvalida.Location = new System.Drawing.Point(141, 295);
            this.senhaInvalida.Name = "senhaInvalida";
            this.senhaInvalida.Size = new System.Drawing.Size(393, 13);
            this.senhaInvalida.TabIndex = 29;
            this.senhaInvalida.Text = "Deve ter uma letra maiuscula, uma minuscula, um numero e oito digitos no minimo!";
            this.senhaInvalida.Visible = false;
            // 
            // senhaDiferente
            // 
            this.senhaDiferente.AutoSize = true;
            this.senhaDiferente.ForeColor = System.Drawing.Color.Red;
            this.senhaDiferente.Location = new System.Drawing.Point(145, 357);
            this.senhaDiferente.Name = "senhaDiferente";
            this.senhaDiferente.Size = new System.Drawing.Size(104, 13);
            this.senhaDiferente.TabIndex = 29;
            this.senhaDiferente.Text = "A senha não é igual!";
            this.senhaDiferente.Visible = false;
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.senhaDiferente);
            this.Controls.Add(this.senhaInvalida);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.CampoNumero);
            this.Controls.Add(this.senhaCampoConfirma);
            this.Controls.Add(this.senhaCampo);
            this.Controls.Add(this.CampoUsuario);
            this.Controls.Add(this.CampoSobrenome);
            this.Controls.Add(this.CampoEndereco);
            this.Controls.Add(this.CampoNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastro";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.TelaCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CampoNome;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox CampoSobrenome;
        private System.Windows.Forms.TextBox CampoEndereco;
        private System.Windows.Forms.TextBox CampoNumero;
        private System.Windows.Forms.TextBox CampoUsuario;
        private System.Windows.Forms.TextBox senhaCampo;
        private System.Windows.Forms.TextBox senhaCampoConfirma;
        private System.Windows.Forms.Label senhaInvalida;
        private System.Windows.Forms.Label senhaDiferente;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}