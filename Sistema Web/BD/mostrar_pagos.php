<?php 
include 'conexion.php';

$consulta = $pdo->prepare("SELECT*FROM cobros_pagos");
$consulta->execute();
$lista= $consulta->fetchAll(PDO::FETCH_ASSOC);
 
?>