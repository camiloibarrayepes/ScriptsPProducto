<?php 

include("conexion.php");

$nombre = $_POST["nombrePost"];
$cedula = $_POST["cedulaPost"];
$pass = $_POST['passPost'];
$codigo = $_POST['passPost'];

if (empty($_POST["nombrePost"])){
	echo "falta_nombre";
}elseif(empty($_POST['cedulaPost'])){
	echo "falta_cedula";
}elseif(empty($_POST['codigoPost'])){
	echo "falta_codigo";
}elseif(empty($_POST['passPost'])){
	echo "falta_pass";
	echo gettype($cedula);
}



else{

	$check = mysqli_query($link, "SELECT * FROM asesor WHERE `cedula`='".$cedula."'" );

	$numrows = mysqli_num_rows($check);
	if ($numrows == 0)
	{

		$query = "INSERT INTO asesor (`nombre` ,  `cedula` , `pass`,  `id_c`) VALUES('".$nombre."' ,  '".$cedula."', '".$pass."' ,  '".$codigo."')";
		$resultado = $link->query($query);

		echo "REGISTRO";


	}
	else
	{
		echo "NO";
	}
}

?>
