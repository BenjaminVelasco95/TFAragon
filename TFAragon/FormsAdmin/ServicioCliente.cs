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
    public partial class ServicioCliente : Form
    {
        public ServicioCliente()
        {
            InitializeComponent();
        }
        static string conn = "SERVER = b6uzer3uyljskeemi0nr-mysql.services.clever-cloud.com; PORT=3306;DATABASE=b6uzer3uyljskeemi0nr;UID=uxbxj6okoaaumlr0;PWD=tZ5XuHvRCMFXxppdCXIU;";
        MySqlConnection cn = new MySqlConnection(conn);
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection conectanos = new MySqlConnection();

        private DataTable CombBox()
        {
            cn.Open();
            DataTable dt = new DataTable();
            string llenar = "SELECT ISER, nombre FROM servicios_clinica;";
            MySqlCommand cmd = new MySqlCommand(llenar, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt;
        }

        private DataTable llenar_Grid()
        {
            cn.Open();
            DataTable dt = new DataTable();
            string llenar = "SELECT * FROM servicios_cliente;";
            MySqlCommand cmd = new MySqlCommand(llenar, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt;
        }

        private void limpForm()
        {
            txtIC.Text = "";
            txtTTranscurrido.Text = "";
            txtDuracion.Text = "";
            txtDescrip.Text = "";
            txtCosto.Text = "";
            txtIC.Text = "TFC";
        }
        ////////////////////////////////////////////////////////////////////////////////////
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

        private void ServicioCliente_Load(object sender, EventArgs e)
        {
            DataTable dt = CombBox();
            cbServicios.DataSource = dt;
            cbServicios.ValueMember = "ISER";
            cbServicios.DisplayMember = "nombre";
            dtgSClientes.DataSource = llenar_Grid();
            txtIC.Text = "TFC";
        }
        ////////////////////////////////////////////////////////////////////////////////////
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("INSERT INTO `servicios_cliente`(`IC`, `ISER`, `transcurrido`, `duracion`, `descripcion`, `costo`) VALUES ('" + txtIC.Text + "','" + cbServicios.SelectedValue.ToString() + "','" + txtTTranscurrido.Text + "','" + txtDuracion.Text + "','" + txtDescrip.Text + "','" + txtCosto.Text + "');");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah agregado con Exito");
                cn.Close();
                dtgSClientes.DataSource = llenar_Grid();
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
                cmd.CommandText = ("UPDATE `servicios_cliente` SET `ISER`='" + cbServicios.SelectedValue.ToString()  + "',`transcurrido`='" + txtTTranscurrido.Text + "',`duracion`='" + txtDuracion.Text + "',`descripcion`='" + txtDescrip.Text + "',`costo`='" + txtCosto.Text + "' WHERE `IC`='" + txtIC.Text + "';");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah Modificado con Exito");
                cn.Close();
                dtgSClientes.DataSource = llenar_Grid();

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
                cmd.CommandText = ("DELETE FROM `servicios_cliente` WHERE `IC`='" + txtIC.Text + "' AND `ISER`='"+cbServicios+"';");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah Eliminado con Exito");
                cn.Close();
                dtgSClientes.DataSource = llenar_Grid();

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
        ////////////////////////////////////////////////////////////////////////////////////
        private void dtgSClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIC.Text = dtgSClientes.CurrentRow.Cells[0].Value.ToString();
            txtTTranscurrido.Text = dtgSClientes.CurrentRow.Cells[2].Value.ToString();
            txtDuracion.Text = dtgSClientes.CurrentRow.Cells[3].Value.ToString();
            txtDescrip.Text = dtgSClientes.CurrentRow.Cells[4].Value.ToString();
            txtCosto.Text = dtgSClientes.CurrentRow.Cells[5].Value.ToString();

        }

        private void cbServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                MySqlConnection conectanos = new MySqlConnection();
                cmd.Connection = cn;

                cmd.CommandText = ("SELECT duracion, descripcion, costo FROM servicios_clinica WHERE ISER = '" + cbServicios.SelectedValue.ToString() + "';");
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtDuracion.Text = Convert.ToString(dr[0]);
                    txtDescrip.Text = Convert.ToString(dr[1]);
                    txtCosto.Text = Convert.ToString(dr[2]);
                }

                cn.Close();
            }
            catch
            {
                MessageBox.Show("Registro Inexistente");
            }
        }
    }
}
