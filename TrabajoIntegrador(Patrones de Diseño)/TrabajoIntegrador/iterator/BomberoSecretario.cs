using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Strategy;
namespace TrabajoIntegrador.iterator
{
    public class BomberoSecretario 
    {
        public Bombero bombero { get; set; }
       public BomberoSecretario() {
           bombero = new Bombero(new StrategiaDeApagadoSecuencial());

       }

       public void AtenderDenuncias(IDenuncias denuncias) {
           Iterator iter = denuncias.createIterator();

           while (iter.HasNext())
           {
               DenunciasDeIncendio Actual = (DenunciasDeIncendio)iter.Next();
               Actual.Atender(bombero);
           }

       }







      
    }
}
