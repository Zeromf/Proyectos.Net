using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability_Ejemplo2_
{
    class Program
    {
        static void Main(string[] args)
        {
            IArma arma = new ProxyBallesta(null);
            arma.disparar();
            arma = new ProxyCatapulta("");
            arma.disparar();
      


            
           
            
            
            
            
            
            
            
            
            // IArma a = new ProxyArma(arma);

           // a.disparar();
           
            Console.ReadKey();

        }



      /*  public static IArma crearcadenaResponsabilidades(){
            IArma arma = new ArmaBallesta(null);
            arma = new ArmaCatapulta(arma);
            return arma;
        
        
        }*/


    }
}
