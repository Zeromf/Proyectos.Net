using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.DecoratorPrueba;
namespace TrabajoIntegrador.FactoryMethod
{
   public abstract class FactorySectores
    {
       public const int DiaLluvioso = 1, ArbolesGrandes = 2, DiaVentoso = 3, DiaMuchoCalor = 4, PastoSeco = 5,GenteAsustada =6;
        
       public static ISector crearSectores(int decorado,ISector sector)
        {
            //ISector sector = null ;
            FactorySectores sec = null;
       
            switch (decorado)
            {
                case (DiaLluvioso):
                    sec = new FactoryDiaLluvioso(9);
                    break;

                case (ArbolesGrandes):
                    sec = new FactoryArbolesGrandes();
                    break;

                case (DiaVentoso):
                    sec = new FactoryDiaVentoso(1);
                    break;

                case (DiaMuchoCalor):
                    sec = new FactoryMuchoCalor(30);
                    break;
                case (PastoSeco):
                    sec = new FactoryPastoSeco();
                    break;

                case (GenteAsustada):
                    sec = new FactoryGenteAsustada();
                    break;




	}
            return sec.crearSector(sector);

        }


     public abstract ISector crearSector(ISector s);






    }
}
