using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesMarcacion
{
    public class Cargo
    {
        private int idCargo { get; set; }
        private String descripcion { get; set; }

        public Cargo() {  }
        public Cargo(int idCargo, String decripcion)
        {
            this.idCargo = idCargo;
            this.descripcion = descripcion;

        }
    }
}
