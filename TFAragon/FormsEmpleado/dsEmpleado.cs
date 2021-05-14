using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFAragon.FomormsEmpleado
{
    public partial class dsEmpleado : Form
    {
        public dsEmpleado()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pChild.Controls.Add(childForm);
            pChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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
        /*Botones barra de desplazamiento*/
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

        
        /**********************Botones Interfaz**********************/
        private void btnESEmpleados_Click(object sender, EventArgs e)
        {
            openChildForm(new EntradaSalidaE());
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            openChildForm(new PagosE());
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            openChildForm(new Gastos());
        }

        private void btnServiciosCliente_Click(object sender, EventArgs e)
        {
            openChildForm(new ServicioClienteE());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login ver = new Login();
            ver.Show();
            this.Close();
        }
    }
}
