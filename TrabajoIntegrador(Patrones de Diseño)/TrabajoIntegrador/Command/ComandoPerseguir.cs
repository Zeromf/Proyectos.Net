using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.Command
{
    class ComandoPerseguir:Comand
    {

        Perseguir perseguir;

        public ComandoPerseguir(Perseguir perseguir)
        {
            this.perseguir = perseguir; 
        
        }
        
        public void Execute()
        {
            perseguir.PerseguirDelincuente();

        }
    }
}
