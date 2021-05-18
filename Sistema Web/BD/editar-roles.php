<?php 
include 'conexion.php';
$IE = ( isset( $_POST['ie'] ) ) ? $_POST['ie'] : '';

$Rol = ( isset( $_POST['rol'] ) ) ? $_POST['rol'] : '';
$Usuario = ( isset( $_POST['claveacceso'] ) ) ? $_POST['claveacceso'] : '';
$Clave = ( isset( $_POST['credencialacceso'] ) ) ? $_POST['credencialacceso'] : '';
$funcionboton = ( isset( $_POST['funcion'] ) ) ? $_POST['funcion'] : '';






echo $Clave;
echo $IE;
echo $Rol;
echo $Usuario ;
echo $funcionboton;


 

switch( $funcionboton )
 {

          case 'btnActualizarRol':
          $actualizar= $pdo->prepare("UPDATE empleados SET Rol=:rol,Credencialacceso=:credencialacceso,Claveacceso=:claveacceso WHERE IE=:IE");

         
    $actualizar->bindParam(':IE', $IE );
    $actualizar->bindParam(':rol',$Rol);
    $actualizar->bindParam(':credencialacceso',$Usuario);
    $actualizar->bindParam(':claveacceso',$Clave);
    $actualizar->execute();
    break;
 

        /* case 'BtnGuardar':
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
      break;*/
 
 
}
header('Location:../Vistas/roles/principal.php');
$pdo=null;



?>