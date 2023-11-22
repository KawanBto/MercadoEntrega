using MercadoEntrega.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEntrega.Controller
{
    internal class manipulaFuncionario
    {
        public void AdicionaFuncionario()
        {
            SqlConnection cn = new SqlConnection(conexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_AdicionarFuncionaios", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeFuncionario", Funcionario.NomeFuncionario);
                cmd.Parameters.AddWithValue("@cpfFuncionario", Funcionario.CpfFuncionario);
                cmd.Parameters.AddWithValue("@cepFuncionario", Funcionario.CepFuncionario);
                cmd.Parameters.AddWithValue("@foneFuncionario", Funcionario.FoneFuncionario);
                cmd.Parameters.AddWithValue("@emailFuncionario", Funcionario.EmailFuncionario);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario cadastrado com sucesso");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
