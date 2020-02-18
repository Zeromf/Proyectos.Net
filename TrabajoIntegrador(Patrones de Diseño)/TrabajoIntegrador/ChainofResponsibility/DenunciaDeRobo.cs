using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Command;
using TrabajoIntegrador.iterator;
using TrabajoIntegrador.Lugares;

namespace TrabajoIntegrador.ChainofResponsibility
{
    public class DenunciaDeRobo:IDenuncia
    {
       IPatrullable patrullable;
       public DenunciaDeRobo(IPatrullable patrullable)
       {
            this.patrullable = patrullable;

        }

        
        
        public void Atender(IResponsable responsable)
        {

            responsable.patrullarCalles(patrullable,new ComandoAlto(new DarAlto())); 



        }




    }
}
