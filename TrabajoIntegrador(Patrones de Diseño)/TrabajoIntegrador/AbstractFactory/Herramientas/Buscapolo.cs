using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.AbstractFactory.Herramientas
{
   public class Buscapolo:IHerramienta
    {


        public void usar()
        {
            Console.WriteLine("El Electricista usa el buscapolo");
        }

        public void guardar()
        {
            Console.WriteLine("El electricista guarda el buscapolo");
        }
    }
}
