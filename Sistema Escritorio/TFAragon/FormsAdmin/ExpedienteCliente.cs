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
    public partial class ExpedienteCliente : Form
    {
        public ExpedienteCliente()
        {
            InitializeComponent();
        }
        public string ICexp;

        static string conn = "SERVER = b6uzer3uyljskeemi0nr-mysql.services.clever-cloud.com; PORT=3306;DATABASE=b6uzer3uyljskeemi0nr;UID=uxbxj6okoaaumlr0;PWD=tZ5XuHvRCMFXxppdCXIU;";
        MySqlConnection cn = new MySqlConnection(conn);
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection conectanos = new MySqlConnection();

        private DataTable llenar_Grid()
        {
            cn.Open();
            DataTable dt = new DataTable();
            string llenar = "SELECT IEX, fecha, medicacion FROM expedientecliente WHERE IC = '" + ICexp + "';";
            MySqlCommand cmd = new MySqlCommand(llenar, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt;
        }
        private void limpForm()
        {
            txtIEX.Text = "";
            txtMedicacion.Text = "";
            txtObservaciones.Text = "";
            txtFecha.Text = "";
            txtFecha.Text = DateTime.Now.ToString("yy/MM/dd");
            txtIEX.Text = "TFEX";
        }
        //////////////////////////////////////////////////////////////////////////////////////////////

        /*Botonose de la barra superior*/
        private void cerrar_Click(object sender, EventArgs e)
        {
            Clientes ver = new Clientes();
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Clientes ver = new Clientes();
            ver.Show();
            this.Close();
        }

        private void ExpedienteCliente_Load(object sender, EventArgs e)
        {
            dtgExClient.DataSource = llenar_Grid();
            timer1.Enabled = true;
            txtFecha.Text = DateTime.Now.ToString("yy/MM/dd");
            txtIEX.Text = "TFEX";
           
        }

        private void dtgExClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idEx = dtgExClient.CurrentRow.Cells[0].Value.ToString();
            try
            {
                cn.Open();
                MySqlConnection conectanos = new MySqlConnection();
                cmd.Connection = cn;

                cmd.CommandText = ("SELECT * FROM expedientecliente WHERE IEX = '" + idEx + "' AND IC = '"+ICexp+"';");
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtIEX.Text = Convert.ToString(dr[0]);
                    txtFecha.Text = Convert.ToString(dr[2]);
                    txtMedicacion.Text = Convert.ToString(dr[3]);
                    txtObservaciones.Text=Convert.ToString(dr[4]);
                }
                
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Registro Inexistente");
            }
        }

        //////////////////

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("INSERT INTO expedientecliente VALUES ('" + txtIEX.Text + "','" + ICexp + "','" + txtFecha.Text + "','" + txtMedicacion.Text + "','" + txtObservaciones.Text + "');");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah agregado con Exito");
                cn.Close();
                dtgExClient.DataSource = llenar_Grid();
                ///
                limpForm();
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
                cmd.CommandText = ("UPDATE `expedientecliente` SET `IC`='" + ICexp + "',`fecha`='" + txtFecha.Text + "',`medicacion`='" + txtMedicacion.Text + "',`descripcion`='" + txtObservaciones.Text + "' WHERE IEX='" + txtIEX.Text + "';");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah Modificado con Exito");
                cn.Close();
                dtgExClient.DataSource = llenar_Grid();
                ///
                limpForm();
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
                cmd.CommandText = ("DELETE FROM expedientecliente WHERE IEX = '" + txtIEX.Text + "'");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah Eliminado con Exito");
                cn.Close();
                dtgExClient.DataSource = llenar_Grid();
                ///
                limpForm();
                ///
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ///
            limpForm();
            ///
        }
    }
}
