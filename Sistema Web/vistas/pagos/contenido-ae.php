<!-- Content Header (Page header) encabezado-->
<div class="content-header">
    <div class="container-fluid">
        <div class="row mb-2">
            <div class="col-sm-6">
                <h1 class="m-0">Pago de servicios adquiridos</h1>
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

            <div class="col-12">

                <div class="card">
                    <div class="card-header">
                        <h3 class="card-title">Vista General</h3>
                    </div>
                    <!-- /.card-header -->
                    <div class="card-body">

                        <table id="tabladedatos" class="table table-bordered table-hover">
                            <thead>
                                <tr>
                                    <th>Id Pago</th>
                                    <th>Empleado cobrador</th>
                                    <th>Id Cliente</th>
                                    <th>Nombre del servicio</th>
                                    <th>Fecha</th>
                                    <th>Forma</th>
                                    <th>Monto</th>
                                    <th>Descripción</th>
                                

                                </tr>
                            </thead>

                            <tbody>

                            <?php
                            
                            include '../../BD/mostrar_pagos.php';
                                foreach($lista as $mostrar) 
                                {                                     
                                ?>
                                <tr>
                                   <!--<input type="hidden" class="serdelete" value="aquiva el ie">-->

                                    <td><?php echo $mostrar['IPG']; ?></td>
                                    <td><?php echo $mostrar['cobrador_IE'];?></td>
                                    <td><?php echo $mostrar['pagador_IC'];?></td>
                                    <td><?php echo $mostrar['nombre_servicio'];?></td>
                                    <td><?php echo $mostrar['fechapago'];?></td>
                                    <td><?php echo $mostrar['formapago'];?></td>
                                    <td><?php echo $mostrar['monto'];?></td>
                                    <td><?php echo $mostrar['descripcion'];?></td>
                              
                                   
                                
                                
                                </tr>

                                <?php } ?>

                            
                            </tbody>
                        </table>
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->
            </div>
            <!-- /.col -->
        </div>
        <!-- /.row -->

    </div><!-- /.container-fluid -->

</section>
<!-- /.content -->

<!--Script AJX que obtiene datos del datatables y los manda a la ventana modal-->
<!--los #ie,#nombre y demas  campos llaman al id de cada campo que tiene el modal para insertar los datos-->

