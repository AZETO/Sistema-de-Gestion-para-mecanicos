using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTalleresMecanicos.Molde
{
    internal class Catalogotalleres
    {
        private String catalogotalleres_nombremecanico;
        private String catalogotalleres_nombretaller;
        private String catalogotalleres_direccionmecanico;
        private String catalogotalleres_tipoproducto;
        private String catalogotalleres_tiposervicio;
        private UInt32 catalogotalleres_correomecanico;

        public string Catalogotalleres_nombremecanico { get => catalogotalleres_nombremecanico; set => catalogotalleres_nombremecanico = value; }
        public string Catalogotalleres_nombretaller { get => catalogotalleres_nombretaller; set => catalogotalleres_nombretaller = value; }
        public string Catalogotalleres_direccionmecanico { get => catalogotalleres_direccionmecanico; set => catalogotalleres_direccionmecanico = value; }
        public string Catalogotalleres_tipoproducto { get => catalogotalleres_tipoproducto; set => catalogotalleres_tipoproducto = value; }
        public string Catalogotalleres_tiposervicio { get => catalogotalleres_tiposervicio; set => catalogotalleres_tiposervicio = value; }
        public uint Catalogotalleres_correomecanico { get => catalogotalleres_correomecanico; set => catalogotalleres_correomecanico = value; }

        public Catalogotalleres()
        {
        }

        public Catalogotalleres(string catalogotalleres_nombremecanico, string catalogotalleres_nombretaller, string catalogotalleres_direccionmecanico, string catalogotalleres_tipoproducto, string catalogotalleres_tiposervicio, uint catalogotalleres_correomecanico)
        {
            Catalogotalleres_nombremecanico = catalogotalleres_nombremecanico;
            Catalogotalleres_nombretaller = catalogotalleres_nombretaller;
            Catalogotalleres_direccionmecanico = catalogotalleres_direccionmecanico;
            Catalogotalleres_tipoproducto = catalogotalleres_tipoproducto;
            Catalogotalleres_tiposervicio = catalogotalleres_tiposervicio;
            Catalogotalleres_correomecanico = catalogotalleres_correomecanico;
          
        }
    }
}
