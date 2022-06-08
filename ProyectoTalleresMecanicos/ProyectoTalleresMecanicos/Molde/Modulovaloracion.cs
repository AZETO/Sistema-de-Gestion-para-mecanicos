using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTalleresMecanicos.Molde
{
    internal class Modulovaloracion
    {

        private String modulovaloracion_nombretaller;
        private String modulovaloracion_tipodeservicio;
        private String modulovaloracion_comentario;
        private Boolean modulovaloracion_valoracion;

        public string Modulovaloracion_nombretaller { get => modulovaloracion_nombretaller; set => modulovaloracion_nombretaller = value; }
        public string Modulovaloracion_tipodeservicio { get => modulovaloracion_tipodeservicio; set => modulovaloracion_tipodeservicio = value; }
        public string Modulovaloracion_comentario { get => modulovaloracion_comentario; set => modulovaloracion_comentario = value; }
        public bool Modulovaloracion_valoracion { get => modulovaloracion_valoracion; set => modulovaloracion_valoracion = value; }

        public Modulovaloracion()
        {
        }

        public Modulovaloracion(string modulovaloracion_nombretaller, string modulovaloracion_tipodeservicio, string modulovaloracion_comentario, bool modulovaloracion_valoracion)
        {
            Modulovaloracion_nombretaller = modulovaloracion_nombretaller;
            Modulovaloracion_tipodeservicio = modulovaloracion_tipodeservicio;
            Modulovaloracion_comentario = modulovaloracion_comentario;
            Modulovaloracion_valoracion = modulovaloracion_valoracion;
;
        }
    }
}
