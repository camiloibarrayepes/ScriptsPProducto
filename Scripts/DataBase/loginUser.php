<?php 

include("conexion.php");

$email = $_POST["emailPost"];
$pass = $_POST['passPost'];

if (empty($_POST["emailPost"])){
	echo "falta_email";
}elseif(empty($_POST['passPost'])){
	echo "falta_pass";
}

else{

	$check = mysqli_query($link, "SELECT * FROM user WHERE `email`='".$email."'" );

	$numrows = mysqli_num_rows($check);
	if ($numrows == 1)
	{
        
        while($row = mysqli_fetch_array($check))                        
        {
             if($pass==$row['pass'])
             {
                 $str = "Hello,world,day oo";
                 print_r (explode(",",$str));
                 echo ",acceso,".$row['id'].",".$row['nombre'].",".$row['email'];
             }else{
                 echo "denegado";
             }
             
        }

	}
	else
	{
		echo "NO";
	}
}


?>