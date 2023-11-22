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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            Usuario.FuncaoUsuario = txt_id.Text;
            Usuario.CargaHoraria1 = txt_carga.Text;

            manipulaUsuario manipulaUsuario = new manipulaUsuario();
            manipulaUsuario.AdicionaUsuario();
        }
    }
}
