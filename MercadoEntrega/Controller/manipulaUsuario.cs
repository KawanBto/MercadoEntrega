using MercadoEntrega.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEntrega.Controller
{
    internal class manipulaUsuario
    {
        public void AdicionaUsuario()
        {
            SqlConnection cn = new SqlConnection(conexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_AdicionarUsuarios", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@idFuncionariosFK", Usuario.IdFuncionarioFK);
                cmd.Parameters.AddWithValue("@funcaoUsuario", Usuario.FuncaoUsuario);
                cmd.Parameters.AddWithValue("@cargaHorariaUsuario", Usuario.CargaHoraria1);


                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuario cadastrado com sucesso");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
