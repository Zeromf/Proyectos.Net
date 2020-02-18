<!DOCTYPE html>
<html>
<head>

  <!-- Required meta tags -->
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

  <!-- Bootstrap CSS -->
  <link rel="stylesheet" href="css/bootstrap.min.css" >

  <link rel="stylesheet" href="css/footer.css">

  <link rel="stylesheet" href="css/shadowbox.css">

  <script type="text/javascript" src="js/shadowbox.js"></script>

  <script>
  	Shadowbox.init();


  </script>


<title>Fotos</title>
  <style>
  .btn-violeta{
    color:#FFFFFF; 
    background-color:#7D3C98  ;


  }
  .btn-violeta:hover{

    background-color: #4A235A;
  }

  
  .fondo{

  /*background-image: url(img/slider1.1.jpg); */
  display: -ms-flexbox;
  display: block;
  background-size: cover;
   background-repeat: no-repeat;

  }

.pantallacompleta{

	
	height: 100vh;
	background-size: cover;


}

</style>
</head>

<body class="fondo" style="background-color: #000000
">
<header>
  <nav class="navbar navbar-expand-lg navbar-dark align-items-center bg-transparent fixed-top" >
    <a class="navbar-brand" href="index.php">
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

<!-- Inicio de Carousel -->
	<div>

	<div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
  <ol class="carousel-indicators">
    <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="3"></li>
  </ol>
  <div class="carousel-inner ">
    <div class="carousel-item active pantallacompleta" style="background-image: url(img/fotos/foto1.jpg)">
    </div>
    <div class="carousel-item  pantallacompleta" style="background-image: url(img/fotos/foto5.jpg)">
    </div>
    <div class="carousel-item  pantallacompleta" style="background-image: url(img/fotos/foto12.jpg)">
    </div>
    <div class="carousel-item  pantallacompleta" style="background-image: url(img/fotos/foto11.jpg)">
    </div>




  </div>
  <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>
</div>
<!-- Fin De carousel -->
	<br>

	<div class="container" style="background-color: #000000
">
		
<?php



  $archivo_fisico = "contador.txt";
  $archivo_programa = fopen($archivo_fisico, "r+");
  $contador = fgets($archivo_programa, 10);

  $mezclador = $contador % 3;

  $contador++;
  rewind($archivo_programa);
  fputs($archivo_programa, $contador);
  fclose($archivo_programa);



