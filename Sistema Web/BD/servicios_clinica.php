<?php 
include 'conexion.php';

$ISER = ( isset( $_POST['iser'] ) ) ? $_POST['iser'] : '';
$Nombre = ( isset( $_POST['nombre'] ) ) ? $_POST['nombre'] : '';
$Costo = ( isset( $_POST['costo'] ) ) ? $_POST['costo'] : '';
$Duracion = ( isset( $_POST['duracion'] ) ) ? $_POST['duracion'] : '';
$Descripcion = ( isset( $_POST['descripcion'] ) ) ? $_POST['descripcion'] : '';

$funcionboton = ( isset( $_POST['funcion'] ) ) ? $_POST['funcion'] : '';


echo $ISER;
echo $Nombre;
//Llega
echo $Costo;
//llega
echo $Duracion ;
echo $Descripcion;




$consulta = $pdo->prepare("SELECT*FROM servicios_clinica");
$consulta->execute();
$listaEmpleados = $consulta->fetchAll(PDO::FETCH_ASSOC);
 


switch( $funcionboton )
 {

    case 'btnActualizar':
        $actualizar= $pdo->prepare(" UPDATE servicios_clinica SET Nombre=:nombre,Costo=:costo,Duracion=:duracion,
        Descripcion=:descripcion WHERE ISER=:ISER");


      $actualizar->bindParam( ':ISER', $ISER );
      $actualizar->bindParam( ':nombre', $Nombre );
      $actualizar->bindParam( ':costo', $Costo );
      $actualizar->bindParam( ':duracion', $Duracion );
      $actualizar->bindParam( ':descripcion', $Descripcion);
      $actualizar->execute();
      header ('Location:../vistas/servicios-aragon/principal.php');
      break;
 
 

       case 'btneliminar':
      $eliminar= $pdo->prepare("DELETE FROM servicios_clinica WHERE ISER=:ISER");
      $eliminar->bindParam(':ISER', $ISER);
      $eliminar->execute();
      header ('Location:../vistas/servicios-aragon/principal.php');
      break;




       case 'BtnGuardar':
        $guardar = $pdo->prepare("INSERT INTO servicios_clinica(ISER,nombre,costo,duracion,descripcion)  
        VALUES (:ISER, :nombre, :costo, :duracion, :descripcion)");

      $guardar->bindParam( ':ISER', $ISER );
      $guardar->bindParam( ':nombre', $Nombre );
      $guardar->bindParam( ':costo', $Costo );
      $guardar->bindParam( ':duracion', $Duracion );
      $guardar->bindParam( ':descripcion', $Descripcion);

      $guardar->execute();
      header ('Location:../vistas/servicios-aragon/principal.php');
      break;


 
}



$pdo=null;
?>