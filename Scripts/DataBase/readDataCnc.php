<?php     
    
    include("conexion.php");

    $result=mysqli_query($link,"SELECT * FROM concesionario"); 
    
    while($row = mysqli_fetch_array($result))                        
    {
        echo ",".$row['nombre'];
    }
    
    
    
    /*$json_array = array();
    
    while($row = mysqli_fetch_assoc($result))
    {
        $json_array[] = $row;
        
    }*/
    
    //echo json_encode ($json_array);
    
    //echo "camilo";
    
    /*echo "<pre>";
    print_r($json_array);
    echo "</pre>";*/
    
                            
?>