<?php 
include 'conexion.php';

$consulta = $pdo->prepare("SELECT*FROM cliente");
$consulta->execute();
$lista= $consulta->fetchAll(PDO::FETCH_ASSOC);
 
?>