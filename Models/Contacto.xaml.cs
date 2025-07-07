
using SQLite;

namespace GonzalezFabioExamen3P.Models
{
    public partial class Contacto 
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Correo { get; set; }

        public string Telefono { get; set; }

        public bool Favorito { get; set; }
    }
}
