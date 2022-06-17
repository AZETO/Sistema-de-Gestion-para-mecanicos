using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTalleresMecanicos.Molde
{
    internal class Mecanico
    {
        
        private String mecanico_nombre;
        private String mecanico_password;
        private String mecanico_direccion;
        private String mecanico_taller;
        private String mecanico_correo;
        private UInt32 mecanico_telefono;



       
        public string Mecanico_nombre { get => mecanico_nombre; set => mecanico_nombre = value; }
        public string Mecanico_password { get => mecanico_password; set => mecanico_password = value; }
        public string Mecanico_direccion { get => mecanico_direccion; set => mecanico_direccion = value; }
        public string Mecanico_taller { get => mecanico_taller; set => mecanico_taller = value; }
        public string Mecanico_correo { get => mecanico_correo; set => mecanico_correo = value; }
        public uint Mecanico_telefono { get => mecanico_telefono; set => mecanico_telefono = value; }

        public Mecanico()
        {
        }

        public Mecanico( string mecanico_nombre, string mecanico_password, string mecanico_direccion, string mecanico_taller, string mecanico_correo, uint mecanico_telefono)
        {
         
            Mecanico_nombre = mecanico_nombre;
            Mecanico_password = mecanico_password;
            Mecanico_direccion = mecanico_direccion;
            Mecanico_taller = mecanico_taller;
            Mecanico_correo = mecanico_correo;
            Mecanico_telefono = mecanico_telefono;

        }
    }
}
