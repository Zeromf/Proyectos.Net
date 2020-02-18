using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Lugares;
namespace TrabajoIntegrador.Strategy
{
    public interface IStrategyApagado
    {

        void ApagarIncendio(ILugar lugar, Calle calle);


       
        
    }
}
