using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Launcher_Yakuza
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            // Cierra toda la aplicación
            Application.Exit();
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            // Minimiza la ventana principal
            this.WindowState = FormWindowState.Minimized;
        }

        //Vista Derecha
        private void opcion1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario correspondiente a la opción 1
            FormOpcion1 formOpcion1 = new FormOpcion1();
            formOpcion1.TopLevel = false;
            formOpcion1.FormBorderStyle = FormBorderStyle.None;
            formOpcion1.Dock = DockStyle.Fill;

            // Limpia el contenido anterior del panel y agrega el nuevo formulario
            panelDerecho.Controls.Clear();
            panelDerecho.Controls.Add(formOpcion1);

            formOpcion1.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void remaster3_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario correspondiente a la opción 1
            FormOpcion2 formOpcion2 = new FormOpcion2();
            formOpcion2.TopLevel = false;
            formOpcion2.FormBorderStyle = FormBorderStyle.None;
            formOpcion2.Dock = DockStyle.Fill;

            // Limpia el contenido anterior del panel y agrega el nuevo formulario
            panelDerecho.Controls.Clear();
            panelDerecho.Controls.Add(formOpcion2);

            formOpcion2.Show();
        }

        private void remaster4_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario correspondiente a la opción 1
            FormOpcion3 formOpcion3 = new FormOpcion3();
            formOpcion3.TopLevel = false;
            formOpcion3.FormBorderStyle = FormBorderStyle.None;
            formOpcion3.Dock = DockStyle.Fill;

            // Limpia el contenido anterior del panel y agrega el nuevo formulario
            panelDerecho.Controls.Clear();
            panelDerecho.Controls.Add(formOpcion3);

            formOpcion3.Show();
        }

        private void remaster5_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario correspondiente a la opción 1
            FormOpcion4 formOpcion4 = new FormOpcion4();
            formOpcion4.TopLevel = false;
            formOpcion4.FormBorderStyle = FormBorderStyle.None;
            formOpcion4.Dock = DockStyle.Fill;

            // Limpia el contenido anterior del panel y agrega el nuevo formulario
            panelDerecho.Controls.Clear();
            panelDerecho.Controls.Add(formOpcion4);

            formOpcion4.Show();
        }

        private void yakuza6_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario correspondiente a la opción 1
            FormOpcion5 formOpcion5 = new FormOpcion5();
            formOpcion5.TopLevel = false;
            formOpcion5.FormBorderStyle = FormBorderStyle.None;
            formOpcion5.Dock = DockStyle.Fill;

            // Limpia el contenido anterior del panel y agrega el nuevo formulario
            panelDerecho.Controls.Clear();
            panelDerecho.Controls.Add(formOpcion5);

            formOpcion5.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
