using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.AbstractFactory;
using TrabajoIntegrador.AbstractFactory.Herramientas;
using TrabajoIntegrador.Composite;
using TrabajoIntegrador.iterator;

namespace TrabajoIntegrador.Proxy
{
   public class ElectricistaProxy:IResponsable
    {
        public ElectricistaProxy(IResponsable r) : base(r) { }


        public ElectricistaProxy() { }


        
        override public void Revisar(IILuminable ilu) {
            Camioneta c = new Camioneta();
            Buscapolo b = new Buscapolo();

            c.encenderSirena();
            c.Conducir();

           b.usar();

            Console.WriteLine("El Electricista esta revisando los cables");
            ilu.revisarYcambiarLamparasQuemadas();


            b.guardar();
        }















    }
}
