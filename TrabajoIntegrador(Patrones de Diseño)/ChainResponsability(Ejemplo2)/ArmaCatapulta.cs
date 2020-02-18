using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability_Ejemplo2_
{
   public class ArmaCatapulta:IArma
    {



       protected string tipo;


       public ArmaCatapulta(IArma arma):base(arma) { }

       public ArmaCatapulta(String tipo) {
           this.tipo = tipo;
       
       
       }




       public ArmaCatapulta(){ }
        public override void disparar()
        {
            Console.WriteLine("La catapulta esta disparando");
        }

        public override void setTipo(string tipo)
        {
            this.tipo = tipo;
        }
    }
}
