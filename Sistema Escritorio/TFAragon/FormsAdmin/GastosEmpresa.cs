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
    public partial class GastosEmpresa : Form
    {
        public GastosEmpresa()
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
            string llenar = "SELECT IE, nombre FROM empleados;";
            MySqlCommand cmd = new MySqlCommand(llenar, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt;
        }

        private DataTable llenar_Grid()
        {
            DataTable dt = new DataTable();

            try
            {
                cn.Open();
                string llenar = "SELECT `IGT`, `cobrador`, `pagador_IE`, `descripcion`, `monto_utilizado`, `fecha` FROM `gastos_empresa`;";
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
            txtCobrador.Text = "";
            txtDescripcion.Text = "";
            txtFecha.Text = "";
            txtIGT.Text = "";
            txtMonto.Text = "";
            txtIGT.Text = "TFG";
        }
        //////////////////////////////////////////////////////////////////////////////

        private void GastosEmpresa_Load(object sender, EventArgs e)
        {
            DataTable dt = CombBox();
            cbIE.DataSource = dt;
            cbIE.ValueMember = "IE";
            cbIE.DisplayMember = "nombre";
            dtgGastos.DataSource = llenar_Grid();
            timer1.Enabled = true;
            txtFecha.Text = DateTime.Now.ToString("yy/MM/dd");
            txtIGT.Text = "TFG";
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


        ////////////////////////////////////////////////////////////////////////
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("INSERT INTO `gastos_empresa`(`IGT`, `cobrador`, `pagador_IE`, `descripcion`, `monto_utilizado`, `fecha`) VALUES ('"+txtIGT.Text+"','"+txtCobrador.Text+"','"+cbIE.SelectedValue.ToString()+"','"+txtDescripcion.Text+"','"+txtMonto.Text+"','"+txtFecha.Text+"');");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah agregado con Exito");
                cn.Close();
                dtgGastos.DataSource = llenar_Grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }
            ///
            limpForm();
            ///
            txtFecha.Text = DateTime.Now.ToString("yy/MM/dd");
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("UPDATE `gastos_empresa` SET `cobrador`='" + txtCobrador.Text + "',`pagador_IE`='" + cbIE.SelectedValue.ToString() + "',`descripcion`='" + txtDescripcion.Text + "',`monto_utilizado`='" + txtMonto.Text + "',`fecha`='" + txtFecha.Text + "' WHERE `IGT`='" + txtIGT.Text + "';");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah Modificado con Exito");
                cn.Close();
                dtgGastos.DataSource = llenar_Grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }
            ///
            limpForm();
            ///
            txtFecha.Text = DateTime.Now.ToString("yy/MM/dd");
        }

        private void btnDell_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("DELETE FROM `gastos_empresa` WHERE `IGT`='"+txtIGT.Text+"';");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah Modificado con Exito");
                cn.Close();
                dtgGastos.DataSource = llenar_Grid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }
            ///
            limpForm();
            ///
            txtFecha.Text = DateTime.Now.ToString("yy/MM/dd");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ///
            limpForm();
            ///
            txtFecha.Text = DateTime.Now.ToString("yy/MM/dd");
        }

        ////////////////////////////////////////////////////////////////////////
        private void dtgGastos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIGT.Text = dtgGastos.CurrentRow.Cells[0].Value.ToString();
            txtCobrador.Text = dtgGastos.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dtgGastos.CurrentRow.Cells[3].Value.ToString();
            txtMonto.Text = dtgGastos.CurrentRow.Cells[4].Value.ToString();
            txtFecha.Text = dtgGastos.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
