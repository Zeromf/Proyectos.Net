using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.DecoratorPrueba;
namespace TrabajoIntegrador.FactoryMethod
{
    class FactoryPastoSeco:FactorySectores
    {

        public override ISector crearSector(ISector s)
        {
            return new PastoSecoDecorator(s);

        }



    }
}
