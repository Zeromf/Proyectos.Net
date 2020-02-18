using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.DecoratorPrueba
{
    public class PastoSecoDecorator:Decorator
    {

        public PastoSecoDecorator(ISector componente) :base(componente) { }

        public override void Mojar(int agua)
        {
            this.componente.Mojar(agua/2);
        }
    }
}