if ($mezclador == 0) {
  echo"


	<div class=\"row\">
		<div class=\"col\">
			   	 <a href=\"img/fotos/foto2-cambio.jpg\" rel=\"shadowbox\"><img onmouseout=\"this.src='img/fotos/GaleriaBN/foto2.1.jpg' ;\"  onmouseover=\"this.src='img/fotos/foto2-cambio.jpg' ;\"class=\"img-fluid\" src=\"img/fotos/GaleriaBN/foto2.1.jpg\"  ></a>
		</div>
	<div class=\"col\">
			   <a href=\"img/fotos/foto6-cambio.jpg\" rel=\"shadowbox\"><img onmouseout=\"this.src='img/fotos/GaleriaBN/foto6.1.jpg' ;\"  onmouseover=\"this.src='img/fotos/foto6-cambio.jpg' ;\" class=\"img-fluid\" src=\"img/fotos/GaleriaBN/foto6.1.jpg\"> 
		</div>
	
	<div class=\"col\">
		<a href=\"img/fotos/foto7-cambio.jpg\" rel=\"shadowbox\"><img onmouseout=\"this.src='img/fotos/GaleriaBN/foto7.1.jpg' ;\"  onmouseover=\"this.src='img/fotos/foto7-cambio.jpg' ;\" class=\"img-fluid\" src=\"img/fotos/GaleriaBN/foto7.1.jpg\"> 

	
	</div>
	
	<div class=\"col\">
			  <a href=\"img/fotos/foto8-cambio.jpg\" rel=\"shadowbox\"><img class=\"img-fluid\" onmouseout=\"this.src='img/fotos/GaleriaBN/foto8.1.jpg';\"  onmouseover=\"this.src='img/fotos/foto8-cambio.jpg' ;\" src=\"img/fotos/GaleriaBN/foto8.1.jpg\"> 
		</div>

	</div>
      
	


	<br>



<div class=\"row\">
	
	<div class=\"col\">
			 <a href=\"img/fotos/foto9-cambio.jpg\" rel=\"shadowbox\"><img onmouseout=\"this.src='img/fotos/GaleriaBN/foto9.1.jpg' ;\"  onmouseover=\"this.src='img/fotos/foto9-cambio.jpg' ;\"  class=\"img-fluid\" src=\"img/fotos/GaleriaBN/foto9.1.jpg\"> </a>
		</div>
	<div class=\"col\">
			
		 <a href=\"img/fotos/foto10-cambio.jpg\" rel=\"shadowbox\"><img onmouseout=\"this.src='img/fotos/GaleriaBN/foto10.1.jpg' ;\"  onmouseover=\"this.src='img/fotos/foto10-cambio.jpg';\"  class=\"img-fluid\" src=\"img/fotos/GaleriaBN/foto10.1.jpg\"></a>
		</div>
	<div class=\"col\">
			   <a href=\"img/fotos/foto13-cambio.jpg\" rel=\"shadowbox\"><img onmouseout=\"this.src='img/fotos/GaleriaBN/foto13.1.jpg';\"  onmouseover=\"this.src='img/fotos/foto13-cambio.jpg';\"  class=\"img-fluid\" src=\"img/fotos/GaleriaBN/foto13.1.jpg\"></a> 
		</div>
	<div class=\"col\">
			  <a href=\"img/fotos/foto3-cambio.jpg\" rel=\"shadowbox\"><img onmouseout=\"this.src='img/fotos/GaleriaBN/foto3.1.jpg';\"  onmouseover=\"this.src='img/fotos/foto3-cambio.jpg';\" class=\"img-fluid\" src=\"img/fotos/GaleriaBN/foto3.1.jpg\"> </a>
		</div>
	</div>
      
";

}else if($mezclador==1){
     
echo"
      <div class=\"row\">
  
  <div class=\"col\">
       <a href=\"img/fotos/foto9-cambio.jpg\" rel=\"shadowbox\"><img onmouseout=\"this.src='img/fotos/GaleriaBN/foto9.1.jpg' ;\"  onmouseover=\"this.src='img/fotos/foto9-cambio.jpg' ;\"  class=\"img-fluid\" src=\"img/fotos/GaleriaBN/foto9.1.jpg\" > </a>
    </div>
  <div class=\"col\">
      
     <a href=\"img/fotos/foto10-cambio.jpg\" rel=\"shadowbox\"><img onmouseout=\"this.src='img/fotos/GaleriaBN/foto10.1.jpg' ;\"  onmouseover=\"this.src='img/fotos/foto10-cambio.jpg' ;\"  class=\"img-fluid\" src=\"img/fotos/GaleriaBN/foto10.1.jpg\"></a>
    </div>
  <div class=\"col\">
         <a href=\"img/fotos/foto13-cambio.jpg\" rel=\"shadowbox\"><img onmouseout=\"this.src='img/fotos/GaleriaBN/foto13.1.jpg' ;\"  onmouseover=\"this.src='img/fotos/foto13-cambio.jpg' ;\"  class=\"img-fluid\" src=\"img/fotos/GaleriaBN/foto13.1.jpg\"></a> 
    </div>
  <div class=\"col\">
        <a href=\"img/fotos/foto3-cambio.jpg\" rel=\"shadowbox\"><img onmouseout=\"this.src='img/fotos/GaleriaBN/foto3.1.jpg' ;\"  onmouseover=\"this.src='img/fotos/foto3-cambio.jpg' ;\"  class=\"img-fluid\"src=\"img/fotos/GaleriaBN/foto3.1.jpg\"> </a>
    </div>
  </div>
  <br>

  <div class=\"row\">
    <div class=\"col\">
           <a href=\"img/fotos/foto2-cambio.jpg\" rel=\"shadowbox\"><img onmouseout=\"this.src='img/fotos/GaleriaBN/foto2.1.jpg' ;\"  onmouseover=\"this.src='img/fotos/foto2-cambio.jpg' ;\"class=\"img-fluid  \" src=\"img/fotos/GaleriaBN/foto2.1.jpg\"  ></a>
    </div>
  <div class=\"col\">
         <a href=\"img/fotos/foto6-cambio.jpg\" rel=\"shadowbox\"><img onmouseout=\"this.src='img/fotos/GaleriaBN/foto6.1.jpg' ;\"  onmouseover=\"this.src='img/fotos/foto6-cambio.jpg' ;\" class=\"img-fluid\" src=\"img/fotos/GaleriaBN/foto6.1.jpg\"> 
    </div>
  
  <div class=\"col\">
    <a href=\"img/fotos/foto7-cambio.jpg\" rel=\"shadowbox\"><img onmouseout=\"this.src='img/fotos/GaleriaBN/foto7.1.jpg' ;\"  onmouseover=\"this.src='img/fotos/foto7-cambio.jpg' ;\" class=\"img-fluid\" src=\"img/fotos/GaleriaBN/foto7.1.jpg\"> 

  
  </div>
  
  <div class=\"col\">
        <a href=\"img/fotos/foto8-cambio.jpg\" rel=\"shadowbox\"><img class=\"img-fluid\" onmouseout=\"this.src='img/fotos/GaleriaBN/foto8.1.jpg' ;\"  onmouseover=\"this.src='img/fotos/foto8-cambio.jpg' ;\" src=\"img/fotos/GaleriaBN/foto8.1.jpg\"> 
    </div>

  </div>
";
  }else{
    echo"


    <div class=\"row\">
    <div class=\"col\">
           <a href=\"img/fotos/foto2-cambio.jpg\" rel=\"shadowbox\"><img onmouseout=\"this.src='img/fotos/GaleriaBN/foto2.1.jpg' ;\"  onmouseover=\"this.src='img/fotos/foto2-cambio.jpg' ;\"class=\"img-fluid  \" src=\"img/fotos/GaleriaBN/foto2.1.jpg\"  ></a>
    </div>
  <div class=\"col\">
         <a href=\"img/fotos/foto6-cambio.jpg\" rel=\"shadowbox\"><img onmouseout=\"this.src='img/fotos/GaleriaBN/foto6.1.jpg' ;\"  onmouseover=\"this.src='img/fotos/foto6-cambio.jpg' ;\" class=\"img-fluid\" src=\"img/fotos/GaleriaBN/foto6.1.jpg\"> 
    </div>
  
  <div class=\"col\">
    <a href=\"img/fotos/foto7-cambio.jpg\" rel=\"shadowbox\"><img onmouseout=\"this.src='img/fotos/GaleriaBN/foto7.1.jpg' ;\"  onmouseover=\"this.src='img/fotos/foto7-cambio.jpg' ;\" class=\"img-fluid\" src=\"img/fotos/GaleriaBN/foto7.1.jpg\"> 

   </div>
</div>

  ";
}






?>
</div>
  <br>


      <footer class="footer">  
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