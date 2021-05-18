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
    public partial class EntradaSalidaE : Form
    {
        public EntradaSalidaE()
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
            string llenar = "SELECT IE, nombre FROM empleados where rol = 'empleado';";
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
            string llenar = "SELECT * FROM `entradas_salidas`;";
            MySqlCommand cmd = new MySqlCommand(llenar, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt;
        }

        private void btnRSalida_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("UPDATE `entradas_salidas` SET `horasalida`='" + txtHSalida.Text + "' WHERE `fecha`='" + txtFecha.Text + "' AND `IE`='" + cbIE.SelectedValue.ToString() + "';");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Salida Registrada con Exito");
                cn.Close();
                dtgES.DataSource = llenar_Grid();

            }
            catch
            {
                MessageBox.Show("Aun no has registrado tu entrada hoy");
            }
        }

        private void btnREntrada_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("INSERT INTO `entradas_salidas`(`IE`, `fecha`, `horaentrada`) VALUES ('" + cbIE.SelectedValue.ToString() + "','" + txtFecha.Text + "','" + txtHEntrada.Text + "')");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Entrada Registrada con Exito");
                cn.Close();
                dtgES.DataSource = llenar_Grid();
            }
            catch
            {
                MessageBox.Show("Ya te has registrado Hoy");
            }
        }

        private void EntradaSalidaE_Load(object sender, EventArgs e)
        {
            DataTable dt = CombBox();
            cbIE.DataSource = dt;
            cbIE.ValueMember = "IE";
            cbIE.DisplayMember = "nombre";
            dtgES.DataSource = llenar_Grid();
            timer1.Enabled = true;
            txtFecha.Text = DateTime.Now.ToString("yy/MM/dd");
            txtHEntrada.Text = DateTime.Now.ToString("HH:mm:ss");
            txtHSalida.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void llblX_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
