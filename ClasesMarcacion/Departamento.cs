using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesMarcacion
{
    class Departamento
    {
        public int Id { get; set; }
        public String descripcion { get; set; }

        public Departamento() { }
        public Departamento(int Id, string descripcion)
        {

            this.Id = Id;
            this.descripcion = descripcion;

        }
                     
    }
}
