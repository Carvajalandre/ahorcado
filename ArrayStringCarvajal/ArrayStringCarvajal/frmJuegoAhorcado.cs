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

namespace ArrayStringCarvajal
{
    public partial class frmJuegoAhorcado : Form
    {
        const int MAX = 1000;
        string[] arrayPalabras;
        int totalElementos;
        string categoria = "";
        public frmJuegoAhorcado()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MuestraCategoria(string categoria)
        {
            this.lblCategoria.Text = categoria;
        }
        private void abrirCategoríaNombresPropiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoria = "NOMBRES PROPIOS";
            MuestraCategoria(categoria);

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString(),
                Title = "Seleccione el archivo de texto",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "archivos txt (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nombreArchivo = openFileDialog1.FileName;
               this.LeerArchivoTexto(nombreArchivo);
            }
        }

        private void LeerArchivoTexto(string nombreArchivo)
        {
            String line;
            arrayPalabras = new string[MAX];
            int cont = 0;
            totalElementos = 0;
            try
            {
                StreamReader sr = new StreamReader(nombreArchivo, Encoding.UTF8);
                line = sr.ReadLine();
                while (line != null && cont < MAX)
                {
                    arrayPalabras[cont] = line;
                    totalElementos++;
                    line = sr.ReadLine();
                    cont++;
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
                MessageBox.Show($"Total elementos{totalElementos}");
            }
        }

        private int GenerarAleatorrio(int totalElementos)
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            int Numeroaleatorio = random.Next(0, totalElementos);

            return Numeroaleatorio;
        }

        private void nuevoJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Total elementos{totalElementos}");
            this.lblPalabra.Text = arrayPalabras[GenerarAleatorrio(totalElementos)];
        }
    }
}
