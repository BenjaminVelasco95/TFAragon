<!-- Content Header (Page header) encabezado-->
<div class="content-header">
    <div class="container-fluid">
        <div class="row mb-2">
            <div class="col-sm-6">
                <h1 class="m-0">Información de contacto</h1>
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


    <div class="card card-solid">

        <div class="card-body pb-0">

            <div class="row">

                <div class="col-12 col-sm-6 col-md-4 d-flex align-items-stretch flex-column">
                    <div class="card bg-light d-flex flex-fill">
                        <div class="card-body pt-0">
                            <div class="row">
                                <div class="col-7">
                                    <h2 class="lead"><b>WatsApp</b></h2>

                                    <ul class="ml-4 mb-0 fa-ul text-muted">

                                        <li class="small"><span class="fa-li"><i class="fas fa-lg fa-phone"></i></span>
                                            961-170-5023</li>
                                    </ul>
                                </div>
                                <div class="col-5 text-center">
                                    <img src="../../../Recursos/wats.png" alt="user-avatar"
                                        class="img-circle img-fluid">
                                </div>
                            </div>
                        </div>


                    </div>
                </div>



                <div class="col-12 col-sm-6 col-md-4 d-flex align-items-stretch flex-column">
                    <div class="card bg-light d-flex flex-fill">
                        <div class="card-body pt-0">
                            <div class="row">
                                <div class="col-7">
                                    <h2 class="lead"><b>Gmail</b></h2>

                                    <ul class="ml-4 mb-0 fa-ul text-muted">

                                        <li class="small"><span class="fa-li"><i class="fas fa-lg fa-envelope"></i></span>
                                            tfaragonf@gmail.com</li>
                                    </ul>
                                </div>
                                <div class="col-5 text-center">
                                
                                </div>
                            </div>
                        </div>


                    </div>
                </div>




                <div class="col-12 col-sm-6 col-md-4 d-flex align-items-stretch flex-column">
                    <div class="card bg-light d-flex flex-fill">
                        <div class="card-body pt-0">
                            <div class="row">
                                <div class="col-7">
                                    <h2 class="lead"><b>Facebook Messenger</b></h2>

                                    <ul class="ml-4 mb-0 fa-ul text-muted">

                                        <li class="small"><span class="fa-li"><i class="fab fa-lg fa-facebook-messenger"></i></span>
                                            Terapia Física Aragón</li>
                                    </ul>
                                </div>
                                <div class="col-5 text-center">
                                    <img src="../../../Recursos/mess2.png" alt="user-avatar"
                                        class="img-circle img-fluid">
                                </div>
                            </div>
                        </div>


                    </div>
                </div>


            </div>
        </div>
       
    </div>
    <!-- /.card -->

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

    $('#ISER').val(datos[0]);
    $('#nombre').val(datos[1]);
    $('#costo').val(datos[2]);
    $('#duracion').val(datos[3]);
    $('#descripcion').val(datos[4]);

});
</script>
<!--Script AJX que obtiene datos del datatables y los manda a la ventana modal-->