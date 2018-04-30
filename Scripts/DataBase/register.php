<?php 

include("conexion.php");

$nombre = $_POST['nombrePost'];
$email= $_POST['emailPost'];
$pass_one = $_POST['passPost'];
$pass = md5($pass_one);
$codigo = $_POST['codigoPost'];

if(empty($_POST['nombrePost'])){
    echo "NOMBRE";
}else if(empty($_POST['emailPost'])){
    echo "EMAIL";
}else if(empty($_POST['passPost'])){
    echo "PASS";
}else if(empty($_POST['codigoPost'])){
    echo "CODIGO";
}


else{


$check = mysqli_query($link, "SELECT * FROM asesor WHERE `email`='".$email."'" );

$numrows = mysqli_num_rows($check);

$numrows;

if ($numrows == 0)
{
	$query = "INSERT INTO asesor (`nombre` ,  `email` , `pass`, `id_c`) VALUES('".$nombre."' ,  '".$email."', '".$pass."', '".$codigo ."')";

$resultado = $link->query($query);

echo "REGISTRO";


}
else
{
	die("NO");
}

}

?>