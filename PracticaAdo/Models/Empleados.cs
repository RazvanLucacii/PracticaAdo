using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaAdo.Models
{
    internal class Empleados
    {
        public List<string> CodigoPedidos { get; set; }
        public string CodigoClientes { get; set; }
        public string Empresa { get; set; }
        public string Contacto { get; set; }
        public string Cargo { get; set; }
        public string Ciudad {  get; set; }
        public int Telefono { get; set; }
    }
}
