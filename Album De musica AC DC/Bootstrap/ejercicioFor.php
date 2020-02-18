<?php
	//Primer 5 numeros pares 
	for ($i=2; $i <=10 ; $i++) { 
		if ($i%2==0) {
				echo "<br>","Numeros par: ",$i;
			}	
	}
	
	//2° Ejemplo
	for ($i=1; $i <=5 ; $i++) { 
			echo "<br>","Numeros par: ",$i*2;
	}															

	//3 Ejemplo

	for ($i=1; $i<=17 ; $i++) { 
			echo "<br>","imagen",$i,".","jpg";
	}

//Ejercicio 2

for ($i=1; $i<=30 ; $i++) { 
	if ($i%3==0) {
		echo "<br>","Divisible de 3: ",$i+5;
	}elseif ($i%2==0) {
		echo "<br>","Divisible de 2: ",$i*3;
	}else{
		echo "<br>","Numeros comunes: ",$i;


	}
}



?>
