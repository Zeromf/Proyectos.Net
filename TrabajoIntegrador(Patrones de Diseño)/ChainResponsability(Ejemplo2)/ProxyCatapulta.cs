using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability_Ejemplo2_
{
    public class ProxyCatapulta:IArma
    {

         private ArmaCatapulta objetoreal = null;
        private string tipo{get;set;}

        public ProxyCatapulta(string tipo)
        {
            this.tipo=tipo;
  
        
        }

        
        public override void disparar(){
            if (objetoreal==null)
            {
                objetoreal = new ArmaCatapulta(tipo);
            }

            objetoreal.disparar();
        
        
        
        
        }



        public override void setTipo(string n)
        {
            this.tipo = n;
        }



    }
}
