using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesMarcacion
{
    public class Marcacion
    {
        public Usuari empleado { get; set; }
        public Usuari cargo { get; set; }
        public Usuari departamento { get; set; }
        public string HorasTrabajadas { get; set; }
        public string MarcacionEntrada { get; set; }
        public string MarcacionSalida { get; set; }

        public static List<Marcacion> listaMarcacion = new List<Marcacion>();

        public Marcacion() { }


        public static void AgregarMarcacion(Marcacion m)
        {
            listaMarcacion.Add(m);
        }


        public static List<Marcacion> ObtenerMarcacion()
        {
            return listaMarcacion;
        }

        public override string ToString()
        {
            return this.empleado.ToString();
        }
    }
}
