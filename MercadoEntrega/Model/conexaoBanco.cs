using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MercadoEntrega.Model
{
    internal class conexaoBanco
    {
        public static string Conectar()
        {
            return @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\kawan.sbrito\source\repos\MercadoEntrega\MercadoEntrega\BancoDeDados\BDMercado.mdf; Integrated Security = True";
        }
    }
}
