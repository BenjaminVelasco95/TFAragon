<?php 
include 'conexion.php';

$IE = ( isset( $_POST['ie'] ) ) ? $_POST['ie'] : '';
$Nombre = ( isset( $_POST['nombre'] ) ) ? $_POST['nombre'] : '';
$Apellidos = ( isset( $_POST['apellidos'] ) ) ? $_POST['apellidos'] : '';
$Edad = ( isset( $_POST['edad'] ) ) ? $_POST['edad'] : '';
$Direccion = ( isset( $_POST['direccion'] ) ) ? $_POST['direccion'] : '';
$Telefono = ( isset( $_POST['telefono'] ) ) ? $_POST['telefono'] : '';
$Correo = ( isset( $_POST['correo'] ) ) ? $_POST['correo'] : '';

$funcionboton = ( isset( $_POST['funcion'] ) ) ? $_POST['funcion'] : '';


echo $funcionboton;
echo $IE ;
//Llega
echo $Nombre;
//llega
echo $Apellidos ;
echo $Edad;
//llega
echo $Direccion;
echo $Telefono;
echo $Correo;

#echo $Rol;
#echo $Credencialacceso;
#echo $Claveacceso;

 

switch( $funcionboton )
 {

    case 'btnActualizar':
        $actualizar= $pdo->prepare("UPDATE empleados SET Nombre=:nombre,Apellidos=:apellidos,Edad=:edad,Direccion=:direccion,
         Telefono=:telefono,Correo=:correo  WHERE IE=:IE");


    $actualizar->bindParam( ':IE', $IE );
    $actualizar->bindParam( ':nombre', $Nombre );
    $actualizar->bindParam( ':apellidos', $Apellidos );
    $actualizar->bindParam( ':edad', $Edad );
    $actualizar->bindParam( ':direccion', $Direccion );
    $actualizar->bindParam( ':telefono', $Telefono );
    $actualizar->bindParam( ':correo', $Correo );
    $actualizar->execute();
    break;
 

       case 'btneliminar':
      $eliminar= $pdo->prepare("DELETE FROM empleados WHERE IE=:IE");
      $eliminar->bindParam(':IE', $IE);
      $eliminar->execute();
      break;




         case 'BtnGuardar':
        $guardar = $pdo->prepare("INSERT INTO empleados(IE,nombre,apellidos,edad,direccion,telefono,correo)  VALUES (:IE, :nombre, :apellidos, :edad, :direccion,
          :telefono,:correo)");

      $guardar->bindParam( ':IE', $IE );
      $guardar->bindParam( ':nombre', $Nombre );
      $guardar->bindParam( ':apellidos', $Apellidos );
      $guardar->bindParam( ':edad', $Edad );
      $guardar->bindParam( ':direccion', $Direccion );
      $guardar->bindParam( ':telefono', $Telefono );
      $guardar->bindParam( ':correo', $Correo );
      $guardar->execute();
      break;
 
 
}
header('Location:../Vistas/admin-empleados/principal-ae.php');
$pdo=null;



?>