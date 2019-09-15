using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesMarcacion
{
    public class TipoHora
    {
        public int Id { get; set; }
        public String descripcion { get; set; }

        public TipoHora() {  }

        public TipoHora(int Id, string descripcion )
        {

            this.Id = Id;
            this.descripcion = descripcion;

        }
    }
}
