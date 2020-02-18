using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.TemplateMethod
{
    public abstract class TemplateRCP
    {

        public void EfectuarRCP(IInfartable infar) {
            Console.WriteLine("Patron Template");
            LlamarAmbulancia();
            DescubrirTorax();
            AcomodarCabeza();
            for (int i = 0; i < 5; i++)
            {
                if (!infar.EstaRespirando())
                {
                    CompresionesToraxicas();
                    Insuflaciones();
                    
                }
                if (!infar.tenesRitmoCardiaco())
                {
                    Defibrilar();
                    Console.WriteLine("No Esta respirando ,el infartado no se salvo");
                    break;

                }
                else
                {
                    Console.WriteLine("Esta respirando ,el infartado se salvo");
                    break;
                }
                
            }
            

        }


        public abstract void LlamarAmbulancia();

        public abstract void DescubrirTorax();

        public abstract void AcomodarCabeza();

        public abstract void CompresionesToraxicas();

        public abstract void Insuflaciones();

        public abstract void Defibrilar();









    }
}
