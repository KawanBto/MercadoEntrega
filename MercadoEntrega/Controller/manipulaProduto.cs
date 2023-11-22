using MercadoEntrega.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEntrega.Controller
{
    internal class manipulaProduto
    {

        public void AdicionaProduto()
        {
            SqlConnection cn = new SqlConnection(conexaoBanco.Conectar());
            SqlCommand cmd = new SqlCommand("P_AdicionarProdutos", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeProdutos", Produto.NomeProdutos);
                cmd.Parameters.AddWithValue("@valorProdutos", Produto.ValorProdutos);
                cmd.Parameters.AddWithValue("@marcaProdutos", Produto.MarcaProdutos);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
