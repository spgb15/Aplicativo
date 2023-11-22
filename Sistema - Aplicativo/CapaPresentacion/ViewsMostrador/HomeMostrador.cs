using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.ViewsMostrador
{
    public partial class HomeMostrador : Form
    {
        public HomeMostrador()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;

        }

        private void panelMenuLeft_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
