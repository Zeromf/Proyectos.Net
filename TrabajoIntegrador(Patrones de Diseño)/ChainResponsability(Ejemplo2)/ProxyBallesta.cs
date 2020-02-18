using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability_Ejemplo2_
{
    public class ProxyBallesta:IArma
    {
        private ArmaBallesta objetoreal = null;
        private string tipo;

        public ProxyBallesta(string tipo)
        {
            this.tipo=tipo;
  
        
        }

        public override void disparar()
        {
            if (objetoreal == null)
            {
                objetoreal = new ArmaBallesta(tipo);
            }

            objetoreal.disparar();




        }



        public override void setTipo(string n)
        {
            this.tipo = n;
        }
    }
}
