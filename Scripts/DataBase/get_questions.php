<?php     

    

    include("conexion.php");

    $id = $_POST['idPost'];



    $result=mysqli_query($link,"SELECT * FROM q_categorias where id_categoria='$id' "); 

    

    while($row = mysqli_fetch_array($result))                        

    {
    
    	echo $row['pregunta'].",";


    }
    
?>