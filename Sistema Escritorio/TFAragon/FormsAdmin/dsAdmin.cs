using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFAragon
{
    public partial class dsAdmin : Form
    {
        public dsAdmin()
        {
            InitializeComponent();
        }
        public string nombre, apellido, ie;

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Login ver = new Login();

            this.Close();
            ver.Show();
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

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            GestionUsuarios ver = new GestionUsuarios();
            this.Hide();
            ver.Show();
        }

        private void btnGestionClientes_Click(object sender, EventArgs e)
        {
            Clientes ver = new Clientes();
            ver.Show();
            this.Hide();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            Pagos ver = new Pagos();
            ver.Show();
            this.Hide();
        }

        private void btnInformeGastos_Click(object sender, EventArgs e)
        {
            GastosEmpresa ver = new GastosEmpresa();
            ver.Show();
            this.Hide();
        }

        private void btnServicioClinica_Click(object sender, EventArgs e)
        {
            ServiciosClinica ver = new ServiciosClinica();
            ver.Show();
            this.Hide();
        }

        private void btnServicioCliente_Click(object sender, EventArgs e)
        {
            ServicioCliente ver = new ServicioCliente();
            ver.Show();
            this.Hide();
        }

        private void btnESEmpleados_Click(object sender, EventArgs e)
        {
            EntradasSalidas ver = new EntradasSalidas();
            ver.Show();
            this.Hide();
        }
    }
}
