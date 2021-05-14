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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }
        static string conn = "SERVER = b6uzer3uyljskeemi0nr-mysql.services.clever-cloud.com; PORT=3306;DATABASE=b6uzer3uyljskeemi0nr;UID=uxbxj6okoaaumlr0;PWD=tZ5XuHvRCMFXxppdCXIU;";
        MySqlConnection cn = new MySqlConnection(conn);
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection conectanos = new MySqlConnection();

        public DataTable llenar_Grid()
        {
            cn.Open();
            DataTable dt = new DataTable();
            string llenar = "SELECT * FROM cliente";
            MySqlCommand cmd = new MySqlCommand(llenar, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt;
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            dsAdmin ver = new dsAdmin();
            ver.Show();
            this.Close();
        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            GestionarClientes ver = new GestionarClientes();
            ver.Show();
            
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            dtgClientes.DataSource = llenar_Grid();
        }

        private void lblActualizar_Click(object sender, EventArgs e)
        {
            dtgClientes.DataSource = llenar_Grid();
        }

        private void btnExpediente_Click(object sender, EventArgs e)
        {
            ExpedienteCliente obj = new ExpedienteCliente();
            try
            {
            obj.ICexp = txtIC.Text;
            obj.Show();
            this.Hide();
            }
            catch
            {
                MessageBox.Show("Por favor ingrese el identificador del cliente");
            }
            
        }

        private void dtgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIC.Text = dtgClientes.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            DetallesClientes ver = new DetallesClientes();
            ver.Show();
            this.Close();
        }

    }
}
