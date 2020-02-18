using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Lugares;
using TrabajoIntegrador.Strategy;
namespace TrabajoIntegrador.Strategy
{
    class MainStrategy
    {
        public static void Run() {
            Console.WriteLine("Estrategia de Apagado Secuencial");
            Console.WriteLine("");
            ILugar casa = new Casa("Chalet", 100, 50);
            Bombero bombero = new Bombero("Enzo");
            bombero.Strategy = new StrategiaDeApagadoSecuencial();
            Calle calle = new Calle("Huergo", 5, 2);
            bombero.Apagarincendio(casa, calle);
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Estrategia de Apagado Escalera");
            Console.WriteLine("");
            ILugar casa2 = new Casa("Rancho", 20, 300);
            Bombero bombero2 = new Bombero("Pedro");
            bombero.Strategy = new StrategiaDeApagadoEscalera();
            casa2.calle = new Calle("Huergo", 30, 200);
            bombero.Apagarincendio(casa2, casa2.calle);
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Estrategia de Apagado Espiral");
            Console.WriteLine("");
            ILugar casa3 = new Casa("Cabaña", 30, 456);
            Bombero bombero3 = new Bombero("Alberto");
            bombero.Strategy = new StrategiaDeApagadoEspiral();
            casa3.calle = new Calle("Huergo", 40, 200);
            bombero.Apagarincendio(casa3, casa3.calle);
           
            


            
            /*ILugar casa=new Casa(100);
            Calle calle=new Calle(90,60);
            Bombero bombero = new Bombero();
            bombero.Apagarincendio(casa,calle);
            bombero.StrategyApagadoEspiral();
            bombero.Apagarincendio(casa, calle);
            */
        
        }






    }
}
