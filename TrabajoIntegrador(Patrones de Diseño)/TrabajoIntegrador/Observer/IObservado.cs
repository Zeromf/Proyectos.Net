using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Lugares;
namespace TrabajoIntegrador.Observer
{
    public interface IObservado
    {

        void AgregarObservador(IObservador bombero);
         void QuitarObservador(IObservador bombero);
         void notificar();


    }
}
