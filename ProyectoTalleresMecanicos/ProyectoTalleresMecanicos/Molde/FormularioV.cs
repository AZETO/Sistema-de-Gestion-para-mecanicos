using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTalleresMecanicos.Molde
{
    internal class FormularioV
    {
        private int formulariov_id;
        private String formulariov_marca;
        private String formulariov_modelo;
        private UInt16 formulariov_año;
        private String formulariov_rutcliente;
        private UInt32 formulariov_telefonocliente;
        private String formulariov_dueñovehiculo;
        private String formulariov_correodueño;

        public int Formulariov_id { get => formulariov_id; set => formulariov_id = value; }
        public string Formulariov_marca { get => formulariov_marca; set => formulariov_marca = value; }
        public string Formulariov_modelo { get => formulariov_modelo; set => formulariov_modelo = value; }
        public ushort Formulariov_año { get => formulariov_año; set => formulariov_año = value; }
        public string Formulariov_rutcliente { get => formulariov_rutcliente; set => formulariov_rutcliente = value; }
        public uint Formulariov_telefonocliente { get => formulariov_telefonocliente; set => formulariov_telefonocliente = value; }
        public string Formulariov_dueñovehiculo { get => formulariov_dueñovehiculo; set => formulariov_dueñovehiculo = value; }
        public string Formulariov_correodueño { get => formulariov_correodueño; set => formulariov_correodueño = value; }

        public FormularioV()
        {
        }

        public FormularioV(int formulariov_id, string formulariov_marca, string formulariov_modelo, ushort formulariov_año, string formulariov_rutcliente, uint formulariov_telefonocliente, string formulariov_dueñovehiculo, string formulariov_correodueño)
        {
            Formulariov_id = formulariov_id;
            Formulariov_marca = formulariov_marca;
            Formulariov_modelo = formulariov_modelo;
            Formulariov_año = formulariov_año;
            Formulariov_rutcliente = formulariov_rutcliente;
            Formulariov_telefonocliente = formulariov_telefonocliente;
            Formulariov_dueñovehiculo = formulariov_dueñovehiculo;
            Formulariov_correodueño = formulariov_correodueño;
         
        }
    }
}
