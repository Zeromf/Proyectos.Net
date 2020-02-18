using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.DecoratorPrueba;

namespace TrabajoIntegrador.FactoryMethod
{
    public class FactoryGenteAsustada:FactorySectores
    {
        Random r = new Random();
        public override ISector crearSector(ISector s)
        {
            return new GenteAsustadaDecorator(s,r.Next(30,40));

        }



    }
}
