using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.DecoratorPrueba
{
   public class DiaLluviosoDecorator:Decorator
    {
       private int _intensidadLluvia;
       private ISector s;
  
       public DiaLluviosoDecorator(ISector componente, int _intensidadLluvia) : base(componente) {
           this._intensidadLluvia = _intensidadLluvia;
       
       }

       public DiaLluviosoDecorator(ISector s)
           : base(s)
       {
           this.s = s;
       }
        
       
       public override void Mojar(int agua)
        {
            Console.WriteLine("Soy una lluvia");

           this.componente.setporcentajeAfectacion(this.componente.getporcentajeAfectacion() - (agua + _intensidadLluvia));
           componente.Mojar(agua);
        }



       //public override string ToString()
       //{

       //    return this.componente.ToString() + "- Dia Lluvioso: " + _intensidadLluvia + "mm";
       
       //}




    }
}
