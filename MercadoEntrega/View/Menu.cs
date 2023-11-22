using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEntrega.View
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionarios funcionarios = new Funcionarios();
            funcionarios.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();
            produtos.Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisarUsuario pesqusuarios = new PesquisarUsuario();
            pesqusuarios.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarUsuario altusuarios = new AlterarUsuario();
            altusuarios.Show();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletarUsuario delusuarios = new DeletarUsuario();
            delusuarios.Show();
        }
    }
}
