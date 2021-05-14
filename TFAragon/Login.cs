using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using TFAragon.FomormsEmpleado;

namespace TFAragon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public string sIE;
        static string conn = "SERVER = b6uzer3uyljskeemi0nr-mysql.services.clever-cloud.com; PORT=3306;DATABASE=b6uzer3uyljskeemi0nr;UID=uxbxj6okoaaumlr0;PWD=tZ5XuHvRCMFXxppdCXIU;";
        MySqlConnection cn = new MySqlConnection(conn);

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
            Application.Exit();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        ////////////////////////////////////////////////////////////////////////
        
        /*Botones*/
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcetar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                cmd.Connection = cn;

                cmd.CommandText = ("SELECT rol, nombre, apellidos, IE, credencialacceso, claveacceso FROM empleados WHERE credencialacceso='" + txtUser.Text + "' AND claveacceso='" +txtContraseña.Text+"';");
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string rol = Convert.ToString(dr[0]);
                    if (rol == "superadmin")
                    {
                        dsAdmin ver = new dsAdmin();
                        MessageBox.Show("Bienvenido " + Convert.ToString(dr[1]) + " " + Convert.ToString(dr[2]));
                        ver.Show();
                        this.Hide();
                    }
                    else if (rol== "empleado")
                    {
                        dsEmpleado ini = new dsEmpleado();
                        MessageBox.Show("Bienvenido " + Convert.ToString(dr[1]) + " " + Convert.ToString(dr[2]));
                        ini.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Acceso no autorizado");
                        txtContraseña.Text = "";
                        txtUser.Text = "";
                    }
                    
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                    txtContraseña.Text = "";
                    txtUser.Text = "";
                }
                
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ah ocurrido un error: " + ex.ToString());
            }
            
        }
        /// ////////////////////////////////////////////////////////////////
        
        
    }
}
