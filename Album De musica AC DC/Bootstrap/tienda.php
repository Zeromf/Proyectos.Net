<!DOCTYPE html>
<html lang="es">
<head>
  <!-- Required meta tags -->
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

  <!-- Bootstrap CSS -->
  <link rel="stylesheet" href="css/bootstrap.min.css" >

  <link rel="stylesheet" href="css/footer.css">

  <title>Tienda-Rockera</title>
  <style>
  .btn-violeta{
    color:#FFFFFF; 
    background-color:#7D3C98  ;


  }

  .btn-violeta:hover{

    background-color: #4A235A;
  }

  
  .fondo{

    background-image: url(img/slider1.2.jpg); 
  display: -ms-flexbox;
  display: block;
  background-size: cover;
    background-repeat: no-repeat;

  }


</style>


</head>
<body>
  <body class="fondo" style="background-color">
 <header>
  <nav class="navbar navbar-expand-lg navbar-dark align-items-center fixed-top" style ="background-color:black"; >
    <a class="navbar-brand" href="index.html">
      <img src="img/logo2.png" width="80" height="50" class="d-inline-block " alt="No se encuentra la imagen">
    </a>




    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse text-center" id="navbarNavAltMarkup">
      <nav class="navbar-nav ml-auto">
        <a class="nav-item nav-link active " href="index.php">Home <span class="sr-only">(current)</span></a>
        <a class="nav-item nav-link" href="ListaCanciones.php">Canciones</a>
        <a class="nav-item nav-link" href="fotos.php">Fotos</a>
        <a class="nav-link" href="tienda.php">Store</a>
        <a class="nav-item nav-link disabled" href="acerca.php">Acerca de</a>
     </nav> 
    </div>
</header>
 

<div class="container mt-5">
  <?php
  $precios=[1=>74.99,2=>74.99,3=>19.99,4=>14.99,5=>39.99,6=>39.99];
  $titulos=[1=>"EMP Signature Collection <br> Capucha con cremallera",2=>"T.N.T. 1975 <br> Cortavientos",3=>"Back in Black <br> Gorra",4=>"Black Ice <br> Camiseta",5=>"EMP Signature Collection <br> Deportivas Altas",6=>"EMP Signature Collection <br> Sudadera"];
  
  $Descripciones=[1=>"Chaqueta con capucha AC/DC de la EMP Signature Collection:<br>
- Bordado delantero
- Estampado delantero, trasero y en mangas
- Parche del logo trasero
- Interior polar
- Capucha con cordel
- Cordeles extra gruesos con topes de metal
- Cremallera con logo
- Puños y cintura elásticos
- Bolsillos insertados laterales
- Aprovecha Antes que Macri Aumente todo
",
2=>"Cortavientos AC/DC :<br>
  - logo a relieve en pecho y espalda
  - interior estampado
  - Dos bolsillos insertados con cremallera
  - Bolsillo delantero con botón automático
  - puños con cremallera
  - cremallera con rayo
  - charreteras con logo 
",3=>"-Talla ajustable con clip de metal
- Circunferencia de 51 a 65 cm
- Rótulo bordado AC/DC delantero
- Rótulo “Back in Black” bordado por detrás
- Visera curva
- Largo de visera: 7 cm
- Seis agujeros de ventilación",
4=>"Esta banda ha demostrado una y otra vez que saben cómo conseguir un éxito en el negocio de la música. Uno de ellos es el álbum Black Ice de 2008, que ahora puedes rememorar con esta fantástica camiseta. El frente presenta el título del álbum con una portada ligeramente modificada.",
5=>"Zapatillas AC/DC de EMP Signature Collection:<br>
- Perfil alto
- Completo estampado exterior e interior
- Lengüeta estampada
- Doble cremallera
- Logo en cremallera
- Puntera de goma
- Ojales de metal
- A elegir entre cordones grises o negros
- Talón reforzado
- Suela exclusiva de EMP 
- Alto de la caña: 11 cm",
6=>"Sudadera AC/DC de la EMP Signature Collection:<br>

- Estampado delantero
- Pin de metal desmontable
- Cuello y bolsillo canguro con bordes abiertos
- Puños y cintura
- Mangas raglan
- Bandas en las mangas
- Cuello barco
- holgado
- Ligera tela sudadera deportiva"];
 
 $enlances=[1=>"https://www.emp-online.es/p/emp-signature-collection/378665.html",2=>"https://www.emp-online.es/p/t.n.t.-1975/381863.html",3=>"https://www.emp-online.es/p/back-in-black/384321.html#sz=60&start=22",4=>"https://www.emp-online.es/p/black-ice/359885.html",5=>"https://www.emp-online.es/p/emp-signature-collection/369929.html#sz=60&start=1",6=>"https://www.emp-online.es/p/emp-signature-collection/373634.html#sz=60&start=51"];

  for($i=1;$i<=6;$i++){
    echo"
  


  <div class=\"row border bg-dark\">
    <div class=\"col-3\"><br><br><br><br><br>
      <img class=\"img-fluid\" src=\"img/fotosV/foto$i.png\">
    </div>
    <div class=\"col-7\"><br><br><br><br><br>
      <h3 class=\"text-white\">$titulos[$i]</h3>
      <p class=\"lead text-white\">$Descripciones[$i]
        </p>
        <h5 class=\"text-white\">€ $precios[$i]</h5>
    </div>
    <div class=\"col-2\"><br><br><br><br><br><br><br>
      <a class=\"btn btn-danger text-white\" href=$enlances[$i] target=\"_blank\">
      Comprar</a>
    </div>
  </div>
";
}
?>

</div>


<footer class="footer bg-black">  
        <div class="container">
         <h6 class="text-white text-center mt-2"> 
          &copy;RockNacional -Todos los Derechos Reservados | 2018.<br>
          contacto: ferreyraenzo26@hotmail.com 

        </h6>
      </div>
    </footer>


        <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
  </body>
  </html>