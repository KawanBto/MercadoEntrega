using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEntrega.Model
{
    internal class Funcionario
    {
        private static int idFuncionario;
        private static string nomeFuncionario;
        private static string cpfFuncionario;
        private static string cepFuncionario;
        private static string foneFuncionario;
        private static string emailFuncionario;

        public static int IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public static string NomeFuncionario { get => nomeFuncionario; set => nomeFuncionario = value; }
        public static string CpfFuncionario { get => cpfFuncionario; set => cpfFuncionario = value; }
        public static string CepFuncionario { get => cepFuncionario; set => cepFuncionario = value; }
        public static string FoneFuncionario { get => foneFuncionario; set => foneFuncionario = value; }
        public static string EmailFuncionario { get => emailFuncionario; set => emailFuncionario = value; }
    }
}
