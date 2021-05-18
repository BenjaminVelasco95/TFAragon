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
                <form Method="POST" action="../../BD/servicios_clinica.php" id="formulario-datos">

                    <div class="row">
                        <div class="form col-6">
                            <label>Identificador de Servicio</label>
                            <input type="text" class="form-control" id="ISER" name="iser" required>
                        </div>

                    </div>



                    <div class="row">
                        <div class="form col-6">
                            <label>Nombre</label>
                            <input type="text" class="form-control" id="nombre" name="nombre" required>
                        </div>
                        <div class="form col-6">
                            <label>Costo</label>
                            <input type="text" class="form-control" id="costo" name="costo" required>

                        </div>
                    </div>

                    <div class="row">

                        <div class="form-group col-6">
                            <label>Duración</label>
                            <input type="text" class="form-control" id="duracion" name="duracion" required>
                        </div>

                        <div class="form-group col-6">
                            <label for="">Descripción</label>
                            <input type="text" class="form-control" id="descripcion" name="descripcion" required>

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