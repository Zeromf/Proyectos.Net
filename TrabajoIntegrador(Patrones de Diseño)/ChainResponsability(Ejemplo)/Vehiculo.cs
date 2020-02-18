using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability_Ejemplo_
{
    public class Vehiculo:ObjetoBasico
    {

        protected String descripcion;
        public Vehiculo(String descripcion) {
            this.descripcion = descripcion;
      
        }


        protected override String getDescripcion()
        {
            return descripcion;
        }
    }
}
