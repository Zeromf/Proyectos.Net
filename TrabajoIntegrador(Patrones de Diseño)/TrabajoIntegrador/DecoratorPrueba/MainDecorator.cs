using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.DecoratorPrueba
{
    class MainDecoratorPrueba
    {

        public static void Run() {
            
            ISector sector = new Sector();
            sector.setporcentajeAfectacion(100);
            Console.WriteLine(sector.ToString());



            //sector = new MuchoCalorDecorator(sector,35);
            //sector = new DiaVentosoDecorator(sector,200);
            //sector=new PastoSecoDecorator(sector);
            sector.Mojar(20);
            Console.WriteLine(sector.ToString());





        
        }




    }
}
