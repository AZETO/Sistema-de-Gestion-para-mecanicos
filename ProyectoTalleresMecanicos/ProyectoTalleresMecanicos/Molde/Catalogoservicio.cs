using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTalleresMecanicos.Molde
{
    internal class Catalogoservicio
    {
        private int catalogoservicio_id;
        private Int32 catalogoservicio_fecha_cita ;
        private String catalogoservicio_nombre_dueño;
        private String catalogoservicio_modelo_vehiculo;
        private Int32 catalogoservicio_año_modelo;
        private String catalogoservicio_motivo_servicio;

        public int Catalogoservicio_id { get => catalogoservicio_id; set => catalogoservicio_id=value; }
        public Int32 Catalogoservicio_fecha_cita { get => catalogoservicio_fecha_cita; set => catalogoservicio_fecha_cita=value; }
        public string Catalogoservicio_nombre_dueño { get => catalogoservicio_nombre_dueño; set => catalogoservicio_nombre_dueño=value; }
        public string Catalogoservicio_modelo_vehiculo { get => catalogoservicio_modelo_vehiculo; set => catalogoservicio_modelo_vehiculo=value; }
        public Int32 Catalogoservicio_año_modelo { get => catalogoservicio_año_modelo; set => catalogoservicio_año_modelo=value; }
        public string Catalogoservicio_motivo_servicio { get => catalogoservicio_motivo_servicio; set => catalogoservicio_motivo_servicio=value; }

        public Catalogoservicio()
        {
        }

        public Catalogoservicio(int catalogoservicio_id, Int32 catalogoservicio_fecha_cita, string catalogoservicio_nombre_dueño, string catalogoservicio_modelo_vehiculo, Int32 catalogoservicio_año_modelo, string catalogoservicio_motivo_servicio)
        {
            Catalogoservicio_id=catalogoservicio_id;
            Catalogoservicio_fecha_cita=catalogoservicio_fecha_cita;
            Catalogoservicio_nombre_dueño=catalogoservicio_nombre_dueño;
            Catalogoservicio_modelo_vehiculo=catalogoservicio_modelo_vehiculo;
            Catalogoservicio_año_modelo=catalogoservicio_año_modelo;
            Catalogoservicio_motivo_servicio=catalogoservicio_motivo_servicio;
            
        }
    }
}
