using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.DecoratorPrueba
{
    class ArbolesGrandesDecorator: Decorator
    {




        public ArbolesGrandesDecorator(ISector componente):base(componente) { 
        }

        public override void Mojar(int agua)
        {
            Console.WriteLine("Soy un arbol");
            this.componente.Mojar(agua*25/100);
        }
    }
}
