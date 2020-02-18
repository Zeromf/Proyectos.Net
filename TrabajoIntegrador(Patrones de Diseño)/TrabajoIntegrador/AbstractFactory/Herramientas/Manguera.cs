using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.AbstractFactory
{
    public class Manguera:IHerramienta
    {


        public void usar()
        {
            Console.WriteLine("El bombero usa la manguera");
        }

        public void guardar()
        {
            Console.WriteLine("El bombero guarda la manguera");
        }
    }
}
