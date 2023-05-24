using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUTN.Modelos
{
    public class Libro
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string? Editorial { get; set; }
        public string? FechaPublicacion { get; set; }
        public double? Precio { get; set; }

        //relación
        public int AutorID { get; set; }
        public Autor? Autor { get; set; }
        public List<Venta>? Ventas { get; set; }
    }
}
