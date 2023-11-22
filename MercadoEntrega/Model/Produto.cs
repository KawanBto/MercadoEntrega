using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEntrega.Model
{
    internal class Produto
    {
        private static int idProdutos;
        private static string nomeProdutos;
        private static string valorProdutos;
        private static string marcaProdutos;

        public static int IdProdutos { get => idProdutos; set => idProdutos = value; }
        public static string NomeProdutos { get => nomeProdutos; set => nomeProdutos = value; }
        public static string ValorProdutos { get => valorProdutos; set => valorProdutos = value; }
        public static string MarcaProdutos { get => marcaProdutos; set => marcaProdutos = value; }
    }
}
