using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability_Ejemplo2_
{
    public class ArmaBallesta:IArma
    {


        protected string tipo;

           public ArmaBallesta(String tipo) {
           this.tipo = tipo;
       
       
       }
        public ArmaBallesta(IArma arma) : base(arma) { }

      
        public override void disparar()
        {
            Console.WriteLine("La ballesta esta disparando");
        }

        public override void setTipo(string tipo)
        {
            this.tipo = tipo; ;
        }
    }
}
