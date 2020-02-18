using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Lugares;

namespace TrabajoIntegrador.iterator
{
   public class DenunciasPorWhatsApp:IDenuncias
    {
      public MensajeWhatsApp mensaje;
      

       public DenunciasPorWhatsApp(MensajeWhatsApp mensaje) {
           this.mensaje = mensaje;
       
       
       }


       public Iterator createIterator()
       {
           return new IterDenunciaPorWhatsApp(this);
       }
    }
}
