using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Lugares;
namespace TrabajoIntegrador.Observer
{
    public interface IObservador
    {

         void Actualizar(IObservado lugarOberservado);    
        

    }
}
