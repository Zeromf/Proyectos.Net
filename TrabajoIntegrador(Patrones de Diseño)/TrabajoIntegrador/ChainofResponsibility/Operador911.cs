using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.iterator;

namespace TrabajoIntegrador.ChainofResponsibility
{
   public class Operador911
    {

       
       public IResponsable responsable { get; set; }
       
       public Operador911(IResponsable responsable) {
           this.responsable = responsable;
 
       }


       public void AtenderDenuncias(IDenuncias denuncias) {
           Iterator iter = denuncias.createIterator();


           while (iter.HasNext())
           {
               IDenuncia Actual = (IDenuncia)iter.Next();
               Actual.Atender(responsable);
           }
       
       
       }










    }
}
