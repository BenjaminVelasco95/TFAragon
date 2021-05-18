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
    public partial class GestionarClientes : Form
    {
        public GestionarClientes()
        {
            InitializeComponent();
        }
        string idC;
        private DataTable llenarGrid()
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Botonose de la barra superior*/
        private void cerrar_Click(object sender, EventArgs e)
        {
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

        static string conn = "SERVER = b6uzer3uyljskeemi0nr-mysql.services.clever-cloud.com; PORT=3306;DATABASE=b6uzer3uyljskeemi0nr;UID=uxbxj6okoaaumlr0;PWD=tZ5XuHvRCMFXxppdCXIU;";
        MySqlConnection cn = new MySqlConnection(conn);
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection conectanos = new MySqlConnection();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Clientes dt = new Clientes();
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("INSERT INTO `cliente`(`nombre`, `apellidos`, `telefono`, `direccion`, `usuarioacceso`, `passwordacceso`) VALUES ('"+txtNombre.Text+"','"+txtApellido.Text+"','"+txtTelefono.Text+"','"+txtDireccion.Text+"','"+txtNUsuario.Text+"','"+txtClaveacceso.Text+"');");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah agregado con Exito");
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }
            dt.dtgClientes.DataSource = dt.llenar_Grid();
            this.Close();

        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            Clientes dt = new Clientes();
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("UPDATE cliente SET nombre='" + txtNombre.Text + "', apellidos='" + txtApellido.Text + "', telefono='" + txtTelefono.Text + "', direccion='" + txtDireccion.Text + "' ,`usuarioacceso`='" + txtNUsuario.Text + "',`passwordacceso`='" + txtClaveacceso.Text + "' WHERE IC ='" + idC + "';");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah Modificado con Exito");
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }
            dt.dtgClientes.DataSource = dt.llenar_Grid();
            this.Close();
        }

        private void btnDell_Click(object sender, EventArgs e)
        {
            Clientes dt = new Clientes();
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = ("DELETE FROM cliente WHERE IC = '" + idC + "'");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah Eliminado con Exito");
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }
            dt.dtgClientes.DataSource = dt.llenar_Grid();
            this.Close();
        }

        private void GestionarClientes_Load(object sender, EventArgs e)
        {
            dtgCliente.DataSource = llenarGrid();
        }

        private void dtgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idC = dtgCliente.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dtgCliente.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dtgCliente.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = dtgCliente.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dtgCliente.CurrentRow.Cells[4].Value.ToString();
            txtNUsuario.Text = dtgCliente.CurrentRow.Cells[5].Value.ToString();
            txtClaveacceso.Text = dtgCliente.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
