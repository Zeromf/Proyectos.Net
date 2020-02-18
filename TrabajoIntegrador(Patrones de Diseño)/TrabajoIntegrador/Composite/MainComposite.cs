using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Lugares;
namespace TrabajoIntegrador.Composite
{
    class MainComposite
    {

        public static void Run(){
            Console.WriteLine("BARRIO A");
            Console.WriteLine("");

            IILuminable barrioA = new composite("Barrio A");
            IILuminable plazaA1 = new Plaza("plaza A1", 10000);
            IILuminable plazaA2= new Plaza("plaza A2", 20000);

            barrioA.Add(new composite("Manzana A1"));
            barrioA.Add(new composite("Manzana A2"));

            IILuminable manzanaA3=new composite("Manzana A3");
            manzanaA3.Add(plazaA1);
            barrioA.Add(manzanaA3);
            barrioA.Add(new composite("Manzana A4"));
            barrioA.Add(new composite("Manzana A5"));

            IILuminable manzanaA6 = new composite("Manzana A6");
            manzanaA6.Add(plazaA1);
            manzanaA6.Add(plazaA2);

            barrioA.Add(manzanaA6);

            barrioA.Add(new composite("Manzana A7"));
            barrioA.Add(new composite("Manzana A8"));

            IILuminable manzanaA9 = new composite("Manzana A9");
            manzanaA9.Add(plazaA2);
            barrioA.Add(manzanaA9);
                
            Console.WriteLine("Cambiando Lamparas quemadas");
            new Electricista().Revisar(barrioA);
            Console.WriteLine("Lamparas reparadas,el electricista se va a almorzar");
            
 Console.WriteLine("******************************************************************************");
            Console.WriteLine("BARRIO B");
            Console.WriteLine("");

            
            
            
            IILuminable barrioB = new composite("Barrio B");
            IILuminable plazaB1 = new Plaza("plaza B1", 10000);

            barrioB.Add(new composite("Manzana B1"));
            barrioB.Add(new composite("Manzana B2"));

            IILuminable manzanaB3 = new composite("Manzana B3");
            manzanaB3.Add(plazaB1);
            barrioB.Add(manzanaB3);
            barrioB.Add(new composite("Manzana B4"));
            barrioB.Add(new composite("Manzana B5"));
            IILuminable manzanaB6 = new composite("Manzana B6");
            manzanaB6.Add(plazaB1);
            barrioB.Add(manzanaB6);

            IILuminable manzanaB7 = new composite("Manzana B7");
            manzanaB7.Add(plazaB1);
            barrioB.Add(manzanaB7);
            Console.WriteLine("Cambiando Lamparas quemadas");
            new Electricista().Revisar(barrioB);
            Console.WriteLine("Lamparas reparadas,el electricista se va a tomar una siesta");

  Console.WriteLine("******************************************************************************");
            Console.WriteLine("BARRIO C");
            Console.WriteLine("");

            IILuminable barrioC = new composite("Barrio C");
            IILuminable plazaC1 = new Plaza("plaza C1", 10000);
            IILuminable plazaC2 = new Plaza("plaza C2", 20000);

            barrioC.Add(new composite("Manzana C1"));
            barrioC.Add(new composite("Manzana C2"));

            IILuminable manzanaC3 = new composite("Manzana C3");
            manzanaC3.Add(plazaC1);
            manzanaC3.Add(plazaC2);
            barrioC.Add(manzanaC3);

            barrioC.Add(new composite("Manzana C4"));
            barrioC.Add(new composite("Manzana C5"));


            Console.WriteLine("Cambiando Lamparas quemadas");
            new Electricista().Revisar(barrioC);
            Console.WriteLine("Lamparas reparadas,el electricista se va a dormir");

            Console.WriteLine("******************************************************************************");

            Console.WriteLine("BARRIO D");
            Console.WriteLine("");

            IILuminable barrioD = new composite("Barrio D");

            barrioD.Add(new composite("Manzana D1"));
            barrioD.Add(new composite("Manzana D2"));
            barrioD.Add(new composite("Manzana D3"));
            barrioD.Add(new composite("Manzana D4"));
            barrioD.Add(new composite("Manzana D5"));
  
            Console.WriteLine("Cambiando Lamparas quemadas");
            new Electricista().Revisar(barrioD);
            Console.WriteLine("Lamparas reparadas,el electricista termino con el trabajo");

            Console.WriteLine("******************************************************************************");











        }










    }
}
