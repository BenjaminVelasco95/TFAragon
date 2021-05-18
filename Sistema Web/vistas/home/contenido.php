<?php 
include '../../BD/tarjetas.php'; 
?>
<!-- Content Header (Page header) encabezado-->
<div class="content-header">
    <div class="container-fluid">
        <div class="row mb-2">
            <div class="col-sm-6">
                <h1 class="m-0">Bienvenido: Monitor de registros</h1>
            </div><!-- /.col -->
            <div class="col-sm-6">
              
            </div><!-- /.col -->
        </div><!-- /.row -->
    </div><!-- /.container-fluid -->
</div>
<!-- /.content-header -->



<!-- Main content contenedor principal-->
<section class="content">
    <div class="container-fluid">
        <!-- Main content subcontenedor -->

        <!-- Small boxes (Stat box)  tarjetas-->
        <div class="row">


            <div class="col-lg-3 col-6">
                <!-- small box -->
                <div class="small-box bg-info">
                    <div class="inner">
                        <h3><?php echo $totaldatos; ?></h3>

                        <p>Total de Empleados</p>
                    </div>
                    <div class="icon">
                        <i class="fa ion-android-people"></i>
                    </div>
          
                </div>
            </div>


            <!-- ./col -->
            <div class="col-lg-3 col-6">
                <!-- small box -->
                <div class="small-box bg-success">
                    <div class="inner">
                        <h3><?php echo $clientes; ?></h3>

                        <p>Total de clientes</p>
                    </div>
                    <div class="icon">
                        <i class="fa ion-android-person"></i>
                    </div>
       
                </div>
            </div>
            <!-- ./col -->

            <div class="col-lg-3 col-6">
                <!-- small box -->
                <div class="small-box bg-warning">
                    <div class="inner">
                        <h3> <?php echo $expedientes; ?></h3>

                        <p>Expedientes Elaborados</p>
                    </div>
                    <div class="icon">
                        <i class="fa ion-android-clipboard"></i>
                    </div>
              
                </div>
            </div>




            <div class="col-lg-3 col-6">
                <!-- small box -->
                <div class="small-box bg-info">
                    <div class="inner">
                    <h3> <?php echo $serviciostotales; ?></h3>
                        <p>Servicios Adquiridos</p>
                    </div>
                    <div class="icon">
                        <i class="fa ion-arrow-graph-up-right"></i>
                    </div>
              
                </div>
            </div>
  
  

        

            <div class="col-lg-3 col-6">
                <!-- small box -->
                <div class="small-box bg-danger">
                    <div class="inner">
                    
                        <h3> <?php echo $gastostotales; ?></h3>
                        <p>Gastos  Registrados</p>
                    </div>
                    <div class="icon">
                        <i class="fa ion-cash"></i>
                    </div>
            
                </div>
            </div>






            <!-- ./col -->
        </div>
        <!-- /.row -->

    </div><!-- /.container-fluid -->
</section>
<!-- /.content -->


