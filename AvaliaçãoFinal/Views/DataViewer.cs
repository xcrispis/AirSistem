using AvaliaçãoFinal.Models;
using AvaliaçãoFinal.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliaçãoFinal
{
    public partial class DataViewer : Form
    {
        UsuarioRepository repository = new UsuarioRepository();
        public DataViewer()
        {
            InitializeComponent();
        }



        private void DataViewer_Load(object sender, EventArgs e)
        {
                      

            carregaLista();
        }

        private void carregaLista()
        {
            UsuarioRepository repository = new UsuarioRepository();
            dataGridViewer.DataSource = null;
            dataGridViewer.DataSource = repository.buscarTodos();
            alterarContador();
        }

        private void alterarContador()
        {
            //2 itens de 10
            lblContador.Text = $"{dataGridViewer.RowCount} itens de {repository.buscarTodos().Count}";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            dataGridViewer.DataSource = null;

            // filtra as lista recebida do repositório, verificando se o nome, 
            // email, usuario, contém o que está no campo filtro.
            dataGridViewer.DataSource = repository.buscarTodos().FindAll(x =>
                x.nome.ToUpper().Contains(searchBox.Text.ToUpper()) ||
                x.usuario.ToUpper().Contains(searchBox.Text.ToUpper())
            );

            alterarContador();
        }
    }
}
