using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.TemplateMethod
{
   public  class MainTemplate
    {
       public static void Run() {

           Medico medico = new Medico();

           IInfartable infartable = new Transeunte();

           medico.atenderInfarto(infartable);

        
       
       
       
       
       
       }















    }
}
