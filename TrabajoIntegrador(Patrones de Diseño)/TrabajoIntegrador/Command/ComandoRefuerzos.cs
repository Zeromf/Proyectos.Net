using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.Command
{
    class ComandoRefuerzos:Comand
    {

        Refuerzos refuerzos;

        public ComandoRefuerzos(Refuerzos refuerzos)
        {
            this.refuerzos = refuerzos; 
        
        }
        
        public void Execute()
        {
            refuerzos.PedirRefuerzos();

        }
    }
}
