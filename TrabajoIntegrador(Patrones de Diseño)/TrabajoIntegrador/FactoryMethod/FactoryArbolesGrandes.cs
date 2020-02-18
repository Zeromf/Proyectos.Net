using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.DecoratorPrueba;
namespace TrabajoIntegrador.FactoryMethod
{
    public class FactoryArbolesGrandes:FactorySectores
    {

        public override ISector crearSector(ISector s)
        {
            return new ArbolesGrandesDecorator(s);

        }
    




    }
}
