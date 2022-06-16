using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTalleresMecanicos.Molde
{
    internal class Catalogos
    {
        private String catalogo_nombretallercatalogo;
        private String catalogo_producto;
        private String catalogo_servicio;
        

        public string Catalogo_producto { get => catalogo_producto; set => catalogo_producto = value; }
        public string Catalogo_servicio { get => catalogo_servicio; set => catalogo_servicio = value; }
        public string Catalogo_nombretallercatalogo { get => catalogo_nombretallercatalogo; set => catalogo_nombretallercatalogo = value; }

        public Catalogos()
        {
        }

        public Catalogos(string catalogo_producto, string catalogo_servicio, string catalogo_nombretallercatalogo)
        {
            Catalogo_producto = catalogo_producto;
            Catalogo_servicio = catalogo_servicio;
            Catalogo_nombretallercatalogo = catalogo_nombretallercatalogo;
        }
    }
}
