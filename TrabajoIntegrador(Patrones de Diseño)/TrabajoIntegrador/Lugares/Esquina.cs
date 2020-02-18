using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Lugares;
using TrabajoIntegrador.Composite;
namespace TrabajoIntegrador
{
    public class Esquina : IPatrullable ,IILuminable
    {


        public Esquina(string nombre) {
            this.Nombre = nombre;

        }

        public Esquina(string nombre,int probarRiesgo) {
            this.Nombre = nombre;
            this.probarRiesgo = probarRiesgo;
        
        }

        int CantidadSemaforos { get; set; }

        int probarRiesgo { get; set; }

        public string Nombre { get; set; }        
        


        public bool hayAlgoFueraDeLoNormal() {
            Random r = new Random();
            r.Next(101);
            return r.Next(101) > probarRiesgo;
       
        }

        public void revisarYcambiarLamparasQuemadas()
        {
            Console.WriteLine("Se estan cambiando la lamparas quemadas en la Esquina" + this.Nombre);

        }

        public void Add(IILuminable iluminable)
        {

        }



    }
}
