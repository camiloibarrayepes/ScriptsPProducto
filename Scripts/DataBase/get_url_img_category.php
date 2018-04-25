<?php     

    

    include("conexion.php");

    $id = $_POST['idPost'];



    $result=mysqli_query($link,"SELECT * FROM categorias where id='$id' "); 

    

    while($row = mysqli_fetch_array($result))                        

    {
    
    	echo $row['urlImg'];


    }
    
?>