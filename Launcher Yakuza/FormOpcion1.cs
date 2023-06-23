using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Launcher_Yakuza
{
    public partial class FormOpcion1 : Form
    {
        public FormOpcion1()
        {
            InitializeComponent();
            // Configurar los botones con bordes redondeados
            SetupRoundButton(STEAM);
            SetupRoundButton(XBOX);
            Load += FormOpcion1_Load;
        }

        public string ps3_folder { get; set; }
        private void DescargarArchivos(string[] urls, string[] destinos)
        {
            if (urls.Length != destinos.Length)
            {
                MessageBox.Show("La cantidad de URLs no coincide con la cantidad de destinos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            progressBar1.Value = 0;
            progressBar1.Maximum = urls.Length;

            for (int i = 0; i < urls.Length; i++)
            {
                using (WebClient webClient = new WebClient())
                {
                    int index = i; // Capturar el valor de i en una variable local para que no cambie en la descarga asincrónica
                    webClient.DownloadFileCompleted += (sender, e) => DownloadCompleted(sender, e, urls.Length);
                    webClient.DownloadProgressChanged += (sender, e) => DownloadProgressChanged(sender, e, index);
                    webClient.DownloadFileAsync(new Uri(urls[i]), destinos[i]);
                }
            }
        }

        private void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e, int index)
        {
            // Actualizar la barra de progreso correspondiente al archivo en progreso
            //int progress = (index * 100) + (e.ProgressPercentage / progressBar1.Maximum);
            //progressBar1.Value = progress;
        }

        private void DownloadCompleted(object sender, AsyncCompletedEventArgs e, int totalFiles)
        {
            progressBar1.Value++;

            if (progressBar1.Value == progressBar1.Maximum)
            {
                MessageBox.Show("Traduccion Instalada con Exito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error en la Instalacion.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        // Resto del código del formulario...

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Lógica del clic en la imagen
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Lógica del clic en el label2
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Lógica del clic en el label1
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Lógica del clic en la pictureBox2
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Lógica del panel2_Paint
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void STEAM_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                ps3_folder = selectedPath;
               
            }
            string[] urls = {
                "https://yakuzaps3traduccion.000webhostapp.com/yakuza.dds",
                "https://yakuzaps3traduccion.000webhostapp.com/yakuza_italic.dds",
                "https://yakuzaps3traduccion.000webhostapp.com/db.par",
                "https://yakuzaps3traduccion.000webhostapp.com/YakuzaKiwami2.exe"
            };

            string[] destinos = {
                $"{ps3_folder}\\data\\font\\en\\yakuza.dds",
                $"{ps3_folder}\\data\\font\\en\\yakuza_italic.dds",
                $"{ps3_folder}\\data\\db.par",
                $"{ps3_folder}\\YakuzaKiwami2.exe"
            };

            DescargarArchivos(urls, destinos);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void XBOX_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                ps3_folder = selectedPath;

            }
            string[] urls = {
                "https://yakuzaps3traduccion.000webhostapp.com/yakuza.dds",
                "https://yakuzaps3traduccion.000webhostapp.com/yakuza_italic.dds",
                "https://yakuzaps3traduccion.000webhostapp.com/export.par"
            };

            string[] destinos = {
                $"{ps3_folder}\\Content\\data\\font\\en\\yakuza.dds",
                $"{ps3_folder}\\Content\\data\\font\\en\\yakuza_italic.dds",
                $"{ps3_folder}\\Content\\data\\db.par"
            };

            DescargarArchivos(urls, destinos);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void NombreCreditos1_Click(object sender, EventArgs e)
        {

        }

        private void NombreCreditos2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void NombreCreditos3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void NombreCreditos5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
