<!-- Content Header (Page header) encabezado-->
<div class="content-header">
    <div class="container-fluid">
        <div class="row mb-2">
            <div class="col-sm-6">
                <h1 class="m-0">Gestión de Empleados</h1>
            </div><!-- /.col -->
            <div class="col-sm-6">
                <ol class="breadcrumb float-sm-right">

                </ol>
            </div><!-- /.col -->
        </div><!-- /.row -->
    </div><!-- /.container-fluid -->
</div>
<!-- /.content-header -->

<!-- Main content contenedor principal-->
<section class="content">


    <!--llamada a las ventanas modales------------------->
    <?php include 'modal-editar.php';?>
    <?php include 'modal-guardar.php';?>
    <!--llamada a las ventanas modales------------------->


    <div class="container-fluid">
        <!-- Main content subcontenedor -->

        <!-- Small boxes (Stat box)  tarjetas-->
        <div class="row">

            <div class="col-12">

                <div class="card">
                    <div class="card-header">
                        <h3 class="card-title">Editar Datos Generales</h3>
                    </div>
                    <!-- /.card-header -->
                    <div class="card-body">

                        <!--Boton que llama al modal de editar-->
                        <button type="button" class="btn btn-success" data-toggle="modal"
                            data-target="#modal-guardar"><i class="fa fa-user-plus"></i>
                        </button>

                        <table id="tabladedatos" class="table table-bordered table-hover">
                            <thead>
                                <tr>
                                    <th>IE</th>
                                    <th>Nombre(s)</th>
                                    <th>Apellido(s)</th>
                                    <th>Edad</th>
                                    <th>Dirección</th>
                                    <th>Telefono</th>
                                    <th>Correo</th>
                                    <th>Acciones</th>

                                </tr>
                            </thead>

                            <tbody>

                                <?php
                                include '../../BD/mostrar-empleados.php';
                                foreach($listaEmpleados as $mostrar) 
                                {                                     
                                ?>
                                <tr>
                                   <!--<input type="hidden" class="serdelete" value="aquiva el ie">-->

                                    <td><?php echo $mostrar['IE']; ?></td>
                                    <td><?php echo $mostrar['nombre']; ?></td>
                                    <td><?php echo $mostrar['apellidos']; ?></td>
                                    <td><?php echo $mostrar['edad']; ?></td>
                                    <td><?php echo $mostrar['direccion']; ?></td>
                                    <td><?php echo $mostrar['telefono']; ?></td>
                                    <td><?php echo $mostrar['correo']; ?></td>

                                    <td>
                                        <!--Boton que llama al modal de editar-->
                                        <button type="button" class="btn btn-primary editbtn" data-toggle="modal"
                                            data-target="#modal-editar"><i class="fa fa-edit"></i>
                                        </button>


                                        <!-- <button type="button" class="btn btn-danger servideletebtn"><i
                                                class="fa fa-trash-alt"></i>-->
                                        </button>



                                    </td>
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

<script>
$('.editbtn').on('click', function() {
    $tr = $(this).closest('tr');
    var datos = $tr.children("td").map(function() {
        return $(this).text();

    });

    $('#IE').val(datos[0]);
    $('#nombre').val(datos[1]);
    $('#apellidos').val(datos[2]);
    $('#edad').val(datos[3]);
    $('#direccion').val(datos[4]);
    $('#telefono').val(datos[5]);
    $('#correo').val(datos[6]);
});
</script>
<!--Script AJX que obtiene datos del datatables y los manda a la ventana modal-->

