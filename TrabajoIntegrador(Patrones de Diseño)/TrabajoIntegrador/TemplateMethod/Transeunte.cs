using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.TemplateMethod
{
    public class Transeunte:IInfartable
    {

        public Transeunte() { }

        int probabilidad = 70;
        public bool EstaConciente()
        {
            Random r = new Random();
            return r.Next() < probabilidad;
        }

        public bool EstaRespirando()
        {
            Random r = new Random();
            return r.Next() < probabilidad;
        }

        public bool tenesRitmoCardiaco()
        {
            Random r = new Random();
            return r.Next() < probabilidad;
        }
    }
}
