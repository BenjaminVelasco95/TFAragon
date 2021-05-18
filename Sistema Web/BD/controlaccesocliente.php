<?php

//Este codigo detecta si hay o no un usuario activo, e impide el acceso directo a los modulos del
//sistema y lo redirige al login
include 'login.php';

  session_start();
if(!isset($_SESSION['useractivo'])){
  header('Location:../login/principal.php');
   # echo "redirigir al login. no hya usuario activo";
}
else
{
#print_r($_SESSION['useractivo']);
}




?>