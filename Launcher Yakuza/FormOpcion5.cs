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

namespace Launcher_Yakuza
{
    public partial class FormOpcion5 : Form
    {
        public FormOpcion5()
        {
            InitializeComponent();
            // Configurar los botones con bordes redondeados
            SetupRoundButton(STEAM);
            SetupRoundButton(XBOX);
            Load += FormOpcion1_Load;
        }

        private void SetupRoundButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button.Width, button.Height, 10, 10));
        }

        private void FormOpcion1_Load(object sender, EventArgs e)
        {
            // Establecer los bordes redondeados para el panel
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(15, 0, panel6.Width, panel6.Height, 15, 15));
            panel7.Region = Region.FromHrgn(CreateRoundRectRgn(15, 0, panel7.Width, panel7.Height, 15, 15));
        }


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
    }
}
