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
    public partial class ServiciosClinica : Form
    {
        public ServiciosClinica()
        {
            InitializeComponent();
        }
        static string conn = "SERVER = b6uzer3uyljskeemi0nr-mysql.services.clever-cloud.com; PORT=3306;DATABASE=b6uzer3uyljskeemi0nr;UID=uxbxj6okoaaumlr0;PWD=tZ5XuHvRCMFXxppdCXIU;";
        MySqlConnection cn = new MySqlConnection(conn);
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection conectanos = new MySqlConnection();

        private DataTable llenar_Grid()
        {
            DataTable dt = new DataTable();

            try
            {
                cn.Open();
                string llenar = "SELECT * FROM `servicios_clinica`;";
                MySqlCommand cmd = new MySqlCommand(llenar, cn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                cn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return dt;
            }
        }

        private void limpForm()
        {
            txtISER.Text = "";
            txtNombre.Text = "";
            txtCosto.Text = "";
            txtDuracion.Text = "";
            txtDescrip.Text = "";
            txtISER.Text = "TFS";
        }


        //////////////////////////////////////////////////////////////////////////////
        private void ServiciosClinica_Load(object sender, EventArgs e)
        {
            dtgServicios.DataSource = llenar_Grid();
            txtISER.Text = "TFS";
        }
        //////////////////////////////////////////////////////////////////////////////
        /*Barra de desplazamiento superior*/
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

        /*Botones de la barra de desplazamiento*/
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            dsAdmin ver = new dsAdmin();
            ver.Show();
            this.Close();
        }
        //////////////////////////////////////////////////////////////////////////////
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("INSERT INTO `servicios_clinica`(`ISER`, `nombre`, `costo`, `duracion`, `descripcion`) VALUES ('"+txtISER.Text+"','"+txtNombre.Text+"','"+txtCosto.Text+"','"+txtDuracion.Text+"','"+txtDescrip.Text+"');");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah agregado con Exito");
                cn.Close();
                dtgServicios.DataSource = llenar_Grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }
            ///
            limpForm();
            ///
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("UPDATE `servicios_clinica` SET `nombre`='"+txtNombre.Text+"',`costo`='"+txtCosto.Text+"',`duracion`='"+txtDuracion.Text+"',`descripcion`='"+txtDescrip.Text+"' WHERE `ISER`='"+txtISER.Text+"';");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah Modificado con Exito");
                cn.Close();
                dtgServicios.DataSource = llenar_Grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }
            ///
            limpForm();
            ///
        }

        private void btnDell_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("DELETE FROM `servicios_clinica` WHERE `ISER`='"+txtISER.Text+"';");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ha Eliminado con Exito");
                cn.Close();
                dtgServicios.DataSource = llenar_Grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }
            ///
            limpForm();
            ///
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ///
            limpForm();
            ///
        }

        
        ////////////////////////////////////////////////////////////////////////
        private void dtgServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtISER.Text = dtgServicios.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dtgServicios.CurrentRow.Cells[1].Value.ToString();
            txtCosto.Text = dtgServicios.CurrentRow.Cells[2].Value.ToString();
            txtDuracion.Text = dtgServicios.CurrentRow.Cells[3].Value.ToString(); ;
            txtDescrip.Text = dtgServicios.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
