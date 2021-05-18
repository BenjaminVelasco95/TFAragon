<?php 
include 'conexion.php';



$Usuario = ( isset( $_POST['UsuArio'] ) ) ? $_POST['UsuArio'] : '';
$Clave = ( isset( $_POST['PassWord'] ) ) ? $_POST['PassWord'] : '';
$funcionboton = ( isset( $_POST['funcion'] ) ) ? $_POST['funcion'] : '';

echo $Usuario;
echo $Clave;
#echo $funcionboton;




 

switch($funcionboton)
 {


          case 'btningreso':
   
            $dato= $pdo->prepare("SELECT * FROM empleados  WHERE 
            credencialacceso=:credencialacceso AND claveacceso=:claveacceso");

              $dato->bindParam( ':credencialacceso',$Usuario,PDO::PARAM_STR);
              $dato->bindParam( ':claveacceso',$Clave,PDO::PARAM_STR);
              $dato->execute();
              $ResDato=$dato->fetch(PDO::FETCH_ASSOC); //fetch assoc da la informacion del usuario
             # print_r($ResDato); 

         

              if($ResDato['rol']=='Administrador'){ 
                session_start();
                $_SESSION['adminactivo']=$ResDato;   

                #echo "administrador";

               header('Location:../vistas/home/principal.php');
              
              }else
              if($ResDato['rol']=='Empleado'){ 
            
                session_start();
                $_SESSION['empleadoactivo']=$ResDato; 
                #echo "empleado";
               header('Location:../vistas/dashboardempleado/servicios-aragon/principal.php');
              }    

              else{
                echo "no hay datos";
              header('Location:../vistas/login/principal.php');
            
               }
          break;






          case 'btningresocliente':
        
            $consulta= $pdo->prepare("SELECT * FROM cliente  WHERE 
             usuarioacceso=:usuarioacceso  AND  passwordacceso=:passwordacceso");

               $consulta->bindParam( ':usuarioacceso',$Usuario,PDO::PARAM_STR);
               $consulta->bindParam( ':passwordacceso',$Clave,PDO::PARAM_STR);
               $consulta->execute();

               $resultado=$consulta->fetch(PDO::FETCH_ASSOC); //fetch assoc da la informacion del usuario

               //print_r($resultado);         
                $numeroregistros=$consulta->rowCount();   

               if($numeroregistros>=1)
               {
                session_start();
                $_SESSION['useractivo']=$resultado; 
                

               header('Location:../vistas/dashboardclient/home/principal.php');
               }
               else{
                # echo "no hay registro";
              header('Location:../vistas/login/principal.php');
               }

          break;


}

?>