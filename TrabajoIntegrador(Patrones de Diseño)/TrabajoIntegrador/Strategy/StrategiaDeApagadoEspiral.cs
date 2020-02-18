using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Lugares;

namespace TrabajoIntegrador.Strategy
{
    public class StrategiaDeApagadoEspiral : IStrategyApagado
    {

        public void ApagarIncendio(ILugar lugar, Calle calle)
        {
            Console.WriteLine("El fuego se esta apagando de forma espiral");
        }

   
    }
}
