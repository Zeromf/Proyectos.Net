using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.TemplateMethod
{
    public class RCP1:TemplateRCP
    {


        public override void LlamarAmbulancia()
        {
            Console.WriteLine("Llamando Ambulancia");
        }

        public override void DescubrirTorax()
        {
            Console.WriteLine("Descubrir Torax");
        }

        public override void AcomodarCabeza()
        {
            Console.WriteLine("Acomodando Cabeza");
        }

        public override void CompresionesToraxicas()
        {
            Console.WriteLine("Compresiones Toraxicas");
        }

        public override void Insuflaciones()
        {
            Console.WriteLine("Insuflaciones");
        }

        public override void Defibrilar()
        {
            Console.WriteLine("Defibrilar");
        }
    }
}
