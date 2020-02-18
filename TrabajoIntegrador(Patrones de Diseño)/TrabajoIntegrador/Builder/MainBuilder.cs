using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Lugares;
using TrabajoIntegrador.Strategy;

namespace TrabajoIntegrador.Builder
{
    public class MainBuilder
    {


        public static void Run()
        {

            //Testing
            Console.WriteLine("Creando escenario del testing....");
            Console.WriteLine("");

            //Escenario
            Director directorBuilderSimple = new Director(new BuilderSimple());
            Director directorBuilderFavorable = new Director(new BuilderFavorable());
            Director directorBuilderDesfavorable = new Director(new BuilderDesfavorable());
            Director directorBuilderMixto = new Director(new BuilderMixto());
            Calle calle = new Calle("Pergamino", 100, 4);
            ILugar casa1 = new Casa(directorBuilderSimple, "Casa De pedro", 200, 89, 4,50);
            ILugar casa2 = new Casa(directorBuilderFavorable,"Casa de Sebastian", 150, 42, 2, 20);
            ILugar plaza1 = new Casa(directorBuilderDesfavorable, "Casa de Enzo", 100, 30,1, 40);
            ILugar plaza2 = new Casa(directorBuilderMixto, "Casa de Ezequiel", 120, 43,20, 90);


            IStrategyApagado estrategiaDeApagado = new StrategiaDeApagadoSecuencial();

            Console.WriteLine("Se han creado: cuatro directores con un constructor diferente cada uno,");
            Console.WriteLine("               cuatro lugares con un director diferente cada uno,");
            Console.WriteLine("               un bombero con estrategia de apagado Secuencial.");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Ejecutando...");
            Console.WriteLine("");


            Console.WriteLine("Test Builder Simple...");
            Console.WriteLine("");
            Bombero bombero1 = new Bombero(estrategiaDeApagado);
            bombero1.Apagarincendio(casa1,calle);
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Presione Enter Para Continuar con los siguientes apagados de incendio!");
            Console.ReadKey(true);
            Console.WriteLine("");

            Console.WriteLine("-------------------------------------------------------------------------");

            Console.WriteLine("Test Builder Favorable...");
            Console.WriteLine("");
            Bombero bombero2 = new Bombero(estrategiaDeApagado);
            bombero2.Apagarincendio(casa2,calle);
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Presione Enter Para Continuar con los siguientes apagados de incendio!");
            Console.ReadKey(true);
            Console.WriteLine("");
           
            Console.WriteLine("-------------------------------------------------------------------------");

            Console.WriteLine("Test Builder Desafavorable...");
            Console.WriteLine("");
            Bombero bombero3 = new Bombero(estrategiaDeApagado);
            bombero3.Apagarincendio(plaza1,calle);
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Presione Enter Para Continuar con los siguientes apagados de incendio!");
            Console.ReadKey(true);
            Console.WriteLine("");
        
            Console.WriteLine("-------------------------------------------------------------------------");

            Console.WriteLine("Test Builder Mixto...");
            Console.WriteLine("");
            Bombero bombero4 = new Bombero(estrategiaDeApagado);
            bombero4.Apagarincendio(plaza2,calle);
            Console.WriteLine("Fin de apagados de Incendios!");
            Console.ReadKey(true);
            Console.WriteLine("");




        
        
        
        }









    }
}
