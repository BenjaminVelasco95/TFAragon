<div class="card-body register-card-body">
    <p class="login-box-msg">Regístrese para poder visualizar nuestros servicios.</p>
    <form action="../../BD/registrocliente.php" method="post">


        <div class="input-group mb-3">
            <input type="text" class="form-control" placeholder="Nombre Completo" name="txtnombre" required>
            <div class="input-group-append">
                <div class="input-group-text">
                    <span class="fas fa-pen"></span>
                </div>
            </div>
        </div>

        <div class="input-group mb-3">
            <input type="text" class="form-control" placeholder="Apellidos" name="txtapellidos" required>
            <div class="input-group-append">
                <div class="input-group-text">
                    <span class="fas fa-pen"></span>
                </div>
            </div>
        </div>
        
        <div class="input-group mb-3">
            <input type="text" class="form-control" placeholder="Teléfono " name="txttelefono" required>
            <div class="input-group-append">
                <div class="input-group-text">
                    <span class="fas fa-phone"></span>
                </div>
            </div>
        </div>

        <div class="input-group mb-3">
            <input type="text" class="form-control" placeholder="Dirección" name="txtdireccion" required>
            <div class="input-group-append">
                <div class="input-group-text">
                    <span class="fas fa-pen"></span>
                </div>
            </div>
        </div>

        <div class="input-group mb-3">
            <input type="text" class="form-control" placeholder="Usuario" name="txtusuario"required>
            <div class="input-group-append">
                <div class="input-group-text">
                    <span class="fas fa-user"></span>
                </div>
            </div>
        </div>

        <div class="input-group mb-3">
            <input type="password" class="form-control" placeholder="Contraseña" name="txtpass" required>
            <div class="input-group-append">
                <div class="input-group-text">
                    <span class="fas fa-lock"></span>
                </div>
            </div>
        </div>

      
        



        <button type="submit" class="btn btn-block btn-primary" name="funcion" value="BtnRegistro">
            <i class="nav-icon fas fa-sign-in-alt  mr-2" aria-hidden="true"></i>Registrase
        </button>


        <a href="../login/principal.php" class="btn btn-block btn-danger">
            <i class="nav-icon fas fa-user-plus 2x mr-2"></i>Ya tengo una cuenta 
        </a>
    </form>


</div>
<!-- /.form-box -->