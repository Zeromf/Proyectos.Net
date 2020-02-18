using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.Composite
{
    public class composite:IILuminable
    {
        private List<IILuminable> h = new List<IILuminable>();

        public string Nombre { get; set; }
        public override string ToString()
        {
            return Nombre;
        }

        public composite(string nombre) {
            this.Nombre = nombre;
        
        }

        public void Add(IILuminable iluminable)

        {
            h.Add(iluminable);

        }

        public void revisarYcambiarLamparasQuemadas()
        {
            Console.WriteLine("Se estan cambiando la lamparas quemadas del composite : "+ this.Nombre);

            foreach (IILuminable i in h)
            {
                i.revisarYcambiarLamparasQuemadas();

            }

        }







    }
}
