using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Composite;
using TrabajoIntegrador.iterator;

namespace TrabajoIntegrador.ChainofResponsibility
{
    public class DenunciaDeLamparaQuemada:IDenuncia
    {
        IILuminable iluminable;
        public DenunciaDeLamparaQuemada(IILuminable iluminable) {
            this.iluminable = iluminable;
        
        
        }



        public void Atender(IResponsable responsable)
        {

            responsable.Revisar(iluminable);


        }
    }
}
