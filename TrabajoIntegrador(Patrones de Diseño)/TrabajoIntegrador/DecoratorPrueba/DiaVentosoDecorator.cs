using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.DecoratorPrueba
{
    class DiaVentosoDecorator:Decorator
    {
        private int velocidad_viento;
        public DiaVentosoDecorator(ISector componente,int velocidad_viento)
            : base(componente)
        {
            this.velocidad_viento = velocidad_viento;
        }

       
        public override void Mojar(int agua)
        {
            Console.WriteLine("Soy un viento");

            
            this.componente.setporcentajeAfectacion(this.componente.getporcentajeAfectacion() - (agua - Math.Exp(velocidad_viento)));


        }
    }
}
