<?php

$nombre= $_POST['nombre'];
echo $nombre;

$apellido= $_POST['apellido'];
echo $apellido ,"<br>";

$email= $_POST['email'];
if (filter_var($email, FILTER_VALIDATE_EMAIL)) {
    echo $email;
}else{

	echo "Direccion de Correo invalida!";	

}


$passwd= $_POST['passwd'];
$passwd2= $_POST['passwd2'];

if ($passwd==$passwd2) {
	echo $passwd,"<br>";
}else{
	echo "Ingrese de vuelta";
}


$fecha= $_POST['fecha'];
if ($fecha<=2000) {
	echo $fecha;

}else{

	echo "No puede ingresar";

}


?>