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
    public partial class Gastos : Form
    {
        public Gastos()
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
            txtFecha.Text = DateTime.Now.ToString("yy/MM/dd");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("INSERT INTO `gastos_empresa`(`IGT`, `cobrador`, `pagador_IE`, `descripcion`, `monto_utilizado`, `fecha`) VALUES ('" + txtIGT.Text + "','" + txtCobrador.Text + "','" + cbIE.SelectedValue.ToString() + "','" + txtDescripcion.Text + "','" + txtMonto.Text + "','" + txtFecha.Text + "');");
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
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpForm();
        }

        private void dtgGastos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIGT.Text = dtgGastos.CurrentRow.Cells[0].Value.ToString();
            txtCobrador.Text = dtgGastos.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dtgGastos.CurrentRow.Cells[3].Value.ToString();
            txtMonto.Text = dtgGastos.CurrentRow.Cells[4].Value.ToString();
            txtFecha.Text = dtgGastos.CurrentRow.Cells[5].Value.ToString();
        }

        private void Gastos_Load(object sender, EventArgs e)
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

        private void llblX_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
