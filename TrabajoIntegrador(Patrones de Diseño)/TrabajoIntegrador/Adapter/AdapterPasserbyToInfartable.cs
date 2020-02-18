using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.TemplateMethod;

namespace TrabajoIntegrador.Adapter
{

    public class AdapterPasserbyToInfartable:IInfartable
    {


        private Passerby passerby;

       public AdapterPasserbyToInfartable(Passerby passerby)
        {

            this.passerby = passerby;
 
        }


        public bool EstaConciente()
        {
            return passerby.isConscious();
        }

        public bool EstaRespirando()
        {
            return passerby.isBreathing();
        }

        public bool tenesRitmoCardiaco()
        {
            return passerby.haveHeartRate();
        }
    }
}
