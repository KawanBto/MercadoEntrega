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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Cliente.NomeCliente = txt_nome.Text;
            Cliente.FoneCliente = mt_num.Text;
            Cliente.EmailCliente = txt_email.Text;

            manipulaCliente manipulaCliente = new manipulaCliente();
            manipulaCliente.AdicionaCliente();
        }
    }
}
