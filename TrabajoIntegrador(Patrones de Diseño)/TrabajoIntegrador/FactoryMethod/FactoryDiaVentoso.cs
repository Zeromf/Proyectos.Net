using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.DecoratorPrueba;
namespace TrabajoIntegrador.FactoryMethod
{
   public class FactoryDiaVentoso:FactorySectores
    {

        public int velocidadViento;
        public FactoryDiaVentoso(int velocidadDeViento)
        {
            this.velocidadViento = velocidadDeViento;
        }




        public override ISector crearSector(ISector s)
        {
            Random velocidadViento = new Random();

            if (velocidadViento.Next() > 0)
                return new DiaVentosoDecorator(s, this.velocidadViento);
            else {

                return s;
            
            
            }







        }










    }
}
