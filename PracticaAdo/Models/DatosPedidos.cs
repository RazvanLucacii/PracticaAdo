using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaAdo.Models
{
    internal class DatosPedidos
    {
        public List<string> Pedidos { get; set; }
        public string CodigoPedido { get; set; }
        public string FechaEntrega { get; set; }
        public string formaEnvio { get; set; }
        public int importe { get; set; }
        public DatosPedidos() 
        { 
            Pedidos = new List<string>();
        }
    }
}
