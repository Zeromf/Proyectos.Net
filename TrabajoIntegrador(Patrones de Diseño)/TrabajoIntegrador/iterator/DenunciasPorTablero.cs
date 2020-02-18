using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Observer;
using TrabajoIntegrador.Lugares;
namespace TrabajoIntegrador.iterator
{
    public class DenunciasPorTablero:IDenuncias,IObservador
    {
        public List<IDenuncia> denuncias { get; set; }

        public DenunciasPorTablero(List<IDenuncia> denuncias){
            this.denuncias = denuncias;
        

        }


        public Iterator createIterator()
        {
            return new IterDenunciaPorTablero(this);
        }





        
        public void Actualizar(IObservado o) {

            denuncias.Add(new DenunciasDeIncendio((ILugar)o));
   
        }


        public void Atender(IResponsable i) { 
  
        }



    
    }
}
