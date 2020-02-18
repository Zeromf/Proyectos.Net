using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Adapter;
using TrabajoIntegrador.iterator;
using TrabajoIntegrador.Lugares;
using TrabajoIntegrador.Proxy;
using TrabajoIntegrador.TemplateMethod;
namespace TrabajoIntegrador.ChainofResponsibility
{
    public class MainChain
    {


        public static void Run() {
         
            Medico medico = new Medico();
       /*     medico.atenderDesmayo();
            Policia policia = new Policia();
            policia.detenerDelincuente();
         */   Electricista electricista = new Electricista();


            
            IResponsable responsable = crearCadenaDeResponsabilidades();

            Operador911 op = new Operador911(responsable);

            MensajeWhatsApp lista = null;

            Calle calle = new Calle("San martin", 10000, 10);

            Passerby passerby = new Passerby(70, 70, 70);
            
     

            
          lista = new MensajeWhatsApp(new DenunciaDeInfarto(new AdapterPasserbyToInfartable(passerby)), lista);
          lista = new MensajeWhatsApp(new DenunciaDeInfarto(new Transeunte()), lista);

            lista = new MensajeWhatsApp(new DenunciaDeRobo(new Casa("Rodrigo", 100, 80,calle)), lista);
            lista = new MensajeWhatsApp(new DenunciaDeRobo(new Casa("Enzo", 200, 40, calle)), lista);
            lista = new MensajeWhatsApp(new DenunciaDeRobo(new Casa("Juan", 260, 57, calle)), lista);
          
            lista = new MensajeWhatsApp(new DenunciaDeLamparaQuemada(calle), lista);
            lista = new MensajeWhatsApp(new DenunciaDeLamparaQuemada(calle), lista);
            lista = new MensajeWhatsApp(new DenunciaDeLamparaQuemada(calle), lista);
            lista = new MensajeWhatsApp(new DenunciaDeLamparaQuemada(calle), lista);
            lista = new MensajeWhatsApp(new DenunciaDeLamparaQuemada(calle), lista);

            DenunciasPorWhatsApp denuncias = new DenunciasPorWhatsApp(lista);

           
            op.AtenderDenuncias(denuncias);



        }



        private static IResponsable crearCadenaDeResponsabilidades() {
            IResponsable r = new Electricista(null);
            r = new BomberoProxy(r);
    //        r = new Medico(r);
     //       r = new Policia(r);
            return r;
        
        } 






    }
}
