using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesMarcacion
{

    public enum TipoHora
    {
        Diurna,
        Nocturna
    }
    public class Bloque
    {

        public Usuari NombreUsuario  { get; set; }
        public string CodigoHumano  { get; set; }
        public TipoHora Tipo_Hora  { get; set; }
        public DateTime FechaInicio  { get; set; }
        public DateTime FechaFin { get; set; }


        public static List<Bloque> listaBloque = new List<Bloque>();
        //Metodo para Obtener Proveedores
        public static List<Bloque> ObtenerBloque()
        {
            return listaBloque;
        }

        public Bloque() { }

        public Bloque(string codigoHumano, DateTime fechainicio, DateTime fechafin)
        {
            this.CodigoHumano = codigoHumano;
            this.FechaInicio = fechainicio;
            this.FechaFin = fechafin;

        }


        //Metodo para Agregar Proveedores

        public static void AgregarBloque(Bloque b)
        {
            listaBloque.Add(b);
        }
        public static void EliminarBloque(Bloque b)
        {
            listaBloque.Remove(b);
        }

        public static void EditarBloque(Bloque b, int indice)
        {
            Bloque.listaBloque[indice] = b;

        }






    }
}
