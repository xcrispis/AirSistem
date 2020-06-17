using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Text.RegularExpressions;

namespace AvaliaçãoFinal
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //O filtro - somente apresentar os arquivos de imagem
            ofd.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";
            //Chamar a janela - entrar somente se confirma a seleção do arquivo
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Carregar a imagem selecionada no picturebox
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CampoNome_TextChanged(object sender, EventArgs e)
        {
        }

        private void senhaDiferente_TextChanged(object sender, EventArgs e)
        {
            if (senhaCampo.Text != senhaCampoConfirma.Text)
            {
                senhaDiferente.Visible = true;
            }
            else
            {
                senhaDiferente.Visible = false;
            }
       
        }

        private bool senhaCorreta (string password)
        {
            if (senhaCampo.Text.Length >= 8)
            {
                string pattern = "[a-z]{1,}";
                if (Regex.IsMatch(password, pattern))
                {
                    pattern = "[A-Z] {1,}";
                    if (Regex.IsMatch(password, pattern))
                    {
                        pattern = "[0-9]{1,}";
                        if (Regex.IsMatch(password, pattern))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void senhaCampo_TextChanged(object sender, EventArgs e)
        {          
            
          if (senhaCorreta(senhaCampo.Text) == true)
            {
                senhaInvalida.Visible = false;
            } else
            {
                senhaInvalida.Visible = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void CampoNome_Enter(object sender, EventArgs e)
        {
            if (CampoNome.Text == "Nome") { CampoNome.Text = ""; CampoNome.ForeColor = Color.Black; }

            CampoNome.BackColor = System.Drawing.Color.LightYellow;
        }

        private void CampoNome_Leave(object sender, EventArgs e)
        {
            if (CampoNome.Text == ""){ CampoNome.Text = "Nome"; CampoNome.ForeColor = Color.Gray; }
            CampoNome.BackColor = System.Drawing.Color.White;
        }


        private void CampoSobrenome_Enter(object sender, EventArgs e)
        {
            if (CampoSobrenome.Text == "Sobrenome") { CampoSobrenome.Text = ""; CampoSobrenome.ForeColor = Color.Black; }
            CampoSobrenome.BackColor = System.Drawing.Color.LightYellow;
        }

        private void CampoSobrenome_Leave(object sender, EventArgs e)
        {
            if (CampoSobrenome.Text == "") {CampoSobrenome.Text = "Sobrenome"; CampoSobrenome.ForeColor = Color.Gray;}
            CampoSobrenome.BackColor = System.Drawing.Color.White;
        }


        private void CampoEndereco_Enter(object sender, EventArgs e)
        {
            if (CampoEndereco.Text == "Digite o endereço...") { CampoEndereco.Text = ""; CampoEndereco.ForeColor = Color.Black; }
            CampoEndereco.BackColor = System.Drawing.Color.LightYellow;
        }

        private void CampoEndereco_Leave(object sender, EventArgs e)
        {
            if (CampoEndereco.Text == "") { CampoEndereco.Text = "Digite o endereço..."; CampoEndereco.ForeColor = Color.Gray; }
            CampoEndereco.BackColor = System.Drawing.Color.White;
        }


        private void CampoNumero_Enter(object sender, EventArgs e)
        {
            if (CampoNumero.Text == "N") { CampoNumero.Text = ""; CampoNumero.ForeColor = Color.Black; }
            CampoNumero.BackColor = System.Drawing.Color.LightYellow;
        }

        private void CampoNumero_Leave(object sender, EventArgs e)
        {
            if (CampoNumero.Text == "") { CampoNumero.Text = "N"; CampoNumero.ForeColor = Color.Gray; }
            CampoNumero.BackColor = System.Drawing.Color.White;
        }


        private void TelaCadastro_Load(object sender, EventArgs e)
        {
            if (Form1.idioma == 1)
            {
                label1.Text = "Name";
                label2.Text = "Adress";
                label3.Text = "Birthday";
                label4.Text = "Username";
                label5.Text = "Password";
                label6.Text = "Repeat Password";

            }
        }

        private void CampoUsuario_Enter(object sender, EventArgs e)
        {
            if (CampoUsuario.Text == "Coloque seu usuario...") { CampoUsuario.Text = ""; CampoUsuario.ForeColor = Color.Black; }
            CampoUsuario.BackColor = System.Drawing.Color.LightYellow;
        }

        private void CampoUsuario_Leave(object sender, EventArgs e)
        {
            if (CampoUsuario.Text == "") { CampoUsuario.Text = "Coloque seu usuario..."; CampoUsuario.ForeColor = Color.Gray; }
            CampoUsuario.BackColor = System.Drawing.Color.White;
        }

        private void senhaCampo_Enter(object sender, EventArgs e)
        {
            senhaCampo.BackColor = System.Drawing.Color.LightYellow;
        }

        private void senhaCampo_Leave(object sender, EventArgs e)
        {
            senhaCampo.BackColor = System.Drawing.Color.White;
        }

        private void senhaCampoConfirma_Enter(object sender, EventArgs e)
        {
            senhaCampoConfirma.BackColor = System.Drawing.Color.LightYellow;
        }

        private void senhaCampoConfirma_Leave(object sender, EventArgs e)
        {
            senhaCampoConfirma.BackColor = System.Drawing.Color.White;
        }

        private void TelaCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer fechar?", "Confirmação",
               MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }


    }


