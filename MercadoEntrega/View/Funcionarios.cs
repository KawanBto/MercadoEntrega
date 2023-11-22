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
    public partial class Funcionarios : Form
    {
        public Funcionarios()
        {
            InitializeComponent();
        }

        private void btn_gravarFunc_Click(object sender, EventArgs e)
        {
            Funcionario.NomeFuncionario = txt_nome.Text;
            Funcionario.CpfFuncionario = txt_cpf.Text;
            Funcionario.CepFuncionario = txt_cep.Text;
            Funcionario.FoneFuncionario = mt_num.Text;
            Funcionario.EmailFuncionario = txt_email.Text;

            manipulaFuncionario manipulaFuncionario = new manipulaFuncionario();
            manipulaFuncionario.AdicionaFuncionario();
        }
    }
}
