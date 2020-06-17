namespace AvaliaçãoFinal
{
    partial class DataViewer
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
            this.dataGridViewer = new System.Windows.Forms.DataGridView();
            this.lblContador = new System.Windows.Forms.Label();
            this.BuscaPorNome = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewer
            // 
            this.dataGridViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewer.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewer.Name = "dataGridViewer";
            this.dataGridViewer.Size = new System.Drawing.Size(382, 335);
            this.dataGridViewer.TabIndex = 0;
            this.dataGridViewer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblContador
            // 
            this.lblContador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(417, 334);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(35, 13);
            this.lblContador.TabIndex = 5;
            this.lblContador.Text = "label2";
            // 
            // BuscaPorNome
            // 
            this.BuscaPorNome.AutoSize = true;
            this.BuscaPorNome.Location = new System.Drawing.Point(25, 357);
            this.BuscaPorNome.Name = "BuscaPorNome";
            this.BuscaPorNome.Size = new System.Drawing.Size(87, 13);
            this.BuscaPorNome.TabIndex = 6;
            this.BuscaPorNome.Text = "Busca Por Nome";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(118, 354);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(276, 20);
            this.searchBox.TabIndex = 7;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // DataViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.BuscaPorNome);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.dataGridViewer);
            this.Name = "DataViewer";
            this.Text = "DataViewer";
            this.Load += new System.EventHandler(this.DataViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewer;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label BuscaPorNome;
        private System.Windows.Forms.TextBox searchBox;
    }
}