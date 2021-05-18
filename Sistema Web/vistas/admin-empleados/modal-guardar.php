<div class="modal fade" id="modal-guardar">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <h4 class="modal-title">Ingresar nuevos datos</h4>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
            </div>


            <div class="modal-body">
                <form Method="POST" action="../../BD/editar-empleados.php" id="formulario-datos">

                    <div class="row">
                        <div class="form col-6">
                            <label>Identificador de Empleado</label>
                            <input type="text" class="form-control" id="IE" name="ie" required>
                        </div>

                    </div>



                    <div class="row">
                        <div class="form col-6">
                            <label>Nombre(s)</label>
                            <input type="text" class="form-control" id="nombre" name="nombre" required>
                        </div>
                        <div class="form col-6">
                            <label>Apellido(s) </label>
                            <input type="text" class="form-control" id="apellidos" name="apellidos" required>

                        </div>
                    </div>

                    <div class="row">

                        <div class="form-group col-6">
                            <label>Edad</label>
                            <input type="text" class="form-control" id="edad" name="edad" required>
                        </div>

                        <div class="form-group col-6">
                            <label for="">Telefono</label>
                            <input type="text" class="form-control" id="telefono" name="telefono" required>

                        </div>
                    </div>


                    <div class="row">
                        <div class="form-group col-12">
                            <label for="">Domicilio</label>
                            <input type="text" class="form-control" id="direccion" name="direccion" required>

                        </div>
                    </div>

                    <div class="row">

                        <div class="form-group col-12">
                            <label>Correo</label>
                            <input type="text" class="form-control" id="correo" name="correo" required>

                        </div>

                    </div>



                  

                    <!--Botones del modal. -->
                    <div class="modal-footer justify-content-between">

                    <button type="button" onclick="limpiarform()" class="btn btn-default"
                        data-dismiss="modal">Cerrar</button>

                    <button type="submit" class="btn btn-primary" name="funcion" value="BtnGuardar">Guardar
                        Cambios</button>

                    </div>

                </form>

            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
<!-- /.modal -->


<!--Limpiar datos  en el formulario al momento de presionar el boton cerrar. -->
<script>
function limpiarform() {
    document.getElementById("formulario-datos").reset();
}
</script>
<!--Limpiar datos  en el formulario al momento de presionar el boton cerrar. -->