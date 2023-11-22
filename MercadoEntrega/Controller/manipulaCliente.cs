using MercadoEntrega.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEntrega.Controller
{
    internal class manipulaCliente
    {
        public void AdicionaCliente()
        {
            SqlConnection cn = new SqlConnection(conexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_AdicionarCliente", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try 
            {
                cmd.Parameters.AddWithValue("@nomeCliente", Cliente.NomeCliente);
                cmd.Parameters.AddWithValue("@foneCliente", Cliente.FoneCliente);
                cmd.Parameters.AddWithValue("@emailCliente", Cliente.EmailCliente);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso");
            }
            catch (Exception) 
            {
                throw;
            }
        }
    }
}
