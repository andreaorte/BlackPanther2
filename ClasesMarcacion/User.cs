using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesMarcacion
{
    public class User
    {
        public string NombreApellido { get; set; }
        public string CodigoHumano { get; set; }
        public Departamento Departamento   { get; set; }

        public Cargo Cargo  { get; set; }
        public DateTime FechaIngreso  { get; set; }

        public static List<User> listaUser  = new List<User>();

        public static void AgregarUser(User u)
        {
            listaUser.Add(u);
        }
        public static void EditarUser(User u, int indice)
        {
            User.listaUser[indice] = u;

        }
        public static void EliminarCarne(User user)
        {
            listaUser.Remove(user);
        }

        public static List<User> ObtenerUser()
        {
            return listaUser;
        }

        public override string ToString()
        {
            return this.NombreApellido;
        }
    }
}
