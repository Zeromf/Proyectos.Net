using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.iterator;
using TrabajoIntegrador.TemplateMethod;

namespace TrabajoIntegrador.ChainofResponsibility
{
   public class DenunciaDeInfarto:IDenuncia
    {
       IInfartable infartable;

       public DenunciaDeInfarto(IInfartable infartable) {
           this.infartable = infartable;
       
       }


        public void Atender(IResponsable responsable)
        {
            responsable.atenderInfarto(infartable);
        }
    }
}
