using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability_Ejemplo_
{
   public class Modelo:ObjetoBasico
    {


       protected String descripcion;
       protected String nombre;

       public Modelo(String nombre , String descripcion) {
           this.nombre = nombre;
           this.descripcion = descripcion;
       
       
       }




        protected override string getDescripcion()
        {
            if (descripcion!=null)
            {
                
                return "Modelo "+nombre +": " + descripcion;
                
            }else{
            
                return null;
            
            
            }
        }










    }
}
