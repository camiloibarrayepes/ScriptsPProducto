 <?php 

    include("conexion.php");
    $idUserPost = $_POST["idUserPost"];




    $result=mysqli_query($link,"SELECT * FROM user where id='$idUserPost' "); 


    while($row = mysqli_fetch_array($result))                        

    {
    
    	echo $row['poll'];


    }

?>