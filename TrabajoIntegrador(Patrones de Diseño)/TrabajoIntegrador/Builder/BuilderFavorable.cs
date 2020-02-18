using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.FactoryMethod;
using TrabajoIntegrador.DecoratorPrueba;
namespace TrabajoIntegrador.Builder
{
   public class BuilderFavorable:AbstractBuilder
    {
       public override void DecorarSector() {
           Sector = FactorySectores.crearSectores(FactorySectores.DiaLluvioso,Sector);
       
       }




    }
}
