using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTalleresMecanicos.Molde
{
    internal class Cliente
    {
        private String cliente_rut;
        private int cliente_id;
        private String cliente_nombre;
        private String cliente_usuario;
        private String cliente_password;
        private String cliente_correo;
        private UInt32 cliete_telefono;

        public string Cliente_rut { get => cliente_rut; set => cliente_rut = value; }
        public int Cliente_id { get => cliente_id; set => cliente_id = value; }
        public string Cliente_nombre { get => cliente_nombre; set => cliente_nombre = value; }
        public string Cliente_usuario { get => cliente_usuario; set => cliente_usuario = value; }
        public string Cliente_password { get => cliente_password; set => cliente_password = value; }
        public string Cliente_correo { get => cliente_correo; set => cliente_correo = value; }
        public uint Cliete_telefono { get => cliete_telefono; set => cliete_telefono = value; }

        public Cliente()
        {
        }

        public Cliente(string cliente_rut, int cliente_id, string cliente_nombre, string cliente_usuario, string cliente_password, string cliente_correo, uint cliete_telefono)
        {
            Cliente_rut = cliente_rut;
            Cliente_id = cliente_id;
            Cliente_nombre = cliente_nombre;
            Cliente_usuario = cliente_usuario;
            Cliente_password = cliente_password;
            Cliente_correo = cliente_correo;
            Cliete_telefono = cliete_telefono;
        
        }
    }
}
