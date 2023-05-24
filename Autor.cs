using System.ComponentModel.DataAnnotations;

namespace LibreriaUTN.Modelos
{
    public class Autor
    {
        [Key] //anotations: en este caso designado PK
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string? FechaNacimiento { get; set; }
        public string? Nacionalidad { get; set; }

        //relación
        public List<Libro>? Libros { get; set; }

    }
}