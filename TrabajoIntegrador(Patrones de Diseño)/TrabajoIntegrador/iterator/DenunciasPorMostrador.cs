using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Lugares;

namespace TrabajoIntegrador.iterator
{
    public class DenunciasPorMostrador:IDenuncias
    {
        public IDenuncia denuncias { get; set; }
        ILugar lugar;
       
        public DenunciasPorMostrador(ILugar lugar) {
            this.lugar = lugar; 
        }


        public void AtenderDenuncias(IResponsable i)
        {
        }



        public Iterator createIterator()
        {
            return new IterDenunciaPorMostrador(this);
        }

    
    }
}
