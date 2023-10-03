using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;



namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        private bool isPasswordVisible = false;
        private static string[] eyeOpenPath = {
            "C:\\Users\\spaul\\Documents\\GitHub\\Aplicativo\\Sistema - Aplicativo\\img\\eye_open.png",
            "C:\\Users\\Paul Guerra\\Documents\\Proyecto\\Aplicativo\\Sistema - Aplicativo\\img\\eye_open.png" };

        private static string[] eyeClosedPath = {
            "C:\\Users\\spaul\\Documents\\GitHub\\Aplicativo\\Sistema - Aplicativo\\img\\eye_closed.png",
            "C:\\Users\\Paul Guerra\\Documents\\Proyecto\\Aplicativo\\Sistema - Aplicativo\\img\\eye_closed.png" };

        private string ruta = eyeClosedPath[1];
        private string ruta2 = eyeOpenPath[1];


        public Form1()
        {
            InitializeComponent();
            panelUp.BackColor = Color.FromArgb(128, 15, 15, 15);
            panelLine_up.BackColor = Color.FromArgb(21, 191, 168);
            panelLine_Down.BackColor = Color.FromArgb(21, 191, 168);
            btnIngresar.BackColor = Color.FromArgb(163, 112, 240);
            txtPass.UseSystemPasswordChar = true;
            if (File.Exists(ruta))
            {
                pictureBox3.Image = Image.FromFile(ruta);

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void arrow_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtPass.UseSystemPasswordChar = !isPasswordVisible;

            if(isPasswordVisible)
            {
                pictureBox3.Image = Image.FromFile(ruta2);
            }
            else {
                pictureBox3.Image = Image.FromFile(ruta);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "" || txtPass.Text != "")
            {
            }
        }
    }
}
