using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesMarcacion
{
    public enum TipoUsuario
    {
        Empleado,
        Administrador
    }
    public class Usuari
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NroDocumento { get; set; }
        public string CodigoHumano { get; set; }
        public Departamento departamento   { get; set; }
        public Cargo cargo  { get; set; }
        public DateTime FechaIngreso  { get; set; }
        public TipoUsuario tipoUsuario { get; set; }

        public static List<Usuari> listarUsuario  = new List<Usuari>();

        public Usuari() { }


        public static void AgregarUsuario(Usuari u)
        {
            listarUsuario.Add(u);
        }
        public static void EditarUsuario(Usuari u, int indice)
        {
            Usuari.listarUsuario[indice] = u;

        }

       
        public static void EliminiarUsuario(Usuari user)
        {
            listarUsuario.Remove(user);
        }

        public static List<Usuari> ObtenerUsuario()
        {
            return listarUsuario;
        }

        public override string ToString()
        {
            return this.Nombre + " " + Apellido;
        }
    }
}
