using MercadoEntrega.Controller;
using MercadoEntrega.Model;
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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            Produto.NomeProdutos = txt_nome.Text;
            Produto.ValorProdutos = mt_valor.Text;
            Produto.MarcaProdutos = txt_marca.Text;

            manipulaProduto manipulaProduto = new manipulaProduto();
            manipulaProduto.AdicionaProduto();
        }
    }
}
