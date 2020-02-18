using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.iterator
{
    public class MensajeWhatsApp
    {

       public IDenuncia denuncia;

        public MensajeWhatsApp siguiente;

        public MensajeWhatsApp(IDenuncia denuncia,MensajeWhatsApp siguiente) {
            this.denuncia = denuncia;
            this.siguiente = siguiente;
     
        }







    }
}
