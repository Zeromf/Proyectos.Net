using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.AbstractFactory
{
   public class Pistola:IHerramienta
    {
        public void usar()
        {
            Console.WriteLine("El policia usa la pistola");
        }

        public void guardar()
        {
            Console.WriteLine("El policia guarda la pistola");
        }
    }
}
