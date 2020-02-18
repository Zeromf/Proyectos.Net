using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.iterator
{
    public class IterDenunciaPorTablero:Iterator
    {
        private DenunciasPorTablero denunciasPorTablero;


        int posActual { get; set; }

        List<IDenuncia>Denuncias{get;set;}


        public IterDenunciaPorTablero(IDenuncia denuncia) {
            posActual = 0;


            Denuncias = ((DenunciasPorTablero)denuncia).denuncias;

        }

        public IterDenunciaPorTablero(DenunciasPorTablero denunciasPorTablero)
        {
            this.denunciasPorTablero = denunciasPorTablero;
        }

        public bool HasNext() 
        {
            return posActual < Denuncias.Count;
        }

        public object Next()
        {
            int posicionAux = posActual;
            posActual++;
            return Denuncias[posicionAux];
        }
    }
}
