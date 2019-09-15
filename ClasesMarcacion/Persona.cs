using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesMarcacion
{
    public class Persona
    {
        public int CodigoHumano { get; set; }
        public string NroDocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona() { }

        public Persona(int codigoHumano, string nroDocumento, string nombre, string apellido)
        {
            this.CodigoHumano = codigoHumano;
            this.NroDocumento = nroDocumento;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }


    }
}
