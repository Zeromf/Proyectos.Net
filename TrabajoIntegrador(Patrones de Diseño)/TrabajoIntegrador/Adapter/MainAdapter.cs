using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.TemplateMethod;

namespace TrabajoIntegrador.Adapter
{
    public class MainAdapter
    {
        public static void Run()
        {
            Medico medico = new Medico();

            Passerby passerby = new Passerby(70, 70, 70);

            IInfartable infartable = new AdapterPasserbyToInfartable(passerby);

            medico.atenderInfarto(infartable);

        }

    }
}
