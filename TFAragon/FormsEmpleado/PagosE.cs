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

namespace TFAragon.FomormsEmpleado
{
    public partial class PagosE : Form
    {
        public PagosE()
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
            txtFecha.Text = DateTime.Now.ToString("yy/MM/dd");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("INSERT INTO `cobros_pagos`(`IPG`, `cobrador_IE`, `pagador_IC`, `nombre_servicio`, `fechapago`, `formapago`, `monto`, `descripcion`) VALUES ('" + txtIPG.Text + "','" + cbIE.SelectedValue.ToString() + "','" + cbIC.SelectedValue.ToString() + "','" + txtConcepto.Text + "','" + txtFecha.Text + "','" + txtFormaPago.Text + "','" + txtMonto.Text + "','" + txtDescripcion.Text + "');");
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
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            limpForm();
        }

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

        private void PagosE_Load(object sender, EventArgs e)
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

        private void llblX_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
