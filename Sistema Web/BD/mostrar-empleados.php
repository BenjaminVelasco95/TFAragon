<?php 
include 'conexion.php';

$consulta = $pdo->prepare("SELECT*FROM empleados");
$consulta->execute();
$listaEmpleados = $consulta->fetchAll(PDO::FETCH_ASSOC);
 
?>