<?php 
include 'conexion.php';

$consulta = $pdo->prepare("SELECT*FROM expedientecliente");
$consulta->execute();
$lista= $consulta->fetchAll(PDO::FETCH_ASSOC);
 
?>