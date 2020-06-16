namespace AvaliaçãoFinal
{
    partial class TelaPrincipalAdmin
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
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnAviao = new System.Windows.Forms.Button();
            this.btnGerenciarAvioes = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnGerenciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(109, 66);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(131, 114);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Listar Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAviao
            // 
            this.btnAviao.Location = new System.Drawing.Point(306, 66);
            this.btnAviao.Name = "btnAviao";
            this.btnAviao.Size = new System.Drawing.Size(131, 114);
            this.btnAviao.TabIndex = 0;
            this.btnAviao.Text = "Listar Avioes";
            this.btnAviao.UseVisualStyleBackColor = true;
            this.btnAviao.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGerenciarAvioes
            // 
            this.btnGerenciarAvioes.Location = new System.Drawing.Point(514, 66);
            this.btnGerenciarAvioes.Name = "btnGerenciarAvioes";
            this.btnGerenciarAvioes.Size = new System.Drawing.Size(131, 114);
            this.btnGerenciarAvioes.TabIndex = 0;
            this.btnGerenciarAvioes.Text = "Listar Usuarios";
            this.btnGerenciarAvioes.UseVisualStyleBackColor = true;
            this.btnGerenciarAvioes.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Location = new System.Drawing.Point(514, 255);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(131, 114);
            this.btnRelatorios.TabIndex = 0;
            this.btnRelatorios.Text = "Listar Usuarios";
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnGerenciar
            // 
            this.btnGerenciar.Location = new System.Drawing.Point(306, 255);
            this.btnGerenciar.Name = "btnGerenciar";
            this.btnGerenciar.Size = new System.Drawing.Size(131, 114);
            this.btnGerenciar.TabIndex = 0;
            this.btnGerenciar.Text = "Listar Usuarios";
            this.btnGerenciar.UseVisualStyleBackColor = true;
            this.btnGerenciar.Click += new System.EventHandler(this.button6_Click);
            // 
            // TelaPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnGerenciarAvioes);
            this.Controls.Add(this.btnGerenciar);
            this.Controls.Add(this.btnAviao);
            this.Controls.Add(this.btnUsuarios);
            this.Name = "TelaPrincipalAdmin";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnAviao;
        private System.Windows.Forms.Button btnGerenciarAvioes;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnGerenciar;
    }
}