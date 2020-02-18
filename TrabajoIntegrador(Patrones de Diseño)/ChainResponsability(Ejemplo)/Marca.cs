using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability_Ejemplo_
{
    public class Marca:ObjetoBasico
    {

        protected String descripcion1, descripcion2;
        protected String nombre;


        public Marca(String nombre,String descripcion1,String descripcion2) {
            this.nombre = nombre;
            this.descripcion1 = descripcion1;
            this.descripcion2 = descripcion2;
        }




        protected override string getDescripcion()
        {
            if ((descripcion1 != null) && (descripcion2 != null))
            {
                return "Marca " + nombre + " : " + descripcion1 + " " + descripcion2;
            }else {

                return null;
            
            }
        }








    }
}
