using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.AbstractFactory
{
   public class Desfibrilador:IHerramienta
    {


        public void usar()
        {
            Console.WriteLine("El medico usa el desfibrilador");
        }

        public void guardar()
        {
            Console.WriteLine("El medico guarda el desfibrilador");
        }
    }
}
