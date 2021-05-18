<?php 
include 'conexion.php';

$consulta = $pdo->prepare("SELECT count(*) totalempleados FROM empleados");
$consulta->execute();
$lista= $consulta->fetch(PDO::FETCH_ASSOC);

$totaldatos=$lista['totalempleados'];




$consulta = $pdo->prepare("SELECT count(*) totalclientes FROM cliente");
$consulta->execute();
$lista= $consulta->fetch(PDO::FETCH_ASSOC);

$clientes=$lista['totalclientes'];




$consulta = $pdo->prepare("SELECT count(*) totalexpedientes FROM  expedientecliente");
$consulta->execute();
$lista= $consulta->fetch(PDO::FETCH_ASSOC);

$expedientes=$lista['totalexpedientes'];



$consulta = $pdo->prepare("SELECT count(*) servicios FROM   servicios_cliente");
$consulta->execute();
$lista= $consulta->fetch(PDO::FETCH_ASSOC);

$serviciostotales=$lista['servicios'];



$consulta = $pdo->prepare("SELECT count(*) gastos FROM  gastos_empresa");
$consulta->execute();
$lista= $consulta->fetch(PDO::FETCH_ASSOC);

$gastostotales=$lista['gastos'];







 
?>