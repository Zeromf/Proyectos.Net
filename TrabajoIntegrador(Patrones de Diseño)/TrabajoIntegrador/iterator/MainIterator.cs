using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Lugares;
using TrabajoIntegrador.ChainofResponsibility;
using TrabajoIntegrador.TemplateMethod;
using TrabajoIntegrador.Adapter;

namespace TrabajoIntegrador.iterator
{
   public class MainIterator
    {




       public static void Run() {
        

           MensajeWhatsApp lista = null;

           Calle calle = new Calle("San martin",10000,10);
           lista = new MensajeWhatsApp(new DenunciasDeIncendio(new Casa("Pablo", 100, 80,calle)), lista);
           lista = new MensajeWhatsApp(new DenunciasDeIncendio(new Casa("Jose", 100, 80,calle)), lista);
           lista = new MensajeWhatsApp(new DenunciasDeIncendio(new Casa("Pedro", 100, 80,calle)), lista);
           lista = new MensajeWhatsApp(new DenunciasDeIncendio(new Casa("Ezequiel", 100, 80,calle)), lista);
           lista = new MensajeWhatsApp(new DenunciasDeIncendio(new Casa("Rodrigo", 100, 80,calle)), lista);


     
           DenunciasPorWhatsApp denuncias = new DenunciasPorWhatsApp(lista);

           Iterator iter = denuncias.createIterator();


           while (iter.HasNext())
           {

              IDenuncia denuncia=((IDenuncia)iter.Next());
              denuncia.Atender(new Bombero("Julian"));
           }


       }






    }
}
