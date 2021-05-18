<?php 
include 'conexion.php';

$consulta = $pdo->prepare("SELECT*FROM gastos_empresa");
$consulta->execute();
$lista= $consulta->fetchAll(PDO::FETCH_ASSOC);
 
?>