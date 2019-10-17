using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesMarcacion
{
    public class Cargo
    {
        public String idCargo { get; set; }
        public String descripcion { get; set; }

        public static List<Cargo> listaCargo = new List<Cargo>();
        public Cargo() { }
        public Cargo(string idCargo, String decripcion)
        {
            this.idCargo = idCargo;
            this.descripcion = descripcion;

        }
        public override string ToString()
        {
            return descripcion;
        }
        public static List<Cargo> listaCargos = new List<Cargo>();

        public static List<Cargo> ObtenerCargos()
        {
            return listaCargos;
        }

        public static void AgregarCargo(Cargo c)
        {
            listaCargos.Add(c);
        }

        public static void EliminarCargo(Cargo c)
        {
            listaCargos.Remove(c);
        }

        public static void EditarCargo(Cargo c, int indice)
        {

            Cargo.listaCargos[indice] = c;
        }
        public static List<Cargo> ObtenerCargo()
        {
            return listaCargo;
        }
    }
}
