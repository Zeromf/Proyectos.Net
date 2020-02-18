using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Lugares;
using TrabajoIntegrador.Command;
using TrabajoIntegrador.iterator;
using TrabajoIntegrador.AbstractFactory;
namespace TrabajoIntegrador
{
    public class Policia:IResponsable
    {
        public Policia(IResponsable r) : base(r) { }


        public Policia() { }


       override public void patrullarCalles(IPatrullable patrullable, Comand comand)
        {

            Patrullero patrulla = new Patrullero();
            Pistola pistola = new Pistola();
           
           
           patrulla.encenderSirena();
            patrulla.Conducir();

            pistola.usar();
            if (patrullable.hayAlgoFueraDeLoNormal())
            {
                comand.Execute();
                
            }

            pistola.guardar();
        
        }

        public void detenerDelincuente() {
            Console.WriteLine("El policia esta deteniendo a los delincuentes");
        
        }






    }
}
