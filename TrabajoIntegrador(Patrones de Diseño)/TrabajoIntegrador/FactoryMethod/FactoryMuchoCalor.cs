using System;
using TrabajoIntegrador.DecoratorPrueba;
namespace TrabajoIntegrador.FactoryMethod
{
    public  class FactoryMuchoCalor:FactorySectores
    {
        int temperatura;
        public FactoryMuchoCalor(int velocidadDeViento)
        {
            this.temperatura = velocidadDeViento;
        }

       public override ISector crearSector(ISector s)
       {

           Random temperatura = new Random();
            if (temperatura.Next() > 30)
                return new MuchoCalorDecorator(s, this.temperatura);
            else
                return s;

        }






    }
}
