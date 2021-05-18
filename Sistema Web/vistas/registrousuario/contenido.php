







<!-- /.login-logo -->

<div class="card card-outline card-primary">
    <div class="card-header text-center">
        <a href="#" class="h1"><b>TF</b> Aragón</a>
    </div>

    <div class="card-body">
        <p class="login-box-msg">Ingrese Usuario y Contraseña de acceso</p>

        <form action="../../BD/login.php" method="post">

            <div class="input-group mb-3">
                <input type="text" class="form-control" placeholder="Usuario" name="UsuArio" id="UsuArio">
                <div class="input-group-append">
                    <div class="input-group-text">
                        <span class="fas fa-user"></span>
                    </div>
                </div>
            </div>



            <div class="input-group mb-3">
                <input type="password" class="form-control" placeholder="Contraseña" name="PassWord" id="PassWord">
                <div class="input-group-append">
                    <div class="input-group-text">
                        <span class="fas fa-lock"></span>
                    </div>
                </div>
            </div>



       


            <div class="row text-center mt-2 mb-3">




                <button type="submit" class="btn btn-block btn-primary" name="funcion" value="btningreso">
                    <i class="nav-icon fas fa-sign-in-alt  mr-2" aria-hidden="true"></i> Iniciar Sesión
                </button>


                <a href="#" class="btn btn-block btn-danger">
                    <i class="nav-icon fas fa-user-plus 2x mr-2"></i> Crear Cuenta
                </a>

            </div>



        </form>

        <!-- /.social-auth-links -->
    </div>
    <!-- /.card-body -->
</div>
<!-- /.card -->