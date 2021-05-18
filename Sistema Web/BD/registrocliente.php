<?php 
include 'conexion.php';


$Nombre = ( isset( $_POST['txtnombre'] ) ) ? $_POST['txtnombre'] : '';
$Apellidos = ( isset( $_POST['txtapellidos'] ) ) ? $_POST['txtapellidos'] : '';
$Telefono = ( isset( $_POST['txttelefono'] ) ) ? $_POST['txttelefono'] : '';
$Direccion = ( isset( $_POST['txtdireccion'] ) ) ? $_POST['txtdireccion'] : '';


$Usuario = ( isset( $_POST['txtusuario'] ) ) ? $_POST['txtusuario'] : '';
$Contraseña = ( isset( $_POST['txtpass'] ) ) ? $_POST['txtpass'] : '';
$funcionboton = ( isset( $_POST['funcion'] ) ) ? $_POST['funcion'] : '';


echo $funcionboton;
echo $Contraseña ;
//Llega
echo $Nombre;
//llega
echo $Apellidos ;
#echo $Edad;
//llega
echo $Direccion;
echo $Telefono;
echo $Usuario;

#echo $Rol;
#echo $Credencialacceso;
#echo $Claveacceso;

 

switch( $funcionboton )
 {
         case 'BtnRegistro':
       $guardar = $pdo->prepare("INSERT INTO cliente(nombre,apellidos,telefono,direccion,usuarioacceso,passwordacceso)  
        VALUES (:nombre,:apellidos,:telefono,:direccion,:usuarioacceso,:passwordacceso)");

         #$guardar = $pdo->prepare("INSERT INTO cliente(nombre)  VALUES (:nombre)");
        
     



     $guardar->bindParam( ':nombre', $Nombre );
    $guardar->bindParam( ':apellidos', $Apellidos );
     $guardar->bindParam( ':telefono',$Telefono );
     $guardar->bindParam( ':direccion', $Direccion );
     $guardar->bindParam( ':usuarioacceso', $Usuario);
     $guardar->bindParam( ':passwordacceso', $Contraseña);
     $guardar->execute();

     header('Location:../Vistas/login/principal.php');
      break;

 
}

$pdo=null;



?>