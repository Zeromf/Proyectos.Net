using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.iterator
{
    class IterDenunciaPorMostrador:Iterator
    {
        DenunciasPorMostrador denuncia;

        int contador = 0;

        public IterDenunciaPorMostrador(DenunciasPorMostrador denuncia) {
            this.denuncia = denuncia;
      
        }
        
        
        public bool HasNext()
        {
            return contador < 1;



        }

        public object Next()
        {
            contador++;
            return denuncia;
        }
    }
}
