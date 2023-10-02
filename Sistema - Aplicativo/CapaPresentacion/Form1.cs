using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        private bool isPasswordVisible = false;
        private string eyeOpenPath = "C:\\Users\\spaul\\Documents\\GitHub\\Aplicativo\\Sistema - Aplicativo\\img\\eye_open.png";
        private string eyeClosedPath = "C:\\Users\\spaul\\Documents\\GitHub\\Aplicativo\\Sistema - Aplicativo\\img\\eye_closed.png";

        public Form1()
        {
            InitializeComponent();
            panelUp.BackColor = Color.FromArgb(128, 15, 15, 15);
            panelLine_up.BackColor = Color.FromArgb(21, 191, 168);
            panelLine_Down.BackColor = Color.FromArgb(21, 191, 168);
            btnIngresar.BackColor = Color.FromArgb(163, 112, 240);
            txtPass.UseSystemPasswordChar = true;
            pictureBox3.Image = Image.FromFile(eyeClosedPath);

            
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
                pictureBox3.Image = Image.FromFile(eyeOpenPath);
            }
            else {
                pictureBox3.Image = Image.FromFile(eyeClosedPath);
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
    }
}
