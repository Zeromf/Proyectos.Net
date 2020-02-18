using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability_Ejemplo2_
{
    public abstract class IArma
    {
       IArma sucesor = null;
 
        public IArma(){}
       public IArma(IArma sucesor)
        {
            this.sucesor=sucesor;
       
        }

     
       virtual  public  void disparar()
        {
            if (this.sucesor != null)
            {
                this.sucesor.disparar();
            }
           

        }

       public abstract void setTipo(string n);
        


    }
}
