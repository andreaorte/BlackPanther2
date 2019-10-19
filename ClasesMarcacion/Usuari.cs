using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesMarcacion
{
    public class Usuari
    {
        public string NombreApellido { get; set; }
        public string CodigoHumano { get; set; }
        public Departamento Departamento   { get; set; }

        public Cargo Cargo  { get; set; }
        public DateTime FechaIngreso  { get; set; }

        public static List<Usuari> listaUser  = new List<Usuari>();

        public Usuari() { }

        public Usuari(string nombreapellido, string codigohumano, DateTime fechaingreso)
        {
            this.NombreApellido = nombreapellido;
            this.CodigoHumano = codigohumano;
            this.FechaIngreso = fechaingreso;

        }

        public static void AgregarUser(Usuari u)
        {
            listaUser.Add(u);
        }
        public static void EditarUser(Usuari u, int indice)
        {
            Usuari.listaUser[indice] = u;

        }
        public static void EliminarCarne(Usuari user)
        {
            listaUser.Remove(user);
        }

        public static List<Usuari> ObtenerUser()
        {
            return listaUser;
        }

        public override string ToString()
        {
            return this.NombreApellido;
        }
    }
}
