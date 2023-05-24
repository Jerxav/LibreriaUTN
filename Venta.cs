using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUTN.Modelos
{
    public class Venta
    {
        public int ID { get; set; }
        public int Cantidad { get; set; }
        public string FechaVenta { get; set; }
        public double Total { get; set; }

        //relación
        public Libro? Libro { get; set; }
        public int LibroID { get; set; }
    }
}
 