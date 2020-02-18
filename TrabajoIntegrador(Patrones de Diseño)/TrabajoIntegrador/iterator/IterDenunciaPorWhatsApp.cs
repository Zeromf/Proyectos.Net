using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.iterator
{
    public class IterDenunciaPorWhatsApp: Iterator
    {

        MensajeWhatsApp mensaje;


        public IterDenunciaPorWhatsApp(DenunciasPorWhatsApp denuncias)
        {
            this.mensaje = denuncias.mensaje;
      
        }

       
        public bool HasNext()
        {
            return mensaje != null;
        }

        public object Next()
        {

            MensajeWhatsApp actual = mensaje;
            this.mensaje = mensaje.siguiente;
            return actual.denuncia;

        }

    
    }
}
