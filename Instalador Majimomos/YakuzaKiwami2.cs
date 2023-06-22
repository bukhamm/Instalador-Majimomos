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

namespace Instalador_Majimomos
{
    public partial class YakuzaKiwami2 : Form
    {
        public YakuzaKiwami2()
        {
            InitializeComponent();
            //Itashi sano iguale whigua
            if (gameversion == "Gamepass")
            {
                label1.Text = "Seleccione el Directorio Gamepass donde instalo el juego";
            }
            if (gameversion == "Steam")
            {
                label1.Text = "Seleccione el Directorio Steam donde instalo el juego";
            }
            else
            {
                label1.Text = "Seleccione su version del juego";
            }

        }
        public string gameversion { get; set; }
        public string wea { get; set; }
        public string Aletse { get; set; }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Mostrar el progreso de la descarga en una ProgressBar
            progressBar1.Value = e.ProgressPercentage;
            label2.Text = "Descargando Archivos de la Traduccion...";
        }

        private void install_Click(object sender, EventArgs e)
        {
           
        }

        private void path_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                Aletse = selectedPath;
                textBox1.Text = Aletse;
            }
        }

        private void SKCM_Click(object sender, EventArgs e)
        {
            if (gameversion == "Gamepass")
            {
                MessageBox.Show("Version de Gamepass.");
            }
            if (gameversion == "Steam")
            {
                string[] urls = {
            "https://yakuzaps3traduccion.000webhostapp.com/yakuza.dds",
            "https://yakuzaps3traduccion.000webhostapp.com/yakuza_italic.dds",
            "https://yakuzaps3traduccion.000webhostapp.com/db.par",
            "https://yakuzaps3traduccion.000webhostapp.com/YakuzaKiwami2.exe"
        };
                //$"{ps3_folder}\\Aarshivo1.yk2"; > Aletse
                string[] destinations = {
            $"{Aletse}\\data\\font\\en\\yakuza.dds",
            $"{Aletse}\\data\\font\\en\\yakuza_italic.dds",
            $"{Aletse}\\data\\db.par",
            $"{Aletse}\\YakuzaKiwami2.exe"
        };

                for (int i = 0; i < urls.Length; i++)
                {
                    string url = urls[i];
                    string destination = destinations[i];
                    label2.Text = "Descargando archivo: " + destination;
                    //Console.WriteLine();

                    using (WebClient client = new WebClient())
                    {
                        try
                        {
                            client.DownloadFile(url, destination);
                            label2.Text = "Archivo descargado correctamente.";
                        }
                        catch (Exception ex)
                        {
                            label2.Text = "Error al descargar el archivo: " + ex.Message;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado version.");
            }
        }

        private void kiryu_CheckedChanged(object sender, EventArgs e)
        {
            gameversion = "Steam";
            wea = "Seleccione el Directorio " + gameversion + " donde instalo el juego";
            label1.Text = wea;
        }

        private void majima_CheckedChanged(object sender, EventArgs e)
        {
            gameversion = "Gamepass";
            wea = "Seleccione el Directorio " + gameversion + " donde instalo el juego";
            label1.Text = wea;
        }
    }
}
