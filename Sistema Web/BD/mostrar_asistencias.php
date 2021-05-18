<?php 
include 'conexion.php';

$consulta = $pdo->prepare("SELECT*FROM entradas_salidas");
$consulta->execute();
$lista= $consulta->fetchAll(PDO::FETCH_ASSOC);
 
?>