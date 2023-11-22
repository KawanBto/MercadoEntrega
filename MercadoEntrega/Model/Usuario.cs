using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEntrega.Model
{
    internal class Usuario
    {
        private static int idUsuarios;
        private static int idFuncionarioFK;
        private static string funcaoUsuario;
        private static string CargaHoraria;

        public static int IdUsuarios { get => idUsuarios; set => idUsuarios = value; }
        public static int IdFuncionarioFK { get => idFuncionarioFK; set => idFuncionarioFK = value; }
        public static string FuncaoUsuario { get => funcaoUsuario; set => funcaoUsuario = value; }
        public static string CargaHoraria1 { get => CargaHoraria; set => CargaHoraria = value; }
    }
}
