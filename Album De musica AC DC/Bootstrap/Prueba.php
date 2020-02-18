<?php
$Dia=900;
$numero1=6;
$numero2=50;


	if ($numero2>$numero1) {
		echo"El numero mayor es el: <br>",$numero2;
	}else{

	echo"El numero mayor es el:",$numero1;			
		}
			
			


	if ($Dia >=1 && $Dia<=31) {
	 	echo"El dia es valido <br>";


 	}else{

 		echo "Dia invalido <br>";		
 		}

	if ($Dia >=1 && $Dia<=31) {
		echo $numero1*$numero2;


	}elseif ($numero1 > $numero2) {
			echo $numero1+$numero2;

	}else{
		echo "Si compras milanesas de soja,ahorras plata y tambien estas haciendo dieta <br>";
		
	}

	//Cuadrado de 100 Numeros
	/*for ($i=1; $i <=100 ; $i++) { 
		echo $i*$i;		
	}*/

	//100 Numeros Pares
	for ($i=1; $i <=100 ; $i++) { 
		if ($i%2==0) {
				echo "<br>",$i;
			}	
	}



?>