using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajoIntegrador.Observer;
using TrabajoIntegrador.DecoratorPrueba;
using TrabajoIntegrador.Builder;
namespace TrabajoIntegrador.Lugares
{

    public class Casa :ILugar , IPatrullable
    {
    
    
        
        //Constructor con parametros

        public Casa(string nombre, int superficie, int numPuerta, Calle calle)
            : base(nombre, superficie)
        {

            this.calle = calle;
            this.NumPuerta = numPuerta;
        }
        
        
        public Casa(string nombre, int superficie, int numPuerta)
            : base(nombre, superficie)
        {

            this.calle = calle;
            this.NumPuerta = numPuerta;
        }
        
        
        
        
        public Casa(string nombre, int superficie)
            : base(nombre, superficie)
        {
        }
       
        public Casa(string nombre,int superficie,int numPuerta,int cantHabitantes): base(nombre,superficie)
         {
             this.CantHabitantes = cantHabitantes;
             this.NumPuerta = numPuerta;  
              }


         public Casa(string nombre, int superficie, int numPuerta, int cantHabitantes,int probarRiesgo): base(nombre, superficie)
         {
             this.probarRiesgo = probarRiesgo;
             this.CantHabitantes = cantHabitantes;
             this.NumPuerta = numPuerta;  
         }

        //Sobre carga con el parametro del director

         Director director { get; set; } 
        
        public Casa(Director director,string nombre, int superficie, int numPuerta, int cantHabitantes, int probarRiesgo)
             : base(nombre, superficie)
         {
             this.probarRiesgo = probarRiesgo;
             this.CantHabitantes = cantHabitantes;
             this.NumPuerta = numPuerta;
             this.director = director;
         }






         public bool hayAlgoFueraDeLoNormal()
         {
             Random r = new Random();
             r.Next(101);
             return r.Next(101) > probarRiesgo;
         }
            


         public Casa(int superficie) {
             this.Superficie=superficie;

             int n = Convert.ToInt32(Math.Round(Math.Sqrt(superficie)));
             sectores = new ISector[n, n];

             Random r = new Random();

             for (int j = 0; j < sectores.GetLength(0); j++)
             {
                 for (int i = 0; i < sectores.GetLength(1); i++)
                 {
                    
                 }
                 
             }
         }

        //Setters y getters

        public int probarRiesgo { get; set; }

        public int NumPuerta { get; set; }

        public int CantHabitantes { get; set; }

        public int[][] GetSectores()
        {
            Random r = new Random();
            double raiz = Math.Sqrt(this.Superficie);
            int N =(int) Math.Round(raiz);
            int [][] sectores= new int[N][];
            for (int i = 0; i < N; i++ ){
                sectores[i] = new int[N];
                for (int j = 0; j < N ; j++ ){
                    sectores[i][j] = r.Next(101);
                }
            }
            return sectores;
        }
        
        
        
        


    }
}
