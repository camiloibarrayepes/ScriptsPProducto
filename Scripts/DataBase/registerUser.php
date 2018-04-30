<?php 

include("conexion.php");

$nombre = $_POST['nombrePost'];
$email = $_POST['emailPost'];
$pass_one = $_POST['passPost'];
$pass = md5($pass_one);


$check = mysqli_query($link, "SELECT * FROM user WHERE `email`='".$email."'" );

$numrows = mysqli_num_rows($check);
if ($numrows == 0)
{
	$query = "INSERT INTO user (`nombre` ,  `email` , `pass`) VALUES('".$nombre."' ,  '".$email."', '".$pass."')";
$resultado = $link->query($query);

echo "REGISTRO";


}
else
{
	die("User allready exists!");
}

?>