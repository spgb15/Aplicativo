using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.ViewsMostrador
{
    public partial class HomeMostrador : Form
    {
        private Usuario user = new Usuario();
        public HomeMostrador()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            redondearBoton(btnDashboard);
            redondearBoton(btnAgendamiento);
            redondearBoton(btnPacientes);
            redondearBoton(btnPagos);
            redondearBoton(btnInfo);
            redondearBoton(btnReports);
            redondearBoton(btnLogOut);
            redondearBoton(btnHelp);
            lblNombre.Text = user.nombre;
            lblEmail.Text = user.email;
            Console.WriteLine(user.nombre + " " + user.email + " " + " Hola");

        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void redondearBoton(Button Boton)
        {
            Boton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Boton.Width, Boton.Height, 5, 5));

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
