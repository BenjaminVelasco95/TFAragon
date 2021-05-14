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
    public partial class DetallesClientes : Form
    {
        public DetallesClientes()
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
            string llenar = "SELECT * FROM caracteristicas_cliente";
            MySqlCommand cmd = new MySqlCommand(llenar, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt;
        }

        private void limpForm()
        {
            txtDrogas.Text = "";
            txtEdad.Text = "";
            txtEdoCivil.Text = "";
            txtEredo.Text = "";
            txtHijos.Text = "";
            txtLateralizacion.Text = "";
            txtMedicacion.Text = "";
            txtNacionalidad.Text = "";
            txtPasatiempo.Text = "";
            txtSexo.Text = "";
            txtTalla.Text = "";
        }
        //////////////////////////////////////////////////////////////////////////////

        private void DetallesClientes_Load(object sender, EventArgs e)
        {
            DataTable dt = CombBox();
            cbCliente.DataSource = dt;
            cbCliente.ValueMember = "IC";
            cbCliente.DisplayMember = "nombre";
            dtgFichaTecnica.DataSource = llenar_Grid();
            
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
            Clientes ver = new Clientes();
            ver.Show();
            this.Close();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Clientes ver = new Clientes();
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
                cmd.CommandText = ("INSERT INTO `caracteristicas_cliente`(`IC`, `edad`, `sexo`, `talla`, `nacionalidad`, `estadocivil`, `estupefacientes`, `lateralizacion`, `hijos`, `pasatiempo`, `antecedentes`, `medicacion`) VALUES ('"+cbCliente.SelectedValue.ToString()+"','"+txtEdad.Text+"','"+txtSexo.Text+"','"+txtTalla.Text+"','"+txtNacionalidad.Text+"','"+txtEdoCivil.Text+"','"+txtDrogas.Text+"','"+txtLateralizacion.Text+"','"+txtHijos.Text+"','"+txtPasatiempo.Text+"','"+txtEredo.Text+"','"+txtMedicacion.Text+"');");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah agregado con Exito");
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }
            dtgFichaTecnica.DataSource = llenar_Grid();
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
                cmd.CommandText = ("UPDATE `caracteristicas_cliente` SET `edad`='" + txtEdad.Text + "',`sexo`='" + txtSexo.Text + "',`talla`='" + txtTalla.Text + "',`nacionalidad`='" + txtNacionalidad.Text + "',`estadocivil`='" + txtEdoCivil.Text + "',`estupefacientes`='" + txtDrogas.Text + "',`lateralizacion`='" + txtLateralizacion.Text + "',`hijos`='" + txtHijos.Text + "',`pasatiempo`='" + txtPasatiempo.Text + "',`antecedentes`='" + txtEredo.Text + "',`medicacion`='" + txtMedicacion.Text + "' WHERE `IC`='" + cbCliente.SelectedValue.ToString() + "';");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah Modificado con Exito");
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }
            dtgFichaTecnica.DataSource = llenar_Grid();
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
                cmd.CommandText = ("DELETE FROM `caracteristicas_cliente` WHERE `IC`='" + cbCliente.SelectedValue.ToString() + "';");
                MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Se ah Modificado con Exito");
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah Ocurrido un Error: " + ex.ToString());
            }
            dtgFichaTecnica.DataSource = llenar_Grid();
            ///
            limpForm();
            ///
        }

        
        ////////////////////////////////////////////////////////////////////////
        private void dtgFichaTecnica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEdad.Text = dtgFichaTecnica.CurrentRow.Cells[1].Value.ToString();
            txtSexo.Text = dtgFichaTecnica.CurrentRow.Cells[2].Value.ToString();
            txtTalla.Text = dtgFichaTecnica.CurrentRow.Cells[3].Value.ToString();
            txtNacionalidad.Text = dtgFichaTecnica.CurrentRow.Cells[4].Value.ToString();
            txtEdoCivil.Text = dtgFichaTecnica.CurrentRow.Cells[5].Value.ToString();
            txtDrogas.Text = dtgFichaTecnica.CurrentRow.Cells[6].Value.ToString();
            txtLateralizacion.Text = dtgFichaTecnica.CurrentRow.Cells[7].Value.ToString();
            txtHijos.Text = dtgFichaTecnica.CurrentRow.Cells[8].Value.ToString();
            txtPasatiempo.Text = dtgFichaTecnica.CurrentRow.Cells[9].Value.ToString();
            txtEredo.Text = dtgFichaTecnica.CurrentRow.Cells[10].Value.ToString();
            txtMedicacion.Text = dtgFichaTecnica.CurrentRow.Cells[11].Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ///
            limpForm();
            ///
        }
        ////////////////////////////////////////////////////////////////////////
    }
}
