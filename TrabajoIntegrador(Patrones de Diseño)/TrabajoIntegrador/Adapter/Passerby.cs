using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.Adapter
{
   public class Passerby
    {
       
		public Random random = new Random();
		
		private double probConscius, probBrathing, probHeartRate;
		
		public Passerby(double pc, double pb, double phr)
		{
			probConscius = pc; 
			probBrathing = pb;
			probHeartRate = phr;
		}
		
		public bool isConscious(){
			return random.NextDouble() < probConscius;
		}
		
		public bool isBreathing(){
			return random.NextDouble() < probBrathing;
		}
		
		public bool haveHeartRate(){
			return random.NextDouble() < probHeartRate;
		}



    }
}
