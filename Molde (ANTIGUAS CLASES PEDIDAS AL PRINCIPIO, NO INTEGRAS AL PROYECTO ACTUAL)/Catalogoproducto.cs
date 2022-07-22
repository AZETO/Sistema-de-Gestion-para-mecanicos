using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTalleresMecanicos.Molde
{
    internal class Catalogoproducto
    {
        private int catalogoproducto_id;
        private String catalogoproducto_nombre;
        private String catalogoproducto_precio;
        private String catalogoproducto_stock;

        public int Catalogoproducto_id { get => catalogoproducto_id; set => catalogoproducto_id = value; }
        public string Catalogoproducto_nombre { get => catalogoproducto_nombre; set => catalogoproducto_nombre = value; }
        public string Catalogoproducto_precio { get => catalogoproducto_precio; set => catalogoproducto_precio = value; }
        public string Catalogoproducto_stock { get => catalogoproducto_stock; set => catalogoproducto_stock = value; }

        public Catalogoproducto()
        {
        }

        public Catalogoproducto(int catalogoproducto_id, string catalogoproducto_nombre, string catalogoproducto_precio, string catalogoproducto_stock)
        {
            Catalogoproducto_id = catalogoproducto_id;
            Catalogoproducto_nombre = catalogoproducto_nombre;
            Catalogoproducto_precio = catalogoproducto_precio;
            Catalogoproducto_stock = catalogoproducto_stock;
         
        }
    }
}
