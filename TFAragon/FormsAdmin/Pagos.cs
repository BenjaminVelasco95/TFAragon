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
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
        }
        static string conn = "SERVER = b6uzer3uyljskeemi0nr-mysql.services.clever-cloud.com; PORT=3306;DATABASE=b6uzer3uyljskeemi0nr;UID=uxbxj6okoaaumlr0;PWD=tZ5XuHvRCMFXxppdCXIU;";
        MySqlConnection cn = new MySqlConnection(conn);
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection conectanos = new MySqlConnection();

        private DataTable CombBoxIE()
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

        private DataTable CombBoxIC()
        {
            cn.Open();
            DataTable dt = new DataTable();
            string llenar = "SELECT IC, nombre FROM cliente;";
            MySqlCommand cmd = new MySqlCommand(llenar, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt;
        }

        public DataTable llenar_Grid()
        {
            cn.Open();
            DataTable dt = new DataTable();
            string llenar = "SELECT IPG, pagador_IC, nombre_servicio, fechapago, formapago, monto, descripcion FROM cobros_pagos;";
            MySqlCommand cmd = new MySqlCommand(llenar, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt;
        }

        private void limpForm()
        {
            txtConcepto.Text = "";
            txtDescripcion.Text = "";
            txtFecha.Text = "";
            txtFormaPago.Text = "";
            txtIPG.Text = "";
            txtMonto.Text = "";
            txtIPG.Text = "TFP";
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

        private void Pagos_Load(object sender, EventArgs e)
        {
            DataTable dtic = CombBoxIC(), dtie = CombBoxIE();
            cbIC.DataSource = dtic;
            cbIC.ValueMember = "IC";
            cbIC.DisplayMember = "nombre";
            cbIE.DataSource = dtie;
            cbIE.ValueMember = "IE";
            cbIE.DisplayMember = "nombre";
            dtgPagos.DataSource = llenar_Grid();
            timer1.Enabled = true;
            txtFecha.Text = DateTime.Now.ToString("yy/MM/dd");
            txtIPG.Text = "TFP";
        }
        ////////////////////////////////////////////////////////////////////////////////////
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("INSERT INTO `cobros_pagos`(`IPG`, `cobrador_IE`, `pagador_IC`, `nombre_servicio`, `fechapago`, `formapago`, `monto`, `descripcion`) VALUES ('"+txtIPG.Text+"','"+cbIE.SelectedValue.ToString()+"','"+cbIC.SelectedValue.ToString()+"','"+txtConcepto.Text+"','"+txtFecha.Text+"','"+txtFormaPago.Text+"','"+txtMonto.Text+"','"+ txtDescripcion.Text+"');");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah agregado con Exito");
                cn.Close();
                dtgPagos.DataSource = llenar_Grid();
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
                cmd.CommandText = ("UPDATE `cobros_pagos` SET `cobrador_IE`='" + cbIE.SelectedValue.ToString() + "',`pagador_IC`='" + cbIC.SelectedValue.ToString() + "',`nombre_servicio`='" + txtConcepto.Text + "',`fechapago`='" + txtFecha.Text + "',`formapago`='" + txtFormaPago.Text + "',`monto`='" + txtMonto.Text + "',`descripcion`='" + txtDescripcion.Text + "' WHERE `IPG`= '" + txtIPG.Text + "';");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah Modificado con Exito");
                cn.Close();
                dtgPagos.DataSource = llenar_Grid();

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
                cmd.CommandText = ("DELETE FROM `cobros_pagos` WHERE IPG = '"+txtIPG.Text+"';");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah Eliminado con Exito");
                cn.Close();
                dtgPagos.DataSource = llenar_Grid();

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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ///
            limpForm();
            ///
            txtFecha.Text = DateTime.Now.ToString("yy/MM/dd");

        }
        ////////////////////////////////////////////////////////////////////////////////////
        private void dtgPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idPag = dtgPagos.CurrentRow.Cells[0].Value.ToString();
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                cmd.Connection = cn;

                cmd.CommandText = ("SELECT * FROM cobros_pagos WHERE IPG = '" + idPag.ToString() + "';");
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtIPG.Text = Convert.ToString(dr[0]);
                    txtConcepto.Text = Convert.ToString(dr[3]);
                    txtFecha.Text = Convert.ToString(dr[4]);
                    txtFormaPago.Text = Convert.ToString(dr[5]);
                    txtMonto.Text = Convert.ToString(dr[6]);
                    txtDescripcion.Text = Convert.ToString(dr[7]);
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
