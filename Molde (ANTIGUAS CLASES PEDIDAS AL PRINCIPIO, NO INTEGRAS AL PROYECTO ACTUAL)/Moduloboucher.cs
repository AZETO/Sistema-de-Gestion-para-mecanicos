using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTalleresMecanicos.Molde
{
    internal class Moduloboucher
    {
        private int moduloboucher_id;
        private String moduloboucher_nombrecliente;
        private String moduloboucher_correocliente;
        private String moduloboucher_rutcliente;
        private String moduloboucher_nombremecanico;
        private String moduloboucher_tallermecanico;
        private String moduloboucher_direcciontaller;
        private String moduloboucher_correomecanico;
        private Int32  moduloboucher_precio;
        private DateTime moduloboucher_fecha;

        public int Moduloboucher_id { get => moduloboucher_id; set => moduloboucher_id = value; }
        public string Moduloboucher_nombrecliente { get => moduloboucher_nombrecliente; set => moduloboucher_nombrecliente = value; }
        public string Moduloboucher_correocliente { get => moduloboucher_correocliente; set => moduloboucher_correocliente = value; }
        public string Moduloboucher_rutcliente { get => moduloboucher_rutcliente; set => moduloboucher_rutcliente = value; }
        public string Moduloboucher_nombremecanico { get => moduloboucher_nombremecanico; set => moduloboucher_nombremecanico = value; }
        public string Moduloboucher_tallermecanico { get => moduloboucher_tallermecanico; set => moduloboucher_tallermecanico = value; }
        public string Moduloboucher_direcciontaller { get => moduloboucher_direcciontaller; set => moduloboucher_direcciontaller = value; }
        public string Moduloboucher_correomecanico { get => moduloboucher_correomecanico; set => moduloboucher_correomecanico = value; }
        public int Moduloboucher_precio { get => moduloboucher_precio; set => moduloboucher_precio = value; }
        public DateTime Moduloboucher_fecha { get => moduloboucher_fecha; set => moduloboucher_fecha = value; }

        public Moduloboucher()
        {
        }

        public Moduloboucher(int moduloboucher_id, string moduloboucher_nombrecliente, string moduloboucher_correocliente, string moduloboucher_rutcliente, string moduloboucher_nombremecanico, string moduloboucher_tallermecanico, string moduloboucher_direcciontaller, string moduloboucher_correomecanico, int moduloboucher_precio, DateTime moduloboucher_fecha)
        {
            Moduloboucher_id = moduloboucher_id;
            Moduloboucher_nombrecliente = moduloboucher_nombrecliente;
            Moduloboucher_correocliente = moduloboucher_correocliente;
            Moduloboucher_rutcliente = moduloboucher_rutcliente;
            Moduloboucher_nombremecanico = moduloboucher_nombremecanico;
            Moduloboucher_tallermecanico = moduloboucher_tallermecanico;
            Moduloboucher_direcciontaller = moduloboucher_direcciontaller;
            Moduloboucher_correomecanico = moduloboucher_correomecanico;
            Moduloboucher_precio = moduloboucher_precio;
            Moduloboucher_fecha = moduloboucher_fecha;
          
        }
    }
}
