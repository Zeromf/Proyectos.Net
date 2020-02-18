using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace TrabajoIntegrador.DecoratorPrueba
{
    public class GenteAsustadaDecorator:Decorator
    {


       private int cantidadPersonas;

       public GenteAsustadaDecorator(ISector componente, int cantidadPersonas)
            : base(componente)
        {

            this.cantidadPersonas = cantidadPersonas;
        }

        
        
        public override void Mojar(int agua)
        {
            Console.WriteLine("Soy una persona asustada");

            this.componente.setporcentajeAfectacion(this.componente.getporcentajeAfectacion() - (agua - cantidadPersonas*0.75));
            
        }







    }
}
