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
        TextBox[] palabras;
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
            int num = GenerarAleatorrio(totalElementos);
            this.lblPalabra.Text = arrayPalabras[num];
            MuestraFrase(this.lblPalabra.Text.ToUpper());
            this.groupBoxFraseaAdivinar.Text = $"Frase a adivinar: {this.lblPalabra.Text}";
            MessageBox.Show($"Total elementos{totalElementos} - {num}");

        }
        private void MuestraFrase(string frase)
        {
            this.groupBoxFraseaAdivinar.Controls.Clear();

            palabras = new TextBox[frase.Length];
            int cont = 0, x = 15, y = 27;
            foreach (Char c in frase)
            {
                palabras[cont] = new TextBox();
                palabras[cont].Size = new Size(60, 60);
                palabras[cont].TextAlign = HorizontalAlignment.Center;
                palabras[cont].MaxLength = 1;
                palabras[cont].Multiline = true;
                palabras[cont].ReadOnly = true;
                Font fuente = new Font("Calibri", 24);
                palabras[cont].Font = fuente;
                palabras[cont].Text = "";
                palabras[cont].Tag = c.ToString();
                palabras[cont].Location = new Point(x, y);
                x += 72;
                this.groupBoxFraseaAdivinar.Controls.Add(palabras[cont]);
            }
        }

        private void frmJuegoAhorcado_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (this.txtLetra.Text.Length > 0)
            {
                for(int i=0; i<palabras.Length; i++)
                {

                }
            }
        }
    }
}
