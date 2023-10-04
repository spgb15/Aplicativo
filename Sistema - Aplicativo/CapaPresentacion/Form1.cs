using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.ViewsAdmin;
using CapaPresentacion.ViewsGestor;
using CapaPresentacion.ViewsMostrador;



namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        private bool isPasswordVisible = false;
        private static string eyeOpenPath = Path.Combine(Application.StartupPath, "img", "eye_open.png");
        private static string eyeClosedPath = Path.Combine(Application.StartupPath, "img", "eye_closed.png");
        CN_Login neg = new CN_Login();

        public Form1()
        {
            InitializeComponent();
            panelUp.BackColor = Color.FromArgb(128, 15, 15, 15);
            panelLine_up.BackColor = Color.FromArgb(21, 191, 168);
            panelLine_Down.BackColor = Color.FromArgb(21, 191, 168);
            btnIngresar.BackColor = Color.FromArgb(163, 112, 240);
            txtPass.UseSystemPasswordChar = true;
            if (File.Exists(eyeClosedPath))
            {
                pictureBox3.Image = Image.FromFile(eyeClosedPath);

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

            if (isPasswordVisible)
            {
                pictureBox3.Image = Image.FromFile(eyeOpenPath);
            }
            else
            {
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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtUser.Text != "" || txtPass.Text != "")
            {
                Usuario usuario = neg.Login(txtUser.Text, txtPass.Text);
                if(usuario != null)
                {
                    int perfil = usuario.rol;
                    abrirForm(perfil).Show();
                    this.Hide();
                }
                else
                {
                    txtUser.Clear();
                    txtPass.Clear();
                    MessageBox.Show("El usuario no se encuentra");
                }

            }
            else
            {
                MessageBox.Show("Existen Campos Vacios");
            }

        }


        private Form abrirForm(int perfil)
        {
            switch (perfil)
            {
                case 1:
                    return new HomeAdmin();
                    break;
                case 2:
                    return new HomeGestor();
                    break;
                case 3:
                    return new HomeMostrador();
                    break;
                default:
                    throw new ArgumentException("Perfil No encontrado");
            }
        }
    }
}