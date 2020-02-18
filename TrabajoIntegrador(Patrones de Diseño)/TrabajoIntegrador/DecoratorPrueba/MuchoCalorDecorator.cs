using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.DecoratorPrueba
{
    class MuchoCalorDecorator:Decorator
    {

        private int temperatura;

        public MuchoCalorDecorator(ISector componente,int temperatura)
            : base(componente)
        {

            this.temperatura = temperatura;
        }

        
        public override void Mojar(int agua)
        {
            Console.WriteLine("Soy calor");

            this.componente.setporcentajeAfectacion(this.componente.getporcentajeAfectacion() - (agua - temperatura*0.1));
        }





    }
}
