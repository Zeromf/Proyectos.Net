using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.Command
{
    class ComandoAlto:Comand
    {

        DarAlto darAlto;

        public ComandoAlto(DarAlto darAlto) {
            this.darAlto = darAlto; 
        
        }

        public void Execute()
        {
            darAlto.Alto();

        }
    }
}
