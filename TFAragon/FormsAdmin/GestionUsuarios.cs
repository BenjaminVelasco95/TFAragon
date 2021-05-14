using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace TFAragon
{
    public partial class GestionUsuarios : Form
    {
        public GestionUsuarios()
        {
            InitializeComponent();
        }
        public string ssIE;
        private void LimpForm()
        {
            ///
            txtIE.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtCredencialAcceso.Text = "";
            txtContraseña.Text = "";
            txtIE.Text = "TFE";
            ///
        }
        /*Botonose de la barra superior*/
        private void cerrar_Click(object sender, EventArgs e)
        {
            dsAdmin ver = new dsAdmin();
            ver.Show();
            this.Close();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /*movimiento de la ventana*/
        int m = 0, mx, my;

        private void barDesplazamiento_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void barDesplazamiento_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
        }

        private void barDesplazamiento_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        
        /// ///////////////////////////////////////////////////////////////////

        static string conn = "SERVER = b6uzer3uyljskeemi0nr-mysql.services.clever-cloud.com; PORT=3306;DATABASE=b6uzer3uyljskeemi0nr;UID=uxbxj6okoaaumlr0;PWD=tZ5XuHvRCMFXxppdCXIU;";
        MySqlConnection cn = new MySqlConnection(conn);
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection conectanos = new MySqlConnection();

        /*Botones Agregar, Modificar y eliminar*/
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("INSERT INTO empleados VALUES ('"+txtIE.Text+"','"+txtNombre.Text+"','"+txtApellido.Text+"',"+txtEdad.Text+",'"+txtDireccion.Text+"','"+txtTelefono.Text+"','"+txtCorreo.Text+"','"+cbRol.Text+"','"+txtCredencialAcceso.Text+"','"+txtContraseña.Text+"');");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah agregado con Exito");
                cn.Close();
                dtgEmpleados.DataSource = llenar_Grid();
                ///
                LimpForm();
                ///

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("UPDATE `empleados` SET `nombre`='"+txtNombre.Text+"',`apellidos`='"+txtApellido.Text+"',`edad`="+txtEdad.Text+",`direccion`='"+txtDireccion.Text+"',`telefono`='"+txtTelefono.Text+"',`correo`='"+txtCorreo.Text+"',`rol`='"+cbRol.Text+"',`credencialacceso`='"+txtCredencialAcceso.Text+"',`claveacceso`='"+txtContraseña.Text+"' WHERE IE='"+txtIE.Text+"';");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah Modificado con Exito");
                cn.Close();
                dtgEmpleados.DataSource = llenar_Grid();
                ///
                LimpForm();
                ///


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }
        }

        private void btnDell_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("DELETE FROM empleados WHERE IE = '" + txtIE.Text + "'");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah Eliminado con Exito");
                cn.Close();
                dtgEmpleados.DataSource = llenar_Grid();
                ///
                LimpForm();
                ///
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }

        }

        public DataTable llenar_Grid()
        {
            cn.Open();
            DataTable dt = new DataTable();
            string llenar="SELECT * FROM empleados";
            MySqlCommand cmd = new MySqlCommand(llenar, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt;
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            dtgEmpleados.DataSource = llenar_Grid();
            txtIE.Text = "TFE";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            dsAdmin ver = new dsAdmin();
            ver.Show();
            this.Close();
        }

        private void dtgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIE.Text = dtgEmpleados.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dtgEmpleados.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dtgEmpleados.CurrentRow.Cells[2].Value.ToString();
            txtEdad.Text = dtgEmpleados.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dtgEmpleados.CurrentRow.Cells[4].Value.ToString();
            txtTelefono.Text = dtgEmpleados.CurrentRow.Cells[5].Value.ToString();
            txtCorreo.Text = dtgEmpleados.CurrentRow.Cells[6].Value.ToString();
            cbRol.Text = dtgEmpleados.CurrentRow.Cells[7].Value.ToString();
            txtCredencialAcceso.Text = dtgEmpleados.CurrentRow.Cells[8].Value.ToString();
            txtContraseña.Text = dtgEmpleados.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ///
            LimpForm();
            ///
        }
    }
}
