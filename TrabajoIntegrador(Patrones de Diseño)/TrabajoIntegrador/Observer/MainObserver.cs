using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Lugares;
using TrabajoIntegrador.Observer;
using TrabajoIntegrador.Strategy;
namespace TrabajoIntegrador.Observer
{
    public class MainObserver
    {

        public static void Run() {
            ILugar casa = new Casa("Casa de Jose",200,300);
            ILugar casa2 = new Casa("Casa de pedro", 200, 300);
            ILugar casa3 = new Casa("Casa de pablo", 200, 300);
            ILugar casa4 = new Casa("Casa de enzo", 200, 300);
            ILugar casa5 = new Casa("Casa de damian", 200, 300);


            ILugar plaza = new Plaza("Los pilares",500);

            Calle calle = new Calle("Huego",10,10000);
            casa.calle = calle;
            casa.AgregarObservador(new Bombero("Jose"));
            casa.chispa();


            IStrategyApagado Escalera = new StrategiaDeApagadoEscalera();

            Bombero bombero = new Bombero(Escalera);


            plaza.calle = calle;
            plaza.AgregarObservador(new Bombero("Andres"));
            plaza.chispa();

            IStrategyApagado Espiral = new StrategiaDeApagadoSecuencial();

            Bombero bombero2 = new Bombero(Espiral);

      //      bombero2.Apagarincendio(casa2, calle);




        
        }




    }
}
