<?php 
include 'conexion.php';

$consulta = $pdo->prepare("SELECT*FROM servicios_cliente");
$consulta->execute();
$lista= $consulta->fetchAll(PDO::FETCH_ASSOC);
 
?>