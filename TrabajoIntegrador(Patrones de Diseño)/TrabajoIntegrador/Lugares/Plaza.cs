using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Observer;
using TrabajoIntegrador.Composite;
namespace TrabajoIntegrador.Lugares
{
    class Plaza : ILugar,IPatrullable,IILuminable
    {

        public Plaza(string nombre, int superficie)
            : base(nombre, superficie)
        {
        }
        
        public Plaza(string nombre ,int superficie,int probarRiesgo):base(nombre,superficie) {
            this.probarRiesgo = probarRiesgo;
        
        }
        
        public bool hayAlgoFueraDeLoNormal()
        {
            Random r = new Random();
            r.Next(101);
            return r.Next(101) > probarRiesgo;

        }

        public int probarRiesgo { get; set; }
        
        public int SuperficieMcuadrados { get; set; }
        

        public int CantArboles { get; set; }

        public int[][] getSectores()
        {
            Random r = new Random();
            double raiz = Math.Sqrt(this.Superficie);
            int N = (int)Math.Round(raiz);
            int[][] sectores = new int[N][];
            for (int i = 0; i < N; i++)
            {
                sectores[i] = new int[N];
                for (int j = 0; j < N; j++)
                {
                    sectores[i][j] = r.Next(101);
                }
            }
            return sectores;
        }     
       
        public int Cantfarolas { get; set; }

        public void revisarYcambiarLamparasQuemadas() {
            Console.WriteLine("Revisando las farolas: "+this.Nombre);
        
        }


        public void Add(IILuminable iluminable)
        {
        }

        public override string ToString()
        {
            
           return "Plaza: "+ this.Nombre;
        }


    }
}
