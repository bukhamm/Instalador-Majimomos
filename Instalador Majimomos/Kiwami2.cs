using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Instalador_Majimomos
{
    public partial class Kiwami2 : Form
    {
        private WebClient webClient;
        private System.Windows.Forms.ProgressBar progressBar1;

        public Kiwami2()
        {
            InitializeComponent();
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
                MessageBox.Show("Descarga completada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSteam_Click(object sender, EventArgs e)
        {
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

        private void btnGamepass_Click(object sender, EventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                ps3_folder = selectedPath;
                textBox1.Text = ps3_folder;
            }
        }
    }
    }


