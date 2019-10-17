using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesMarcacion
{
    public class Departamento
    {
        public string Id { get; set; }
        public String descripcion { get; set; }

        public static List<Departamento> listaDepartamento = new List<Departamento>();
        public Departamento() { }
        public Departamento(string Id, string descripcion)
        {

            this.Id = Id;
            this.descripcion = descripcion;

        }

        public override string ToString()
        {
            return descripcion;
        }
        public static List<Departamento> listaDepartamentos = new List<Departamento>();

        public static List<Departamento> ObtenerDepartamentos()
        {
            return listaDepartamentos;
        }

        public static void AgregarDepartamento(Departamento d)
        {
            listaDepartamentos.Add(d);
        }

        public static void EliminarDepartamento(Departamento d)
        {
            listaDepartamentos.Remove(d);
        }

        public static void EditarDepartamento(Departamento d, int indice)
        {

            Departamento.listaDepartamentos[indice] = d;
        }

        public static List<Departamento> ObtenerDepartamento()
        {
            return listaDepartamento;
        }
    }
}
