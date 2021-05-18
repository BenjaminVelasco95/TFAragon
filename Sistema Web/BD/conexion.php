<?php 
 #$server="mysql:dbname=tfaragon;host=localhost";
 #$user="root";
 #$pass="";

$server="mysql:dbname=b6uzer3uyljskeemi0nr;host=b6uzer3uyljskeemi0nr-mysql.services.clever-cloud.com";
$user="uxbxj6okoaaumlr0";
$pass="tZ5XuHvRCMFXxppdCXIU";


 try{
 $pdo=new PDO($server,$user,$pass);
 #echo "Conectado";
 
 }catch(PDOException $e){
     echo "Mal Conectado". $e->getMessage();
 }

?>
