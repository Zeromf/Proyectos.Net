using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.AbstractFactory;
using TrabajoIntegrador.Command;
using TrabajoIntegrador.iterator;
using TrabajoIntegrador.Lugares;

namespace TrabajoIntegrador.Proxy
{
    public class PoliciaProxy:IResponsable
    {

        public PoliciaProxy(IResponsable r) : base(r) { }


        public PoliciaProxy() { }


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
