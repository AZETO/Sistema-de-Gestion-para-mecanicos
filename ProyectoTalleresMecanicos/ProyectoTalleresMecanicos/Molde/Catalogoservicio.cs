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
        private String catalogoservicio_agenda;

        public string Catalogoservicio_agenda { get => catalogoservicio_agenda; set => catalogoservicio_agenda = value; }
        public int Catalogoservicio_id { get => catalogoservicio_id; set => catalogoservicio_id = value; }

        public Catalogoservicio()
        {
        }

        public Catalogoservicio(int catalogoservicio_id, string catalogoservicio_agenda)
        {
            Catalogoservicio_id = catalogoservicio_id;
            Catalogoservicio_agenda = catalogoservicio_agenda;
           
        }
    }
}
