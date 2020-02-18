using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.DecoratorPrueba;
namespace TrabajoIntegrador.FactoryMethod
{
    class FactoryDiaLluvioso:FactorySectores
    {
        
        
         public int intensidad_lluvia;
         public FactoryDiaLluvioso(int intensidad_lluvia)
        {
            this.intensidad_lluvia = intensidad_lluvia;
        }

        
        
        
        public override ISector crearSector(ISector s) {
            Random intensidad_lluvia = new Random();
            if (intensidad_lluvia.Next()>0)
                return new DiaLluviosoDecorator(s, this.intensidad_lluvia);

            else {

                return s;
            
            
            
            }








        }

       



       
    }
}
