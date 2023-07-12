using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class DescipcionFactura
    {
        public string NombreProducto { get; set; }
        public int IdProducto { get; set; }
        public int CantidadVendida { get; set; }
        public decimal Precio { get; set; }

    }
}
