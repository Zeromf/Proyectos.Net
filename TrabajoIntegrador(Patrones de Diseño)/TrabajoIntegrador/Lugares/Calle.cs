using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Composite;
using TrabajoIntegrador.Lugares;
namespace TrabajoIntegrador
{
   public class Calle : IILuminable
    {
        private float longitudmetros;
        private int cantfarolas;
        private int caudalAguaporMinu;


       public Calle(string nombre,int caudalAguaporMinu, int cantfarolas)
        {
            this.nombre = nombre;
            this.caudalAguaporMinu = caudalAguaporMinu;
            this.cantfarolas = cantfarolas;

        }


        public Calle(int caudalAguaporMinu)
        {

            this.caudalAguaporMinu = caudalAguaporMinu;
            this.cantfarolas = Cantfarolas;

        }


        public string nombre { get; set; }

       public float LongitudMetros
        {
            get { return longitudmetros; }
            set { longitudmetros = LongitudMetros; } 
        }

        
        public int Cantfarolas
        {
            get { return cantfarolas; }
            set { cantfarolas = Cantfarolas; }
        }
       

        public int CaudalAguaporMinu
        {
            get { return caudalAguaporMinu; }
            set { caudalAguaporMinu = CaudalAguaporMinu; }
        }

        public int getCaudalAguaPorMinu() {
            return this.caudalAguaporMinu;
        
        
        
        }
        




        public void chispa()
        {
            Console.WriteLine("Hubo una chispa,sonando alarma");

        }


        public void revisarYcambiarLamparasQuemadas()
        {
            Console.WriteLine("Se estan cambiando la lamparas quemadas en la calle"+this.nombre);

        }

        public void Add(IILuminable iluminable)
        {

        }



      
    }
}
