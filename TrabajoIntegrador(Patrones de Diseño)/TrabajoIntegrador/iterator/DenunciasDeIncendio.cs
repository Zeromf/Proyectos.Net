 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Lugares;
namespace TrabajoIntegrador.iterator
{
    public class DenunciasDeIncendio: IDenuncia
    {

       public ILugar lugar { get; set; }

        public DenunciasDeIncendio(ILugar lugar){
            this.lugar=lugar;
        
        }

        public void Atender(IResponsable responsable)
        {
            if (responsable is Bombero)
            {
                ((Bombero)responsable).Apagarincendio(lugar,lugar.calle);
            }

            //((Bombero)i).Apagarincendio(lugar, lugar.calle);
        }

        public Iterator crearIter()
        {
            return null;
        }









  
    }
}
