using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability_Ejemplo_
{
    public abstract class ObjetoBasico
    {

        protected ObjetoBasico siguiente;

        private String descripcionPorDefecto() {
            return "descripcion por defecto";
        
        }

        protected abstract string getDescripcion();

        public String devuelveDescripcion() {
            String resultado;
            resultado = getDescripcion();

            if (resultado!=null)
            {

                return resultado;
            }
            if (siguiente != null)
            {
                return siguiente.devuelveDescripcion();

            }else{

                return this.descripcionPorDefecto();
            }
 
        }


        public void setSiguiente(ObjetoBasico siguiente) {

            this.siguiente = siguiente;
 
        
        }





    }
}
