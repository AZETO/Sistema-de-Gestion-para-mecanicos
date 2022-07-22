using MySql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace PaginaTallerMeca.Models
{
    public class usuario_cliente
    {
        public int ID_cliente { get; set; }

        public string nombre { get; set; }

        public string usuario { get; set; }

        public string rut { get; set; }

        public string telefono { get; set; }

        public string direccion { get; set; }

        public string correo { get; set; }

        public string password { get; set; }

        public DateTime fecha { get; set; }
    }

    








}
