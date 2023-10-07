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
            this.AcceptButton = btnIngresar;
            this.Load += Form1_Load;
            this.Shown += Form1_Shown;
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;

            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;

            txtUser.TabIndex = 0;
            txtPass.TabIndex = 1;
            btnIngresar.TabIndex = 2;

            txtUser.KeyPress += TextBox_KeyPress;
            txtPass.KeyPress += TextBox_KeyPress;
            btnIngresar.KeyDown += Control_KeyDown;

       }


        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si se presiona la tecla Tab, cambia el foco al siguiente control en el orden de tabulación
            if (e.KeyChar == (char)Keys.Tab)
            {
                Control nextControl = GetNextControl((Control)sender, true);
                if (nextControl != null)
                {
                    nextControl.Focus();
                    e.Handled = true; // Evita que el carácter de tabulación se agregue al TextBox
                }
            }
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            // Si se presiona la tecla Tab, cambia el foco al siguiente control en el orden de tabulación
            if (e.KeyCode == Keys.Tab)
            {
                Control nextControl = GetNextControl((Control)sender, true);
                if (nextControl != null)
                {
                    nextControl.Focus();
                    e.Handled = true; // Evita que se procese la tecla Tab por defecto
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            panelLine_up.BackColor = Color.FromArgb(94, 161, 248);
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            panelLine_up.BackColor = Color.FromArgb(21, 191, 168);

        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            panelLine_Down.BackColor = Color.FromArgb(94, 161, 248);
        }
        
        private void txtPass_Leave(object sender, EventArgs e)
        {
            panelLine_Down.BackColor = Color.FromArgb(21, 191, 168);
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
            bool isValidId = neg.validacion(txtUser.Text);

            if(txtUser.Text != "" && isValidId == true || txtPass.Text != "")
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
                case 2:
                    return new HomeGestor();
                case 3:
                    return new HomeMostrador();
                default:
                    throw new ArgumentException("Perfil No encontrado");
            }
        }
    }
}