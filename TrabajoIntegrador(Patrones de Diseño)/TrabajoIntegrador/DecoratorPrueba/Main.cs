using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Lugares;
using TrabajoIntegrador.Strategy;
using TrabajoIntegrador.DecoratorPrueba;
namespace TrabajoIntegrador.DecoratorPrueba
{
    class Main
    {

        public static void Run() {

            ILugar casa = new Casa("Chalet",50,456);

            Bombero bombero = new Bombero("Enzo");

            bombero.Strategy = new StrategiaDeApagadoEscalera();

            casa.calle = new Calle("Huergo",20,40);




            for (int i = 0; i < casa.getSectores().GetLength(0); i++)
            {
                for (int j = 0; j < casa.getSectores().GetLength(0); j++)
                {
                    ISector sector = casa.getSectores()[j,i];

                    sector = DecorarSector(sector,casa.calle.CaudalAguaporMinu,35,80);


                    casa.sectores[j , i]=sector;
                }
            }
            bombero.Apagarincendio(casa, casa.calle);




        }

        public static ISector DecorarSector(ISector sector , int temperatura , int caudal,int s ) {
            return new PastoSecoDecorator(new MuchoCalorDecorator(sector, 35));
        
        
        
        
        
        
        
        }




    }
}
